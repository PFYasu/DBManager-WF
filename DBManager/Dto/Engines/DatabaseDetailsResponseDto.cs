using System;
using System.Collections.Generic;

namespace DBManager.Dto.Engines
{
    public class DatabaseDetailsResponseDto
    {
        public int TablesCount { get; set; }
        public List<TablesStructure> TablesStructure { get; set; }

        public DatabaseDetailsResponseDto()
        {
            TablesStructure = new List<TablesStructure>();
        }
    }

    public class TablesStructure
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public UInt64? Records { get; set; }
        public decimal? Size { get; set; }
        public string ComparingSubtitlesMethod { get; set; }
    }
}
