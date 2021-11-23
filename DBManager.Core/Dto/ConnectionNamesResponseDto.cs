using System.Collections.Generic;

namespace DBManager.Core.Dto
{
    public class ConnectionNamesResponseDto
    {
        public List<string> Names { get; set; }

        public ConnectionNamesResponseDto()
        {
            Names = new List<string>();
        }
    }
}
