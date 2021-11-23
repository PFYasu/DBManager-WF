using System.Collections.Generic;

namespace DBManager.Core.Dto.Engines
{
    public class TableNamesResponseDto
    {
        public List<string> Names { get; set; }

        public TableNamesResponseDto()
        {
            Names = new List<string>();
        }
    }
}