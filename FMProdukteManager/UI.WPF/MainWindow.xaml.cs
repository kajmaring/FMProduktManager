using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IArtikelService _artikelService;
        public MainWindow(IArtikelService artikelService)
        {
            _artikelService = artikelService;
            InitializeComponent();

            getAllTest();
        }

        public async void getAllTest()
        {
            var alle = await _artikelService.GetAllArtikelAsync();

            var vater = await _artikelService.GetAllVaterArtikelAsync();
        }
    }
}
