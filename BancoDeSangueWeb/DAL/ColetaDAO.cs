using BancoDeSangueWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.DAL
{
    public class ColetaDAO
    {
        private readonly Context _context;

        public ColetaDAO(Context context) => _context = context;

        public List<Coleta> Listar() => _context.Coleta.ToList();

        public Coleta BuscarPorId(int id) => _context.Coleta.Find(id);

        public bool Cadastrar(Coleta coleta)
        {
            //validar data da ulima doação do doador
            _context.Coleta.Add(coleta);
            _context.SaveChanges();
            return true;
        }

        public void Remover(int id)
        {
            _context.Coleta.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }

        public void Editar(Coleta coleta)
        {
            _context.Coleta.Update(coleta);
            _context.SaveChanges();
        }
    }
}
