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
    /// Interaction logic for frmCadastroHospital.xaml
    /// </summary>
    public partial class frmCadastroHospital : Window
    {
        private readonly MessageBoxClass _messageBoxClass;

        private Hospital hospital;

        public frmCadastroHospital()
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
                || !string.IsNullOrEmpty(txtEndereco.Text)
                || !string.IsNullOrEmpty(txtTelefone.Text)
                || !string.IsNullOrEmpty(txtNomeResponsavel.Text)
                )
            {
                Hospital hospital = new Hospital();

                hospital.Nome = txtNome.Text;
                hospital.Endereco = txtEndereco.Text;
                hospital.Telefone = txtTelefone.Text;
                hospital.NomeResponsavel = txtNomeResponsavel.Text;


                if (HospitalDAO.Cadastrar(hospital))
                {
                    _messageBoxClass.MensagemInfoOK("Hospital Salvo!");
                    LimparForm();
                }
                else
                {
                    _messageBoxClass.MensagemErroOK("Hospital ja cadastrado!");
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
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtNomeResponsavel.Clear();

            txtNome.Focus();
            btnCadastrar.IsEnabled = true;
            btnRemover.IsEnabled = false;
            btnAlterar.IsEnabled = false;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                hospital = HospitalDAO.BuscarPorNome(txtNome.Text);
                if (hospital != null)
                {
                    btnCadastrar.IsEnabled = false;
                    btnAlterar.IsEnabled = true;
                    btnRemover.IsEnabled = true;

                    txtId.Text = hospital.Id.ToString();
                    txtCriadoEm.Text = hospital.CriadoEm.ToString();
                    txtNome.Text = hospital.Nome;
                    txtEndereco.Text = hospital.Endereco;
                    txtTelefone.Text = hospital.Telefone;
                    txtNomeResponsavel.Text = hospital.NomeResponsavel;

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
            if (hospital != null)
            {
                HospitalDAO.Remover(hospital);
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
            if (hospital != null)
            {
                hospital.Nome = txtNome.Text;
                hospital.Endereco = txtEndereco.Text;
                hospital.Telefone = txtTelefone.Text;
                hospital.NomeResponsavel = txtNomeResponsavel.Text;

                HospitalDAO.Alterar(hospital);
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
