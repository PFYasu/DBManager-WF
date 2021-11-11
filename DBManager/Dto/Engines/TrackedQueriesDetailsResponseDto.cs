using System.Collections.Generic;

namespace DBManager.Dto.Engines
{
    public class TrackedQueriesDetailsResponseDto
    {
        public List<TrackedQueryDetails> TrackedQueriesDetails { get; set; }

        public TrackedQueriesDetailsResponseDto()
        {
            TrackedQueriesDetails = new List<TrackedQueryDetails>();
        }
    }

    public class TrackedQueryDetails
    {
        public string Name { get; set; }
        public uint TimePeriod { get; set; }
    }
}
