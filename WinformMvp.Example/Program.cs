using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVP.Sample.Presenters;
using MVP.Sample.ViewDefinitions;
using MVP.Sample.ViewImplementations;
using WinFormMvp;

namespace MVP.Sample;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var host = Host
            .CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services
                    .AddMvp()
                    .AddView<IMainView, MainView, MainPresenter>()
                    .AddView<IModalView, ModalView, ModalPresenter>();
            })
            .Build();

        var svcProvider = host.Services;

        var viewManager = svcProvider.GetRequiredService<IViewManager>();

        viewManager.Activate<IMainView>();
    }
}