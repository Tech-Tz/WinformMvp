using Microsoft.Extensions.DependencyInjection;

namespace WinFormMvp;

public static class ServicesExtensions
{
    public static IServiceCollection AddView<T, U, V>(this IServiceCollection services)
        where T : IView
        where U : class, T
        where V : BasePresenter<T>
    {
        return services
            .AddScoped(typeof(T), typeof(U))
            .AddScoped(typeof(V))
            .AddScoped(typeof(BasePresenter<T>), sp =>
            {
                var presenter = (BasePresenter<T>)sp.GetRequiredService(typeof(V));

                var viewManager = sp.GetRequiredService<IViewManager>();
                var view = sp.GetRequiredService<T>();

                presenter.ViewManager = viewManager;
                presenter.View = view;

                return presenter;
            });
    }

    public static IServiceCollection AddMvp(this IServiceCollection services)
        => services.AddSingleton<IViewManager, ViewManager>();
}
