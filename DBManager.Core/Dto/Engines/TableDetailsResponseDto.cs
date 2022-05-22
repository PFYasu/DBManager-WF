using System;
using System.Collections.Generic;
using System.Data;

namespace DBManager.Core.Dto.Engines
{
    public class TableDetailsResponseDto
    {
        public DataTable Table { get; set; }
        public int? RowsCount { get; set; }
        public int? ColumnsCount { get; set; }
        public List<ColumnStructure> ColumnsStructure { get; set; }
        public Dictionary<string, string> CustomInformations { get; set; }

        public TableDetailsResponseDto()
        {
            ColumnsStructure = new List<ColumnStructure>();
            CustomInformations = new Dictionary<string, string>();
        }
    }

    public class ColumnStructure
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string ComparingSubtitlesMethod { get; set; }
    }
}
