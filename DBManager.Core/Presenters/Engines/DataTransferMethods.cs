using DBManager.Core.Dto;
using System;

namespace DBManager.Core.Presenters.Engines
{
    public class DataTransferMethods
    {
        public Func<string, Response<PresenterResponseDto>> GetPresenter { get; set; }
        public Func<Response<ConnectionNamesResponseDto>> GetConnectionNames { get; set; }
    }
}
