using WinFormMvp;

namespace MVP.Sample.ViewDefinitions;

internal interface IMainView : IView
{
    Action OnOpenModalClicked { get; set; }
}
