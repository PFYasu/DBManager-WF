using System.Data;

namespace DBManager.Core.Dto.Engines
{
    public class SendDataDto
    {
        public DataTable DataTable { get; set; }
        public string ConnectionName { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
    }
}
