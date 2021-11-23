using System;

namespace DBManager.Core.Presenters.Engines
{
    public class DataTransferMethods
    {
        public Func<string, Response> GetPresenter { get; set; }
        public Func<Response> GetConnectionNames { get; set; }
    }
}
