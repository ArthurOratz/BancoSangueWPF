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
    /// Interaction logic for frmCadastrarDoador.xaml
    /// </summary>
    public partial class frmCadastrarDoador : Window
    {
        public frmCadastrarDoador()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            int n1 = Convert.ToInt32(txt1.Text);
            int n2 = Convert.ToInt32(txt2.Text);
            int soma = n1 + n2;
            MessageBox.Show($"Soma: {soma}");
        }
    }
}
