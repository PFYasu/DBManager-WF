using DBManager.Utils;
using System.Collections.Generic;

namespace DBManager.Dto
{
    public class ConnectionDto
    {
        public EngineType Type { get; set; }
        public Dictionary<string, string> ConnectionParameters { get; set; }
        public string Name { get; set; }

        public ConnectionDto()
        {
            ConnectionParameters = new Dictionary<string, string>();
        }
    }
}
