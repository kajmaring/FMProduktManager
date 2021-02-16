using DAL.DBContext;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UI.WPF.ViewModels;

namespace UI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;

        public App()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WaWiContext>(options => options.UseSqlServer(ConfigurationManager.ConnectionStrings["JTLWAWI"].ConnectionString));

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IArtikelRepository, ArtikelRepository>();

            services.AddTransient<IArtikelService, ArtikelService>();
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.DataContext = new MainWindowViewModel();
            mainWindow.Show();
        }

    }
}
