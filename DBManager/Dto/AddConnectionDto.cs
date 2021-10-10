using DBManager.Utils;
using System.Collections.Generic;

namespace DBManager.Dto
{
    public class AddConnectionDto
    {
        public EngineType Type { get; set; }
        public Dictionary<string, string> ConnectionParameters { get; set; }
        public string Name { get; set; }

        public AddConnectionDto()
        {
            ConnectionParameters = new Dictionary<string, string>();
        }
    }
}
