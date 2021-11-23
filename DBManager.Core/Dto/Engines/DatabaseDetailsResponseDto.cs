using System;
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
        public string Type { get; set; }
        public UInt64? Records { get; set; }
        public decimal? Size { get; set; }
        public string ComparingSubtitlesMethod { get; set; }
    }
}
