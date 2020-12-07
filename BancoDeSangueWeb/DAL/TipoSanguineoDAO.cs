using BancoDeSangueWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.DAL
{
    public class TipoSanguineoDAO
    {
        private readonly Context _context;

        public TipoSanguineoDAO(Context context) => _context = context;

        public List<TipoSanguineo> Listar() => _context.TipoSanguineo.ToList();

        public TipoSanguineo BuscarPorId(int id) => _context.TipoSanguineo.Find(id);

       


    }
}
