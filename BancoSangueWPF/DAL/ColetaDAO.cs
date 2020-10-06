using BancoSangueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoSangueWPF.DAL
{
    class ColetaDAO
    {
        private static Context _context = new Context();

        public static bool Cadastrar(Coleta coleta)
        {
            if (BuscarPorId(coleta.Id) == null)
            {
                _context.Add(coleta);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public static List<Coleta> Listar() => _context.Coleta.ToList();

        public static Coleta BuscarPorId(int id) => _context.Coleta.Find(id);
    }
}
