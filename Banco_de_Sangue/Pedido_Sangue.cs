using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_de_Sangue
{
    class Pedido_Sangue
    {
        //Construtores
        public Pedido_Sangue(int Id, string Nome_hospital, string funcionario, string tipo_sanguineo, int Quantidade_doada)
        {
            Id = Id;

            Nome_hospital = Nome_hospital;

            funcionario = funcionario;

            Tipo_sanguineo = Tipo_sanguineo;

            Quantidade_doada = Quantidade_doada;
        }

        public Pedido_Sangue()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos, propriedades e caracteristicas
        public int Id { get; set; }

        public string Nome_hospital { get; set; }

        public int Data { get; set; }

        public string Tipo_sanguineo { get; set; }

        public int Quantidade_doada { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} | Nome_hospital: {Nome_hospital} | Data: {Data} | Tipo_sanguineo: {Tipo_sanguineo} | Quantidade_doada: {Quantidade_doada}";

        }
    }
}
