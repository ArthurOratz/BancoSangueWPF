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
                retirada.HospitalID =(int)cboHospital.SelectedValue;
                var tipoSanguineo = (TipoSanguineo)cboTipoSanguineo.SelectedValue;
                retirada.TipoSanguineoID = tipoSanguineo.Id;

                //coleta.TipoSanguineo = coleta.Doador.TipoSanguineo;
                retirada.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                var estoque = EstoqueSangueDAO.BuscarPorTipoSanguineo(retirada.TipoSanguineoID);
                if ((estoque.Quantidade - retirada.Quantidade) > 0)
                {
                    if (RetiradaDAO.Cadastrar(retirada))
                    {
                        EstoqueSangueDAO.DiminuirEstoque(retirada.TipoSanguineoID, retirada.Quantidade);

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
                    _messageBoxClass.MensagemErroOK("Quantidade Solicitada Indisponivel!");
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
            txtData.Text = DateTime.Now.ToString();

            cboTipoSanguineo.ItemsSource = TipoSanguineoDAO.Listar();

            cboHospital.ItemsSource = HospitalDAO.Listar();
            cboHospital.DisplayMemberPath = "Nome";
            cboHospital.SelectedValuePath = "Id";



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
