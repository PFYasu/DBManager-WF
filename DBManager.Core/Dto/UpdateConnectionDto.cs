using System.Collections.Generic;

namespace DBManager.Core.Dto
{
    public class UpdateConnectionDto
    {
        public string OldName { get; set; }
        public string EngineType { get; set; }
        public Dictionary<string, string> ConnectionParameters { get; set; }
        public string Name { get; set; }

        public UpdateConnectionDto()
        {
            ConnectionParameters = new Dictionary<string, string>();
        }
    }
}