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
    /// Interaction logic for frmCadastrarFuncionario.xaml
    /// </summary>
    public partial class frmCadastrarFuncionario : Window
    {
        private readonly MessageBoxClass _messageBoxClass;

        private Funcionario funcionario;

        public frmCadastrarFuncionario()
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
                Funcionario funcionario = new Funcionario();

                funcionario.Nome = txtNome.Text;
                funcionario.Sobrenome = txtSobrenome.Text;
                funcionario.Cpf = txtCpf.Text;
                funcionario.Telefone = txtTelefone.Text;
                funcionario.Email = txtEmail.Text;
               

                if (FuncionarioDAO.Cadastrar(funcionario))
                {
                    _messageBoxClass.MensagemInfoOK("Funcionario Salvo!");
                    LimparForm();
                }
                else
                {
                    _messageBoxClass.MensagemErroOK("Funcionario ja cadastrado!");
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
            txtSobrenome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();

            txtNome.Focus();
            btnCadastrar.IsEnabled = true;
            btnRemover.IsEnabled = false;
            btnAlterar.IsEnabled = false;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                funcionario = FuncionarioDAO.BuscarPorCPF(txtCpf.Text);
                if (funcionario != null)
                {
                    btnCadastrar.IsEnabled = false;
                    btnAlterar.IsEnabled = true;
                    btnRemover.IsEnabled = true;

                    txtId.Text = funcionario.Id.ToString();
                    txtCriadoEm.Text = funcionario.CriadoEm.ToString();
                    txtNome.Text = funcionario.Nome;
                    txtSobrenome.Text = funcionario.Sobrenome;

                    txtCpf.Text = funcionario.Cpf;
                    txtTelefone.Text = funcionario.Telefone;
                    txtEmail.Text = funcionario.Email;
                   
                }
                else
                {
                    _messageBoxClass.MensagemErroOK("Funcionario não encontrado!!!");
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
            if (funcionario != null)
            {
                FuncionarioDAO.Remover(funcionario);
                _messageBoxClass.MensagemInfoOK("Funcionario Removido!");
            }
            else
            {
                _messageBoxClass.MensagemErroOK("O Funcionario não foi removido");
            }
            LimparForm();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (funcionario != null)
            {
                funcionario.Nome = txtNome.Text;
                funcionario.Sobrenome = txtSobrenome.Text;
                funcionario.Cpf = txtCpf.Text;
                funcionario.Telefone = txtTelefone.Text;
                funcionario.Email = txtEmail.Text;
               
               FuncionarioDAO.Alterar(funcionario);
                _messageBoxClass.MensagemInfoOK("Funcionario Alterado!");
            }
            else
            {
                _messageBoxClass.MensagemErroOK("O Funcionario não foi alterado");
            }
            LimparForm();
        }

    }
}
