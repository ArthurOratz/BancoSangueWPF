using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_de_Sangue
{
    class Doador
    {
        //Construtores
        public Doador(string nome, string cpf, string E_mail_doador, int telefone_doador, string Tipo_sanguineo, int Peso)
        {
            Nome_doador = nome;

            Cpf_doador = cpf;

            E_mail_doador = E_mail_doador;

            Telefone_doador = Telefone_doador;

            Tipo_sanguineo = Tipo_sanguineo;

            Peso = Peso;
        }

        public Doador()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos, propriedades e caracteristicas
        public string Nome_doador { get; set; }

        public string Cpf_doador { get; set; }

        public string E_mail_doador { get; set; }

        public int Telefone_doador { get; set; }

        public string Tipo_sanguineo { get; set; }

        public int Peso { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome_doador} | Cpf: {Cpf_doador} | E-mail: {E_mail_doador} | Telefone: {Telefone_doador}" +
                $" | Tipo_sanguineo {Tipo_sanguineo} | Peso {Peso} | CriadoEm { CriadoEm}";


        }
    }
}
