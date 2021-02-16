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
using UI.WPF.State.Navigators;
using UI.WPF.ViewModels;

namespace UI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();

            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = serviceProvider.GetRequiredService<MainWindowViewModel>();
            mainWindow.Show();

            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddDbContext<WaWiContext>(options => options.UseSqlServer(ConfigurationManager.ConnectionStrings["JTLWAWI"].ConnectionString));

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IArtikelRepository, ArtikelRepository>();

            services.AddTransient<IArtikelService, ArtikelService>();

            services.AddScoped<MainWindowViewModel>();
            services.AddScoped<INavigator, Navigator>();

            return services.BuildServiceProvider();
        }

    }
}
