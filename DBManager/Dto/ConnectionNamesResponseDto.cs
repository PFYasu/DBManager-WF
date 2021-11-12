using System.Collections.Generic;

namespace DBManager.Dto
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
