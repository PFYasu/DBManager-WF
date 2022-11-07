using System.Collections.Generic;

namespace DBManager.Core.Dto.Engines
{
    public class TrackedQueriesDetailsResponseDto
    {
        public List<TrackedQueryDetails> TrackedQueriesDetails { get; set; } = new List<TrackedQueryDetails>();
    }

    public class TrackedQueryDetails
    {
        public string Name { get; set; }
        public uint TimePeriod { get; set; }
        public int SnapshotsCount { get; set; }
    }
}
