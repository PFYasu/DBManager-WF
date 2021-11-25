using DBManager.Core.Dto;
using DBManager.Core.Models;
using DBManager.Core.Models.Engines;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBManager.Presenters
{
    public class DBManagerPresenter : IDBManagerPresenter
    {
        private readonly IDBManagerModel _model;
        private readonly Dictionary<string, IEnginePresenter> _presenters;
        private readonly DataTransferMethods _dataTransferMethods;

        public DBManagerPresenter(IDBManagerModel model)
        {
            _model = model;
            _presenters = new Dictionary<string, IEnginePresenter>();

            _dataTransferMethods = new DataTransferMethods
            {
                GetConnectionNames = GetConnectionNames,
                GetPresenter = GetPresenter
            };
        }

        public async Task<Response> AddConnection(AddConnectionDto dto)
        {
            if (ConnectionExists(dto.Name))
                return Response.Error($"Connection with {dto.Name} name already exists");

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
                    EngineType = presenterFromDictionary.EngineType,
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

            var engineType = connection.EngineType;

            if (EngineModules.Attributes.TryGetValue(engineType, out var engineModuleAttribute) == false)
                return Response.Error("Unable to create presenter. Incorrect engine type.");

            var model = (IEngineModel)Activator
                .CreateInstance(engineModuleAttribute.Model, connection);

            presenter = (IEnginePresenter)Activator.CreateInstance(
                engineModuleAttribute.Presenter,
                model,
                _dataTransferMethods);

            dto = new PresenterResponseDto
            {
                EngineType = engineType,
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

            var engineType = connection.EngineType;
            var connectionParameters = connection.ConnectionParameters;
            var name = connection.Name;

            var dto = new AddConnectionDto
            {
                EngineType = engineType,
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
