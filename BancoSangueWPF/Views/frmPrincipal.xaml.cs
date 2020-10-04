using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BancoSangueWPF.Views
{
    /// <summary>
    /// Lógica interna para frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Banco De Sangue",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menuCadastrarDoador_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarDoador frm = new frmCadastrarDoador();
            frm.ShowDialog();
        }
    }
}
