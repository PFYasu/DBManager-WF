using System.Collections.Generic;

namespace DBManager.Core.Dto.Engines
{
    public class ConnectionDetailsResponseDto
    {
        public string Name { get; set; }
        public string EngineType { get; set; }
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