namespace WinFormMvp;

public abstract class BasePresenter<T>
    where T : IView
{
    public T View { get; internal set; }

    public IViewManager ViewManager { get; internal set; }

    public abstract void RegisterViewEvents();
}

public abstract class BasePresenter<T, U> : BasePresenter<T>
    where T : IView
    where U : IViewParameter
{ }