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

        public static EstoqueSangue BuscarPorTipoSanguineo(int tipoSanguineoID) => _context.EstoqueSangue.FirstOrDefault(c => c.TipoSanguineoID == tipoSanguineoID);


        public static void AumentaEstoque(int tipoSanguineoID, int quantidade)
        {
            var estoque = BuscarPorTipoSanguineo(tipoSanguineoID);
            estoque.Quantidade += quantidade;

            _context.Update(estoque);
            _context.SaveChanges();
        }

        public static void DiminuirEstoque(int tipoSanguineoID, int quantidade)
        {
            var estoque = BuscarPorTipoSanguineo(tipoSanguineoID);

            estoque.Quantidade -= quantidade;
            _context.Update(estoque);
            _context.SaveChanges();

        }



    }
}
