using System.Data;

namespace DBManager.Dto.Engines
{
    public class TrackedQuerySnapshotDifferencesResponseDto
    {
        public DataTable Differences { get; set; }
        public int DifferentRows { get; set; }
    }
}
