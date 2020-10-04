using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Banco_de_Sangue
{
    [Table("Estoque_Sangue")]
    class Estoque_Sangue
    {
        //Construtores
        public Estoque_Sangue(string Quantidade_A_positivo, string Quantidade_A_negativo, string Quantidade_B_positivo,
            string Quantidade_B_negativo, string Quantidade_AB_positivo, string Quantidade_AB_negativo,
            string Quantidade_O_positivo, string Quantidade_O_negativo)
        {
            Quantidade_A_positivo = Quantidade_A_positivo;

            Quantidade_A_negativo = Quantidade_A_negativo;

            Quantidade_B_positivo = Quantidade_B_positivo;

            Quantidade_B_negativo = Quantidade_B_negativo;
            
            Quantidade_AB_positivo = Quantidade_AB_positivo;

            Quantidade_AB_negativo = Quantidade_AB_negativo;

            Quantidade_O_positivo = Quantidade_O_positivo;

            Quantidade_O_negativo = Quantidade_O_negativo;
                                   
        }

        public Estoque_Sangue()
        {
            CriadoEm = DateTime.Now;
        }
        [Key]
        //Atributos, propriedades e caracteristicas
        public int Quantidade_A_positivo { get; set; }

        public int Quantidade_A_negativo { get; set; }

        public int Quantidade_B_positivo { get; set; }

        public int Quantidade_B_negativo { get; set; }

        public int Quantidade_AB_positivo { get; set; }

        public int Quantidade_AB_negativo { get; set; }

        public int Quantidade_O_positivo { get; set; }

        public int Quantidade_O_negativo { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Quantidade_A_positivo: {Quantidade_A_positivo} | Quantidade_A_negativo: {Quantidade_A_negativo} |" +
                $" Quantidade_B_positivo: {Quantidade_B_positivo} | Quantidade_B_negativo: {Quantidade_B_negativo} | " +
                $"Quantidade_AB_positivo: {Quantidade_AB_positivo}| Quantidade_AB_negativo: {Quantidade_AB_negativo}| " +
                $"Quantidade_O_positivo: {Quantidade_O_positivo}| Quantidade_O_negativo: {Quantidade_O_negativo} ";

        }
    }
}
