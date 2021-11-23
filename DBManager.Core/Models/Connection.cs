using DBManager.Core.Dto;
using System.Collections.Generic;

namespace DBManager.Core.Models
{
    public class Connection
    {
        public string Name { get; set; }
        public string EngineType { get; set; }
        public Dictionary<string, string> ConnectionParameters { get; set; }
        public List<TrackedQuery> TrackedQueries { get; set; }

        public Connection()
        {
            ConnectionParameters = new Dictionary<string, string>();
            TrackedQueries = new List<TrackedQuery>();
        }

        public static Connection FromDto(AddConnectionDto dto)
        {
            return new Connection
            {
                Name = dto.Name,
                EngineType = dto.EngineType,
                ConnectionParameters = dto.ConnectionParameters,
            };
        }

        public static Connection FromDto(UpdateConnectionDto dto)
        {
            return new Connection
            {
                Name = dto.Name,
                EngineType = dto.EngineType,
                ConnectionParameters = dto.ConnectionParameters
            };
        }
    }
}
