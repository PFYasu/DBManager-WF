using System;
using System.Collections.Generic;
using System.Data;

namespace DBManager.Dto.Engines
{
    public class TableDetailsResponseDto
    {
        public DataTable Table { get; set; }
        public int RowsCount { get; set; }
        public int ColumnsCount { get; set; }
        public List<ColumnsStructure> ColumnsStructure { get; set; }
        public decimal Size { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdate { get; set; }

        public TableDetailsResponseDto()
        {
            ColumnsStructure = new List<ColumnsStructure>();
        }
    }

    public class ColumnsStructure
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string ComparingSubtitlesMethod { get; set; }
    }
}
