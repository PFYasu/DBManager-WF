using DBManager.Dto;
using DBManager.Models;
using DBManager.Models.Engines;
using DBManager.Presenters.Engines;
using DBManager.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBManager.Presenters
{
    public class DBManagerPresenter : IDBManagerPresenter
    {
        private readonly IDBManagerModel _model;
        private readonly Dictionary<string, IEnginePresenter> _presenters;

        public DBManagerPresenter(IDBManagerModel model)
        {
            _model = model;
            _presenters = new Dictionary<string, IEnginePresenter>();
        }

        public async Task<Response> AddConnection(AddConnectionDto dto)
        {
            if (ConnectionExists(dto.Name))
                return Response.Error($"Connection with {dto.Name} name already exists");

            var connectionParameters = dto.ConnectionParameters;

            var connection = Connection.FromDto(dto);

            try
            {
                await _model.AddConnection(connection);
                await _model.LoadConnections();
            }
            catch (Exception exception)
            {
                return Response.Error(exception.Message);
            }

            return Response.Ok();
        }

        public Response GetPresenter(string connectionName)
        {
            PresenterResponseDto dto;
            IEnginePresenter presenter;

            if (_presenters.TryGetValue(connectionName, out IEnginePresenter presenterFromDictionary))
            {
                dto = new PresenterResponseDto
                {
                    Type = presenterFromDictionary.EngineType,
                    Presenter = presenterFromDictionary
                };

                return Response.Ok(dto);
            }

            if (ConnectionExists(connectionName) == false)
                return Response.Error($"Connection with {connectionName} name does not exist");

            Connection connection;

            try
            {
                connection = _model.GetConnection(connectionName);
            }
            catch (Exception exception)
            {
                return Response.Error(exception.Message);
            }

            IEngineModel model;

            switch (connection.Type)
            {
                case EngineType.MySql:
                    model = new MySqlModel(connection);
                    presenter = new MySqlPresenter(model, this);
                    break;
                case EngineType.PostgreSQL:
                    model = new PostgreSQLModel(connection);
                    presenter = new PostgreSQLPresenter(model, this);
                    break;
                default:
                    return Response.Error("Unable to create presenter. Incorrect engine type.");
            }

            var type = connection.Type;

            dto = new PresenterResponseDto
            {
                Type = type,
                Presenter = presenter
            };

            if (_presenters.ContainsKey(connectionName))
                return Response.Error($"Connection {connectionName} already exists in dictionary.");
            else
                _presenters.Add(connectionName, presenter);

            return Response.Ok(dto);
        }

        public async Task<Response> RemoveConnection(string connectionName)
        {
            if (ConnectionExists(connectionName) == false)
                return Response.Error($"Connection with {connectionName} name does not exist");

            try
            {
                await _model.RemoveConnection(connectionName);
                await _model.LoadConnections();
            }
            catch (Exception exception)
            {
                return Response.Error(exception.Message);
            }

            _presenters.Remove(connectionName);

            return Response.Ok();
        }

        public async Task<Response> UpdateConnection(UpdateConnectionDto dto)
        {
            if (ConnectionExists(dto.OldName) == false)
                return Response.Error($"{dto.OldName} connection does not exist");

            if (dto.OldName != dto.Name
                && ConnectionExists(dto.Name))
                return Response.Error($"Unable to change {dto.OldName} connection - {dto.Name} connection already exists");

            var connection = Connection.FromDto(dto);

            try
            {
                await _model.RemoveConnection(dto.OldName);
                await _model.AddConnection(connection);
                await _model.LoadConnections();
            }
            catch (Exception exception)
            {
                return Response.Error(exception.Message);
            }

            _presenters.Remove(dto.OldName);

            return Response.Ok();
        }

        public Response GetConnectionNames()
        {
            List<string> names;

            try
            {
                names = _model.GetConnectionNames();
            }
            catch (Exception exception)
            {
                return Response.Error(exception.Message);
            }

            var dto = new ConnectionNamesResponseDto { Names = names };

            return Response.Ok(dto);
        }

        public Response GetConnectionSettings(string connectionName)
        {
            if (ConnectionExists(connectionName) == false)
                return Response.Error($"Connection with {connectionName} does not exist");

            Connection connection;

            try
            {
                connection = _model.GetConnection(connectionName);
            }
            catch (Exception exception)
            {
                return Response.Error(exception.Message);
            }

            var type = connection.Type;
            var connectionParameters = connection.ConnectionParameters;
            var name = connection.Name;

            var dto = new AddConnectionDto
            {
                Type = type,
                ConnectionParameters = connectionParameters,
                Name = name
            };

            return Response.Ok(dto);
        }

        private bool ConnectionExists(string connectionName)
        {
            List<string> names;

            try
            {
                names = _model.GetConnectionNames();
            }
            catch (Exception)
            {
                return false;
            }

            return names.Contains(connectionName);
        }
    }
}
