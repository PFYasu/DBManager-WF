using DBManager.Core.Dto;
using DBManager.Core.Presenters;
using System;

namespace DBManager.Core.Views.Engines
{
    public class ConnectorMethods
    {
        public Func<AddConnectionDto, Response> AddConnection { get; set; }
        public Func<UpdateConnectionDto, Response> UpdateConnection { get; set; }
        public Func<string, Response<AddConnectionDto>> GetConnectionSettings { get; set; }
    }
}
