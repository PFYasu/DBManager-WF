using System.Collections.Generic;

namespace DBManager.Dto.Engines
{
    public class TrackedQuerySnapshotsDetailsResponseDto
    {
        public List<string> SnapshotNames { get; set; }
        public uint TimePeriod { get; set; }

        public TrackedQuerySnapshotsDetailsResponseDto()
        {
            SnapshotNames = new List<string>();
        }
    }
}
