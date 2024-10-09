using Microsoft.Extensions.DependencyInjection;

namespace WinFormMvp;

internal class ViewManager : IViewManager
{
    private readonly IServiceProvider _serviceProvider;

    public ViewManager(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Activate<T>()
        where T : class, IView
    {
        var view = _serviceProvider.GetRequiredService<T>();

        var presenter = _serviceProvider.GetRequiredService<BasePresenter<T>>();

        presenter.RegisterViewEvents();

        view.OpenView();
    }

    public void ActivateModal<T>()
        where T : class, IView
    {
        using var scope = _serviceProvider.CreateScope();

        var view = scope.ServiceProvider.GetRequiredService<T>();

        var presenter = _serviceProvider.GetRequiredService<BasePresenter<T>>();

        presenter.RegisterViewEvents();

        view.OpenViewModal();
    }

    public void Deactivate(IView view) => view.CloseView();

    void IViewManager.Activate<T, U>(U viewParameter)
    {
        throw new NotImplementedException();
    }

    void IViewManager.ActivateModal<T, U>(U viewParameter)
    {
        throw new NotImplementedException();
    }
}
