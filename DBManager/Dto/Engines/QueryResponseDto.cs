using DBManager.Utils;
using System.Data;

namespace DBManager.Dto.Engines
{
    public class QueryResponseDto
    {
        public QueryType Type { get; set; }
        public DataTable Table { get; set; }
    }
}
