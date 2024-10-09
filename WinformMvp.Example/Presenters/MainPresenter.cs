using MVP.Sample.ViewDefinitions;
using WinFormMvp;

namespace MVP.Sample.Presenters;

internal class MainPresenter : BasePresenter<IMainView>
{
    public override void RegisterViewEvents()
    {
        View.OnOpenModalClicked += () =>
        {
            ViewManager.ActivateModal<IModalView>();
        };
    }
}
