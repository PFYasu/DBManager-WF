using DBManager.Core.Presenters.Engines;

namespace DBManager.Core.Dto
{
    public class PresenterResponseDto
    {
        public string EngineType { get; set; }
        public IEnginePresenter Presenter { get; set; }
    }
}
