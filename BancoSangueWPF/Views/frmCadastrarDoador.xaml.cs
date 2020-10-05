using BancoSangueWPF.DAL;
using BancoSangueWPF.Models;
using BancoSangueWPF.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private readonly MessageBoxClass _messageBoxClass;

        private Doador doador;

        public frmCadastrarDoador()
        {
            _messageBoxClass = new MessageBoxClass();

            InitializeComponent();
            txtNome.Focus();
            btnAlterar.IsEnabled = false;
            btnRemover.IsEnabled = false;
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text)
                || !string.IsNullOrEmpty(txtCpf.Text)
                || !string.IsNullOrEmpty(txtEmail.Text)
                || !string.IsNullOrEmpty(txtTelefone.Text)
                )
            {
                Doador doador = new Doador();

                doador.Nome = txtNome.Text;
                doador.Cpf = txtCpf.Text;
                doador.Telefone = txtTelefone.Text;
                doador.Email = txtEmail.Text;
                doador.Sexo = (string)cboSexo.SelectedValue;
                doador.Peso = Convert.ToDouble(txtPeso.Text);
                //doador.TipoSanguineo.Fator_RH = txtRh.Text;
                //doador.TipoSanguineo.Tipo_sanguineo = txtTipoSanguineo.Text;

                if (DoadorDAO.Salvar(doador))
                {
                    _messageBoxClass.MensagemInfoOK("Doador Salvo!");
                    LimparForm();
                }
                else
                {
                    _messageBoxClass.MensagemErroOK("Doador ja cadastrado!");
                }
            }
            else
            {
                _messageBoxClass.MensagemErroOK("Preencha os campos corretamente!");
            }
        }

        private void LimparForm()
        {
            txtId.Clear();
            txtCriadoEm.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtPeso.Clear();

            cboSexo.SelectedIndex=-1;
            cboTipoSanguineo.SelectedItem = null;
            //txtTipoSanguineo.Clear();
            //txtRh.Clear();

            txtNome.Focus();
            btnCadastrar.IsEnabled = true;
            btnRemover.IsEnabled = false;
            btnAlterar.IsEnabled = false;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                doador = DoadorDAO.BuscarPorCPF(txtCpf.Text);
                if (doador != null)
                {
                    btnCadastrar.IsEnabled = false;
                    btnAlterar.IsEnabled = true;
                    btnRemover.IsEnabled = true;

                    txtId.Text = doador.Id.ToString();
                    txtCriadoEm.Text = doador.CriadoEm.ToString();
                    txtNome.Text = doador.Nome;
                    txtCpf.Text = doador.Cpf;
                    txtTelefone.Text = doador.Telefone;
                    txtEmail.Text = doador.Email;
                    cboSexo.SelectedValue = doador.Sexo;
                    txtPeso.Text = doador.Peso.ToString();
                    cboTipoSanguineo.SelectedValue = doador.TipoSanguineo;
                    //txtRh.Text = doador.TipoSanguineo.Fator_RH;
                }
                else
                {
                    _messageBoxClass.MensagemErroOK("Doador não encontrado!!!");
                    LimparForm();
                }
            }
            else
            {
                _messageBoxClass.MensagemErroOK("Preencha o campo CPF!!!");
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparForm();
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (doador != null)
            {
                DoadorDAO.Remover(doador);
                _messageBoxClass.MensagemInfoOK("Doador Removido!");
            }
            else
            {
                _messageBoxClass.MensagemErroOK("O Doador não foi removido");
            }
            LimparForm();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (doador != null)
            {
                doador.Nome = txtNome.Text;
                doador.Cpf = txtCpf.Text;
                doador.Telefone = txtTelefone.Text;
                doador.Email = txtEmail.Text;
                doador.Sexo = (string)cboSexo.SelectedValue;
                doador.Peso = Convert.ToDouble(txtPeso.Text);
                doador.TipoSanguineo = (TipoSanguineo)cboTipoSanguineo.SelectedValue;
                //doador.TipoSanguineo.Tipo_sanguineo = txtTipoSanguineo.Text;
                DoadorDAO.Alterar(doador);
                _messageBoxClass.MensagemInfoOK("Doador Alterado!");
            }
            else
            {
                _messageBoxClass.MensagemErroOK("O Doador não foi alterado");
            }
            LimparForm();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            cboSexo.ItemsSource = new ItensSexo();
            cboTipoSanguineo.ItemsSource = TipoSanguineoDAO.Listar();

        }

    }
}

