using System.Collections.Generic;

namespace DBManager.Core.Dto.Engines
{
    public class DatabaseNamesResponseDto
    {
        public List<string> Names { get; set; }

        public DatabaseNamesResponseDto()
        {
            Names = new List<string>();
        }
    }
}
