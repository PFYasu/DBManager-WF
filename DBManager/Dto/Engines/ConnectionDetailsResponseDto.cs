using DBManager.Utils;
using System.Collections.Generic;
using System.Data;

namespace DBManager.Dto.Engines
{
    public class ConnectionDetailsResponseDto
    {
        public string Name { get; set; }
        public EngineType Type { get; set; }
        public string Uid { get; set; }
        public string Server { get; set; }
        public int Port { get; set; }
        public int DatabasesCount { get; set; }
        public List<DatabaseStructure> DatabasesStructure { get; set; }

        public ConnectionDetailsResponseDto()
        {
            DatabasesStructure = new List<DatabaseStructure>();
        }
    }

    public class DatabaseStructure
    {
        public string Name { get; set; }
    }
}
