using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_de_Sangue
{
    class Tipo_Sanguineo
    {
        //Construtores
        public Tipo_Sanguineo(int Id, string Fator_RH, string tipo_sanguineo)
        {
            Id = Id;

            Fator_RH = Fator_RH;

            Tipo_sanguineo = Tipo_sanguineo;
                        
        }

        public Tipo_Sanguineo()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos, propriedades e caracteristicas
        public int Id { get; set; }

        public string Fator_RH { get; set; }

        public string Tipo_sanguineo { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} | Fator_RH: {Fator_RH} | Tipo_sanguineo: {Tipo_sanguineo} ";

        }
    }
}
