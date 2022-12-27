namespace DBManager.Core.Dto.Engines
{
    public class NewTrackedQueryDto
    {
        public string Name { get; set; }
        public string ConnectionName { get; set; }
        public string DatabaseName { get; set; }
        public string Query { get; set; }
        public uint TimePeriod { get; set; }
    }
}
