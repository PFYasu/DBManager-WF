namespace DBManager.Core.Dto.Engines
{
    public class TrackedQuerySnapshotDifferencesDto
    {
        public string FirstSnapshotName { get; set; }
        public string SecondSnapshotName { get; set; }
        public string TrackedQueryName { get; set; }
        public string ConnectionName { get; set; }
        public string DatabaseName { get; set; }
    }
}
