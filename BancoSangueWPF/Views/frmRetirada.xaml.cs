using BancoSangueWPF.DAL;
using BancoSangueWPF.Models;
using BancoSangueWPF.Util;
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
    /// Interaction logic for frmRetirada.xaml
    /// </summary>
    public partial class frmRetirada : Window
    {
        private readonly MessageBoxClass _messageBoxClass;

        public frmRetirada()
        {
            _messageBoxClass = new MessageBoxClass();
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if ((cboHospital.SelectedItem != null)
                && (cboTipoSanguineo.SelectedItem != null)
               && !string.IsNullOrEmpty(txtQuantidade.Text)
               )
            {
                Retirada retirada = new Retirada();

                //int idHospital = (int)cboHospital.SelectedValue;
                retirada.Hospital = HospitalDAO.BuscarPorId((int)cboHospital.SelectedValue);
                retirada.TipoSanguineo = (TipoSanguineo)cboHospital.SelectedValue;

                //coleta.TipoSanguineo = coleta.Doador.TipoSanguineo;
                retirada.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                if (RetiradaDAO.Cadastrar(retirada))
                {
                    var teste = EstoqueSangueDAO.BuscarPorTipoSanguineo(retirada.TipoSanguineo);

                    _messageBoxClass.MensagemInfoOK("Retirada Salva!");
                    LimparForm();
                }
                else
                {
                    _messageBoxClass.MensagemErroOK("Retirada ja cadastrada!");
                }
            }
            else
            {
                _messageBoxClass.MensagemErroOK("Preencha os campos corretamente!");
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparForm();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboHospital.ItemsSource = HospitalDAO.Listar();
            cboHospital.DisplayMemberPath = "Nome";
            cboHospital.SelectedValuePath = "Id";

            cboTipoSanguineo.ItemsSource = TipoSanguineoDAO.Listar();

            txtData.Text = DateTime.Now.ToString();

        }
        private void LimparForm()
        {
            txtData.Clear();
            txtData.Text = DateTime.Now.ToString();
            cboHospital.SelectedIndex = -1;
            cboTipoSanguineo.SelectedIndex = -1;
            txtQuantidade.Clear();
        }
    }
}
