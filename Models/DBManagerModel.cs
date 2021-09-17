using DBManager.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DBManager.Models
{
    public class DBManagerModel : IDBManagerModel
    {
        private readonly List<Connection> _connections;

        private DBManagerModel()
        {
            _connections = new List<Connection>();
        }

        public static async Task<DBManagerModel> Initialize()
        {
            var instance = new DBManagerModel();

            await instance.LoadConnections();

            return instance;
        }

        public async Task LoadConnections()
        {
            using var reader = new StreamReader(Constants.Paths.ConnectionData);

            var json = await reader.ReadToEndAsync();
            var elements = JsonConvert.DeserializeObject<List<Connection>>(json);

            if (elements == null)
                return;

            _connections.Clear();

            foreach (var element in elements)
            {
                _connections.Add(element);
            }
        }

        public List<string> GetConnectionNames()
        {
            return _connections
                .Select(x => x.Name)
                .ToList();
        }

        public async Task AddConnection(Connection connection)
        {
            _connections.Add(connection);

            await File.WriteAllTextAsync(Constants.Paths.ConnectionData, JsonConvert.SerializeObject(_connections));
        }

        public Connection GetConnection(string connectionName)
        {
            return _connections
                .Where(x => x.Name == connectionName)
                .Single();
        }

        public async Task RemoveConnection(string connectionName)
        {
            var result = _connections.RemoveAll(x => x.Name == connectionName);

            if (result != 1)
                throw new InvalidOperationException("Removed more than one connection.");

            await File.WriteAllTextAsync(Constants.Paths.ConnectionData, JsonConvert.SerializeObject(_connections));
        }
    }
}
