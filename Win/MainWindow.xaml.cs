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

namespace Windows
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
        }

        private void CadastroClick(object sender, RoutedEventArgs e)
        {
            CadastroWindow win = new CadastroWindow();
            win.Show();
        }

        private void RegistroClick(object sender, RoutedEventArgs e)
        {
            PeçasWindow win = new PeçasWindow();
            win.Show();
        }

        private void PedidosClick(object sender, RoutedEventArgs e)
        {
            PedidoWindow win = new PedidoWindow();
            win.Show();
        }

        private void VendasClick(object sender, RoutedEventArgs e)
        {
            VendasWindow win = new VendasWindow();
            win.Show();
        }

        
        private void MainClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
