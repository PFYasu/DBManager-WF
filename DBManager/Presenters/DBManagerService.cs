using DBManager.Core;
using DBManager.Core.Dto;
using DBManager.Core.Models;
using DBManager.Core.Models.Engines;
using DBManager.Core.Presenters.Engines;
using DBManager.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBManager.Presenters
{
    public class DBManagerService
    {
        private readonly IDBManagerModel _model;
        private readonly DataTransferMethods _dataTransferMethods;
        private readonly Dictionary<string, IEnginePresenter> _presenters = new Dictionary<string, IEnginePresenter>();

        public DBManagerService(IDBManagerModel model, DataTransferMethods dataTransferMethods)
        {
            _model = model;
            _dataTransferMethods = dataTransferMethods;
        }

        public void InitializeEnginePresenters()
        {
            var connectionNames = _model.GetConnectionNames();

            foreach (var connectionName in connectionNames)
            {
                var connection = _model.GetConnection(connectionName);

                var engineType = connection.EngineType;

                if (EngineModules.Attributes.TryGetValue(engineType, out var engineModuleAttribute) == false)
                    throw new NotImplementedException($"{engineType} engine type is not supported.");

                var presenter = CreatePresenter(engineModuleAttribute, connection);

                if (_presenters.ContainsKey(connectionName))
                    throw new NotImplementedException($"{connectionName} connection already exists in dictionary.");
                    
                _presenters.Add(connectionName, presenter);
            }
        }

        public async Task AddConnection(AddConnectionDto dto)
        {
            if (ConnectionExists(dto.Name))
                throw new InvalidOperationException($"Connection with {dto.Name} name already exists.");

            var connection = Connection.FromDto(dto);

            _model.AddConnection(connection);
            await _model.SaveConnections();
            await _model.LoadConnections();
        }

        public PresenterResponseDto GetPresenter(string connectionName)
        {
            if (_presenters.TryGetValue(connectionName, out IEnginePresenter presenterFromDictionary))
            {
                return new PresenterResponseDto
                {
                    EngineType = presenterFromDictionary.EngineType,
                    Presenter = presenterFromDictionary
                };
            }

            if (ConnectionExists(connectionName) == false)
                throw new InvalidOperationException($"Connection with {connectionName} name does not exist.");

            var connection = _model.GetConnection(connectionName);
            var engineType = connection.EngineType;

            if (EngineModules.Attributes.TryGetValue(engineType, out var engineModuleAttribute) == false)
                throw new InvalidOperationException("Unable to create presenter. Incorrect engine type.");

            var presenter = CreatePresenter(engineModuleAttribute, connection);

            if (_presenters.ContainsKey(connectionName))
                throw new InvalidOperationException($"Connection {connectionName} already exists in dictionary.");
                
            _presenters.Add(connectionName, presenter);

            var dto = new PresenterResponseDto
            {
                EngineType = engineType,
                Presenter = presenter
            };

            return dto;
        }

        public async Task RemoveConnection(string connectionName)
        {
            if (ConnectionExists(connectionName) == false)
                throw new InvalidOperationException($"Connection with {connectionName} name does not exist.");

            _model.RemoveConnection(connectionName);
            await _model.SaveConnections();
            await _model.LoadConnections();

            _presenters.Remove(connectionName);
        }

        public async Task UpdateConnection(UpdateConnectionDto dto)
        {
            if (ConnectionExists(dto.OldName) == false)
                throw new InvalidOperationException($"{dto.OldName} connection does not exist.");

            if (dto.OldName != dto.Name && ConnectionExists(dto.Name))
                throw new InvalidOperationException($"Unable to change {dto.OldName} connection - {dto.Name} connection already exists.");

            var newConnection = Connection.FromDto(dto);

            _model.RemoveConnection(dto.OldName);
            _model.AddConnection(newConnection);
            await _model.SaveConnections();
            await _model.LoadConnections();

            _presenters.Remove(dto.OldName);
        }

        public ConnectionNamesResponseDto GetConnectionNames()
        {
            var names = _model.GetConnectionNames();

            var dto = new ConnectionNamesResponseDto { Names = names };

            return dto;
        }

        public AddConnectionDto GetConnectionSettings(string connectionName)
        {
            if (ConnectionExists(connectionName) == false)
                throw new InvalidOperationException($"Connection with {connectionName} does not exist");

            var connection = _model.GetConnection(connectionName);

            var dto = new AddConnectionDto
            {
                EngineType = connection.EngineType,
                ConnectionParameters = connection.ConnectionParameters,
                Name = connection.Name
            };

            return dto;
        }

        private bool ConnectionExists(string connectionName)
        {
            try
            {
                var connectionNames = _model.GetConnectionNames();
                return connectionNames.Contains(connectionName);
            }
            catch
            {
                return false;
            }
        }

        private IEnginePresenter CreatePresenter(EngineModuleAttribute engineModuleAttribute, Connection connection)
        {
            var model = (IEngineModel)Activator.CreateInstance(
                engineModuleAttribute.Model,
                connection);

            var presenter = (IEnginePresenter)Activator.CreateInstance(
                engineModuleAttribute.Presenter,
                model,
                _dataTransferMethods);

            return presenter;
        }
    }
}
