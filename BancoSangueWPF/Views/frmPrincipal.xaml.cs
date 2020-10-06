﻿using BancoSangueWPF.DAL;
using BancoSangueWPF.Models;
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
        List<EstoqueSangue> listaEstoque = new List<EstoqueSangue>();

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

        private void menuCadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarFuncionario frm = new frmCadastrarFuncionario();
            frm.ShowDialog();
        }

        private void menuCadastrarHospital_Click(object sender, RoutedEventArgs e)
        {
            frmCadastroHospital frm = new frmCadastroHospital();
            frm.ShowDialog();
        }

        private void menuRetirada_Click(object sender, RoutedEventArgs e)
        {
            frmRetirada frm = new frmRetirada();
            frm.ShowDialog();
        }

        private void menuColeta_Click(object sender, RoutedEventArgs e)
        {
            frmColeta frm = new frmColeta();
            frm.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listaEstoque = EstoqueSangueDAO.Listar();
            dtaEstoqueSangue.ItemsSource = listaEstoque;
        }

        private void PopularDataGrid(EstoqueSangue estoque)
        {
            dynamic item = new
            {
                TipoSanguineo = estoque.TipoSanguineo,
                Quantidade = estoque.Quantidade
            };
            listaEstoque.Add(item);
        }
    }
}
