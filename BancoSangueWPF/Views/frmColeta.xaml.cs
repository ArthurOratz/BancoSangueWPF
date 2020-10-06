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
    /// Interaction logic for frmColeta.xaml
    /// </summary>
    public partial class frmColeta : Window
    {
        private readonly MessageBoxClass _messageBoxClass;

        public frmColeta()
        {
            _messageBoxClass = new MessageBoxClass();
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if ((cboFuncionario.SelectedItem != null)
               && (cboDoador.SelectedItem != null)
               && !string.IsNullOrEmpty(txtTipoSanguineo.Text)
               && !string.IsNullOrEmpty(txtQuantidade.Text)
               )
            {
                Coleta coleta = new Coleta();

                //coleta.Funcionario = (Funcionario)cboFuncionario.SelectedValue;
                //coleta.Doador = (Doador)cboDoador.SelectedValue;


                int idFuncionario = (int)cboFuncionario.SelectedValue;
                int idDoador = (int)cboDoador.SelectedValue;
                coleta.Funcionario = FuncionarioDAO.BuscarPorId(idFuncionario);
                coleta.Doador = DoadorDAO.BuscarPorId(idDoador);

                //coleta.TipoSanguineo = (TipoSanguineo)cboTipoSanguineo.SelectedValue;
                coleta.TipoSanguineo = coleta.Doador.TipoSanguineo;
                coleta.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                if (ColetaDAO.Cadastrar(coleta))
                {

                    var teste = EstoqueSangueDAO.BuscarPorTipoSanguineo(coleta.TipoSanguineo);

                    _messageBoxClass.MensagemInfoOK("Coleta Salva!");
                    LimparForm();
                }
                else
                {
                    _messageBoxClass.MensagemErroOK("Coleta ja cadastrada!");
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
            cboFuncionario.ItemsSource = FuncionarioDAO.Listar();
            cboFuncionario.DisplayMemberPath = "Nome";
            cboFuncionario.SelectedValuePath = "Id";

            cboDoador.ItemsSource = DoadorDAO.Listar();
            cboDoador.DisplayMemberPath = "Nome";
            cboDoador.SelectedValuePath = "Id";

            txtData.Text = DateTime.Now.ToString();

        }
        private void LimparForm()
        {
            txtData.Clear();
            txtData.Text = DateTime.Now.ToString();
            cboFuncionario.SelectedIndex = -1;
            cboDoador.SelectedIndex = -1;
            txtTipoSanguineo.Clear();
            txtQuantidade.Clear();
        }



        private void cboDoador_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboDoador.SelectedValue != null)
            {
                var idDoador = (int)cboDoador.SelectedValue;
                var doador = DoadorDAO.BuscarPorId(idDoador);
                txtTipoSanguineo.Text = doador.TipoSanguineo.ToString();
            }
        }
    }
}
