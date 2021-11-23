using System.Collections.Generic;

namespace DBManager.Core.Dto
{
    public class AddConnectionDto
    {
        public string EngineType { get; set; }
        public Dictionary<string, string> ConnectionParameters { get; set; }
        public string Name { get; set; }

        public AddConnectionDto()
        {
            ConnectionParameters = new Dictionary<string, string>();
        }
    }
}
