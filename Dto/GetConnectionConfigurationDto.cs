using System.Collections.Generic;
using DBManager.Utils;

namespace DBManager.Dto
{
    public class GetConnectionConfigurationDto
    {
        public EngineType Type { get; set; }
        public Dictionary<string, string> Parameters { get; set; }

        public GetConnectionConfigurationDto()
        {
            Parameters = new Dictionary<string, string>();
        }
    }
}
