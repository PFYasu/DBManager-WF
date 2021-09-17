using DBManager.Utils;

namespace DBManager.Models
{
    public class Connection
    {
        public string Name { get; set; }
        public EngineType Type { get; set; }
        public string ConnectionString { get; set; }
    }
}
