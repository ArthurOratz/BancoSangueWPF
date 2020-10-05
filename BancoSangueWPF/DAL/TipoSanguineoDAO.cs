using BancoSangueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoSangueWPF.DAL
{
    class TipoSanguineoDAO
    {
        private static Context _context = new Context();

        public static TipoSanguineo BuscarPorId(int id) => _context.TipoSanguineo.Find(id);

        public static List<TipoSanguineo> Listar() => _context.TipoSanguineo.ToList();

    }
}
