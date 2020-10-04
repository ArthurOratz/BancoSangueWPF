using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Banco_de_Sangue
{
    [Table("Coleta_Sangue")]
    class Coleta_Sangue
    {
        //Construtores
        public Coleta_Sangue(int Id, string Nome_doador, string funcionario, DateTime data, string tipo_sanguineo, int Quantidade_doada)
        {
            Id = Id;

            Nome_doador = Nome_doador;

            funcionario = funcionario;

            Data = Data;

            Tipo_sanguineo = Tipo_sanguineo;

            Quantidade_doada = Quantidade_doada;
                       
        }

        public Coleta_Sangue()
        {
            CriadoEm = DateTime.Now;
        }
        [Key]
        //Atributos, propriedades e caracteristicas
        public int Id { get; set; }

        public string Nome_doador { get; set; }

        public string funcionario { get; set; }

        public int Data { get; set; }

        public string Tipo_sanguineo { get; set; }

        public int Quantidade_doada { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome_doador: {Nome_doador} | Funcionario: {funcionario} | Data: {Data} | Tipo_sanguineo: {Tipo_sanguineo} | Quantidade_doada: {Quantidade_doada}";

        }

    }
}
