using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ClientAPI.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ClientAPI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       public static IHost? AppHost { get; private set; }

        public App ()
        {
            // Configuração de Host Genérico
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Registro do HttpClientFactory
                    services.AddHttpClient();

                    // Registro da janela principal e viewModel
                    services.AddSingleton<MainWindow>();
                    services.AddSingleton<MainViewModel>();

                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();

            // Resolve a janala principal via DI
            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
            startupForm.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }
    }

}
