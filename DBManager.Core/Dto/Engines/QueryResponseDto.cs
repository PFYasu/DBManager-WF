using DBManager.Core.Utils;
using System.Data;

namespace DBManager.Core.Dto.Engines
{
    public class QueryResponseDto
    {
        public QueryType Type { get; set; }
        public DataTable Table { get; set; }
    }
}
