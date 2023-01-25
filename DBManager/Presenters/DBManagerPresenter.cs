using DBManager.Core.Dto;
using DBManager.Core.Dto.Engines;
using DBManager.Core.Models;
using DBManager.Core.Presenters;
using DBManager.Utils.Files;
using DBManager.Utils.Files.Routing;
using System.Linq;
using System.Threading.Tasks;

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

            _fileManager.Save(connection, Router.Init().Connection(dto.Name).SettingsPath());

            return Response.Ok();
        }

        public Response RemoveConnection(string connectionName)
        {
            if (ConnectionExists(connectionName) == false)
                return Response.Error($"Connection with {connectionName} name does not exist.");

            _fileManager.Delete(Router.Init().Connection(connectionName).SettingsPath());

            return Response.Ok();
        }

        public Response UpdateConnection(UpdateConnectionDto dto)
        {
            if (ConnectionExists(dto.OldName) == false)
                return Response.Error($"{dto.OldName} connection does not exist.");

            if (dto.OldName != dto.Name && ConnectionExists(dto.Name))
                return Response.Error($"Unable to change {dto.OldName} connection - {dto.Name} connection already exists.");

            var oldConnection = _fileManager.Load<Connection>(Router.Init().Connection(dto.OldName).SettingsPath());

            var newConnection = Connection.FromDto(dto);
            newConnection.TrackedQueries = oldConnection.TrackedQueries;

            _fileManager.Delete(Router.Init().Connection(dto.OldName).SettingsPath());
            _fileManager.Save(newConnection, Router.Init().Connection(newConnection.Name).SettingsPath());

            return Response.Ok();
        }

        public Response<ConnectionNamesResponseDto> GetConnectionNames()
        {
            var names = _fileManager
                .LoadMany<Connection>(Router.Init().CurrentDictionaryPath())
                .Select(x => x.Name)
                .ToList();

            var dto = new ConnectionNamesResponseDto { Names = names };

            return Response<ConnectionNamesResponseDto>.Ok(dto);
        }

        public Response<AddConnectionDto> GetConnectionSettings(string connectionName)
        {
            if (ConnectionExists(connectionName) == false)
                return Response<AddConnectionDto>.Error($"Connection with {connectionName} does not exist");

            var connection = _fileManager.Load<Connection>(Router.Init().Connection(connectionName).SettingsPath());

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

        public async Task<Response<DatabaseNamesResponseDto>> GetDatabaseNames(string connectionName)
        {
            var connection = _fileManager.Load<Connection>(Router.Init().Connection(connectionName).SettingsPath());

            if (connection == null)
                return Response<DatabaseNamesResponseDto>
                    .Error($"Connection {connectionName} does not exist.");

            var presenter = _engineModuleResolver.CreateEnginePresenter(connection);

            if (presenter == null)
                return Response<DatabaseNamesResponseDto>
                    .Error($"Unable to activate {connectionName} presenter. Engine type:{connection.EngineType}.");

            var dto = await presenter.GetDatabaseNames();

            return dto;
        }

        public async Task<Response<TableNamesResponseDto>> GetTableNames(string connectionName, string databaseName)
        {
            var connection = _fileManager.Load<Connection>(Router.Init().Connection(connectionName).SettingsPath());

            if (connection == null)
                return Response<TableNamesResponseDto>
                    .Error($"Connection {connectionName} does not exist.");

            var presenter = _engineModuleResolver.CreateEnginePresenter(connection);

            if (presenter == null)
                return Response<TableNamesResponseDto>
                    .Error($"Unable to activate {connectionName} presenter. Engine type:{connection.EngineType}.");

            var dto = await presenter.GetTableNames(databaseName);

            return dto;
        }

        private bool ConnectionExists(string connectionName)
        {
            try
            {
                var exists = _fileManager
                    .LoadMany<Connection>(Router.Init().CurrentDictionaryPath())
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
