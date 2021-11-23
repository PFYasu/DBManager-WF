using DBManager.Core.Dto;
using DBManager.Core.Presenters;
using System;
using System.Threading.Tasks;

namespace DBManager.Core.Views.Engines
{
    public class ConnectorMethods
    {
        public Func<AddConnectionDto, Task<Response>> AddConnection { get; set; }
        public Func<UpdateConnectionDto, Task<Response>> UpdateConnection { get; set; }
        public Func<string, Response> GetConnectionSettings { get; set; }
    }
}
