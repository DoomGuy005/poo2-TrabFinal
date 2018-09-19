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
using System.Windows.Shapes;
using Modelo;
using Negócio;



namespace Windows
{
    /// <summary>
    /// Lógica interna para CadastroWindow.xaml
    /// </summary>
    public partial class CadastroWindow : Window
    {
        public CadastroWindow()
        {
            InitializeComponent();
        }

        Cliente c = new Cliente();
        NCliente nc = new NCliente();
        

        private void AddClick(object sender, RoutedEventArgs e)
        {
            try
            {
                c.nome = txtNome.Text;
                c.email = txtEmail.Text;
                c.fone = txtFone.Text;
                c.nascimento = dataNasc.SelectedDate.Value;
            }
            catch (InvalidOperationException erro)
            {
                MessageBox.Show("PARA QUE O CADASTRO SEJA EFETUADO, POR FAVOR DIGITE OS DADOS ACIMA CORRETAMENTE.");
            }
            finally
            {
                nc.Insert(c);
                ReadClick(sender, e);
            }
        }

        private void UpdClick(object sender, RoutedEventArgs e)
        {
            try
            {
                c.nome = txtNome.Text;
                c.email = txtEmail.Text;
                c.fone = txtFone.Text;
                c.nascimento = dataNasc.SelectedDate.Value;
                nc.Update(c);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
            ReadClick(sender, e);
        }

        private void DelClick(object sender, RoutedEventArgs e)
        {
            c.nome = txtNome.Text;
            nc.Delete(c);
            ReadClick(sender, e);
        }

        private void ReadClick(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = null;
            grid.ItemsSource = nc.Select();
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                btnUpdate.IsEnabled = true;
                btnDelete.IsEnabled = true;
                c = grid.SelectedItem as Cliente;
                txtNome.Text = c.nome;
                txtEmail.Text = c.email;
                txtFone.Text = c.fone;
                dataNasc.SelectedDate = c.nascimento;
            }
            else
            {
                btnUpdate.IsEnabled = false;
                btnDelete.IsEnabled = false;
            }
        }
    }
}
