using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_de_Sangue
{
    class Funcionario
    {
        //Construtores
        public Funcionario(string nome, string cpf)
        {
            Nome_funcionario = nome;

            Cpf_funcionario = cpf;

            E_mail_funcionario = E_mail_funcionario;

            Telefone_funcionario = Telefone_funcionario;


        }

        public Funcionario()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos, propriedades e caracteristicas
        public string Nome_funcionario { get; set; }

        public string Cpf_funcionario { get; set; }

        public string E_mail_funcionario { get; set; }

        public int Telefone_funcionario { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome_funcionario} | Cpf: {Cpf_funcionario} | E-mail: {E_mail_funcionario} | Telefone: {Telefone_funcionario}";
            
        }

    }
}
