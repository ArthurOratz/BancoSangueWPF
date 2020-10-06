using BancoSangueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoSangueWPF.DAL
{
    class EstoqueSangueDAO
    {
        private static Context _context = new Context();

        //public static EstoqueSangue BuscarPorNome(string nome) => _context.Hospital.FirstOrDefault(x => x.Nome == nome);


        public static void Alterar(EstoqueSangue estoqueSangue)
        {
            _context.Update(estoqueSangue);
            _context.SaveChanges();
        }

        public static List<EstoqueSangue> Listar() => _context.EstoqueSangue.ToList();

        public static EstoqueSangue BuscarPorId(int id) => _context.EstoqueSangue.Find(id);

        public static EstoqueSangue BuscarPorTipoSanguineo(TipoSanguineo tipoSanguineo) => _context.EstoqueSangue.Find(tipoSanguineo);


        public static void AumentaEstoque(TipoSanguineo tipoSanguineo, int quantidade)
        {

        }



    }
}
