using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_de_Sangue
{
    class Hospital
    {
        //Construtores
        public Hospital(int Id, string Nome, string Endereco, int Telefone, string Nome_responsavel)
        {
            Id = Id;

            Nome_hospital = Nome_hospital;

            Endereco = Endereco;

            Telefone = Telefone;

            Nome_responsavel = Nome_responsavel;
        }

        public Hospital()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos, propriedades e caracteristicas
        public int Id { get; set; }

        public string Nome_hospital { get; set; }

        public string Endereco { get; set; }

        public int Telefone { get; set; }

        public string Nome_responsavel { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome_hospital} | Endereco: {Endereco} | Telefone: {Telefone} | Nome_responsavel: {Nome_responsavel}";

        }
    }
}
