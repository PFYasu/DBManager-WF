using System.Collections.Generic;

namespace DBManager.Core.Dto.Engines
{
    public class DatabaseDetailsResponseDto
    {
        public int TablesCount { get; set; }
        public List<TableStructure> TablesStructure { get; set; }

        public DatabaseDetailsResponseDto()
        {
            TablesStructure = new List<TableStructure>();
        }
    }

    public class TableStructure
    {
        public string Name { get; set; }
        public ulong? Records { get; set; }
    }
}
