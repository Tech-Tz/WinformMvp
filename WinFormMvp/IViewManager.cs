namespace WinFormMvp;

public interface IViewManager
{
    void Activate<T>()
        where T : class, IView;

    void ActivateModal<T>()
        where T : class, IView;

    void Activate<T, U>(U viewParameter)
        where T : IView
        where U : class, IViewParameter;

    void ActivateModal<T, U>(U viewParameter)
        where T : IView
        where U : class, IViewParameter;

    void Deactivate(IView view);
}