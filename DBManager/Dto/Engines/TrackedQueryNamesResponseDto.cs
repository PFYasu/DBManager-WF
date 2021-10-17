using System.Collections.Generic;

namespace DBManager.Dto.Engines
{
    public class TrackedQueryNamesResponseDto
    {
        public List<string> Names { get; set; }

        public TrackedQueryNamesResponseDto()
        {
            Names = new List<string>();
        }
    }
}
