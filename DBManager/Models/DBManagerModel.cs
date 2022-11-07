using DBManager.Core.Models;
using DBManager.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DBManager.Models
{
    public class DBManagerModel : IDBManagerModel, IAsyncDisposable
    {
        private readonly List<Connection> _connections = new List<Connection>();

        private DBManagerModel()
        {
        }

        public static async Task<DBManagerModel> Initialize()
        {
            var instance = new DBManagerModel();

            await instance.LoadConnections();

            return instance;
        }

        public async Task LoadConnections()
        {
            if (Directory.Exists(Constants.Paths.ConnectionsRespository) == false)
                Directory.CreateDirectory(Constants.Paths.ConnectionsRespository);

            _connections.Clear();

            foreach (var connectionRepositoryPath in Directory.GetFiles(Constants.Paths.ConnectionsRespository, "*.json"))
            {
                using (var reader = new StreamReader(connectionRepositoryPath))
                {
                    var json = await reader.ReadToEndAsync();
                    var connection = JsonConvert.DeserializeObject<Connection>(json);

                    _connections.Add(connection);
                }
            }
        }

        public List<string> GetConnectionNames()
            => _connections
            .Select(x => x.Name)
            .ToList();

        public void AddConnection(Connection connection)
            => _connections.Add(connection);

        public Connection GetConnection(string connectionName)
            => _connections.Single(x => x.Name == connectionName);

        public void RemoveConnection(string connectionName)
        {
            var result = _connections.RemoveAll(x => x.Name == connectionName);

            if (result != 1)
                throw new InvalidOperationException("Removed more than one connection.");

            File.Delete(ConnectionRepositoryPath(connectionName));
        }

        public async Task SaveConnections()
        {
            foreach (var connection in _connections)
            {
                using (var fileStream = new FileStream(ConnectionRepositoryPath(connection.Name), FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
                {
                    var streamReader = new StreamReader(fileStream);
                    using (var streamWriter = new StreamWriter(fileStream))
                    {
                        var serializedConnection = JsonConvert.SerializeObject(connection);

                        fileStream.SetLength(0);
                        await streamWriter.WriteAsync(serializedConnection);
                    }
                }
            }
        }

        public async ValueTask DisposeAsync()
        {
            await SaveConnections();
        }

        private string ConnectionRepositoryPath(string connectionName) => Path.Combine(Constants.Paths.ConnectionsRespository, $"{connectionName}.json");
    }
}
