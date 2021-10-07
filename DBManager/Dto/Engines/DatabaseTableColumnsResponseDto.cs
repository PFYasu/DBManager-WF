using System.Collections.Generic;

namespace DBManager.Dto.Engines
{
    public class DatabaseTableColumnsResponseDto
    {
        public Dictionary<string, List<string>> DatabaseTableColumns { get; set; }

        public DatabaseTableColumnsResponseDto()
        {
            DatabaseTableColumns = new Dictionary<string, List<string>>();
        }
    }
}
