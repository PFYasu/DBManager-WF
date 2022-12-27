using DBManager.Core.Dto;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Core.Presenters.Engines;
using DBManager.Utils.Files;
using System;
using System.Linq;

namespace DBManager.Presenters
{
    public class DBManagerPresenter : IDBManagerPresenter
    {
        private readonly IFileManager _fileManager;
        private readonly IEngineModuleResolver _engineModuleResolver;

        public DBManagerPresenter(IFileManager fileManager, IEngineModuleResolver engineModuleResolver)
        {
            _fileManager = fileManager;
            _engineModuleResolver = engineModuleResolver;
        }

        public Response AddConnection(AddConnectionDto dto)
        {
            if (ConnectionExists(dto.Name))
                return Response.Error($"Connection with {dto.Name} name already exists.");

            var connection = Connection.FromDto(dto);

            _fileManager.Save(connection, Router.ToConnection(dto.Name));

            return Response.Ok();
        }

        public Response<PresenterResponseDto> GetPresenter(string connectionName)
        {
            if (ConnectionExists(connectionName) == false)
                return Response<PresenterResponseDto>.Error($"Connection with {connectionName} name does not exist.");

            var connection = _fileManager.Load<Connection>(Router.ToConnection(connectionName));
            var engineType = connection.EngineType;

            IEnginePresenter presenter;
            try
            {
                presenter = _engineModuleResolver.CreateEnginePresenter(connection);
            }
            catch (Exception exception)
            {
                return Response<PresenterResponseDto>.Error(exception.Message);
            }

            var dto = new PresenterResponseDto
            {
                EngineType = engineType,
                Presenter = presenter
            };

            return Response<PresenterResponseDto>.Ok(dto);
        }

        public Response RemoveConnection(string connectionName)
        {
            if (ConnectionExists(connectionName) == false)
                return Response.Error($"Connection with {connectionName} name does not exist.");

            _fileManager.Delete(Router.ToConnection(connectionName));

            return Response.Ok();
        }

        public Response UpdateConnection(UpdateConnectionDto dto)
        {
            if (ConnectionExists(dto.OldName) == false)
                return Response.Error($"{dto.OldName} connection does not exist.");

            if (dto.OldName != dto.Name && ConnectionExists(dto.Name))
                return Response.Error($"Unable to change {dto.OldName} connection - {dto.Name} connection already exists.");

            var oldConnection = _fileManager.Load<Connection>(Router.ToConnection(dto.OldName));

            var newConnection = Connection.FromDto(dto);
            newConnection.TrackedQueries = oldConnection.TrackedQueries;

            _fileManager.Delete(Router.ToConnection(dto.OldName));
            _fileManager.Save(newConnection, Router.ToConnection(newConnection.Name));

            return Response.Ok();
        }

        public Response<ConnectionNamesResponseDto> GetConnectionNames()
        {
            var names = _fileManager
                .LoadMany<Connection>(Router.ToConnectionRepository())
                .Select(x => x.Name)
                .ToList();

            var dto = new ConnectionNamesResponseDto { Names = names };

            return Response<ConnectionNamesResponseDto>.Ok(dto);
        }

        public Response<AddConnectionDto> GetConnectionSettings(string connectionName)
        {
            if (ConnectionExists(connectionName) == false)
                return Response<AddConnectionDto>.Error($"Connection with {connectionName} does not exist");

            var connection = _fileManager.Load<Connection>(Router.ToConnection(connectionName));

            var dto = new AddConnectionDto
            {
                EngineType = connection.EngineType,
                ConnectionParameters = connection.ConnectionParameters,
                Name = connection.Name
            };

            return Response<AddConnectionDto>.Ok(dto);
        }

        public Response<ConnectorViewTypeResponseDto> GetConnectorViewType(string engineType)
        {
            var type = _engineModuleResolver.GetConnectorViewType(engineType);

            var dto = new ConnectorViewTypeResponseDto
            {
                ConnectorViewType = type
            };

            return Response<ConnectorViewTypeResponseDto>.Ok(dto);
        }

        public Response<EngineModuleNamesResponseDto> GetEngineModuleNames()
        {
            var names = _engineModuleResolver.GetEngineModuleNames();

            var dto = new EngineModuleNamesResponseDto { Names = names };

            return Response<EngineModuleNamesResponseDto>.Ok(dto);
        }

        private bool ConnectionExists(string connectionName)
        {
            try
            {
                var exists = _fileManager
                    .LoadMany<Connection>(Router.ToConnectionRepository())
                    .Exists(x => x.Name == connectionName);

                return exists;
            }
            catch
            {
                return false;
            }
        }
    }
}
