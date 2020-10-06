using BancoSangueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoSangueWPF.DAL
{
    class RetiradaDAO
    {
        private static Context _context = new Context();

        public static bool Cadastrar(Retirada retirada)
        {
            if (BuscarPorId(retirada.Id) == null)
            {
                _context.Add(retirada);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public static List<Retirada> Listar() => _context.Retirada.ToList();

        public static Retirada BuscarPorId(int id) => _context.Retirada.Find(id);
    }
}
