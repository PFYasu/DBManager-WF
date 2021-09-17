using System.Collections.Generic;

namespace DBManager.Dto
{
    public class ConnectionNamesDto
    {
        public List<string> Names { get; set; }

        public ConnectionNamesDto()
        {
            Names = new List<string>();
        }
    }
}
