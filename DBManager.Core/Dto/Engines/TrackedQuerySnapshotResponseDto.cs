using System;
using System.Data;

namespace DBManager.Core.Dto.Engines
{
    public class TrackedQuerySnapshotResponseDto
    {
        public DataTable Data { get; set; }
        public DateTime? Updated { get; set; }
    }
}