using DBManager.Utils;
using System.Collections.Generic;

namespace DBManager.Models
{
    public class Connection
    {
        public string Name { get; set; }
        public EngineType Type { get; set; }
        public Dictionary<string, string> ConnectionParameters { get; set; }
        public List<TrackedQuery> TrackedQueries { get; set; }

        public Connection()
        {
            ConnectionParameters = new Dictionary<string, string>();
            TrackedQueries = new List<TrackedQuery>();
        }
    }
}
