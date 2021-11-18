using DBManager.Presenters.Engines;
using DBManager.Utils;

namespace DBManager.Dto
{
    public class PresenterResponseDto
    {
        public EngineType Type { get; set; }
        public IEnginePresenter Presenter { get; set; }
    }
}
