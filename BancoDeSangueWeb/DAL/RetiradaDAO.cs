using BancoDeSangueWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.DAL
{
    public class RetiradaDAO
    {
        private readonly Context _context;

        public RetiradaDAO(Context context) => _context = context;

        public List<Retirada> Listar() => _context.Retirada.ToList();

        public Retirada BuscarPorId(int id) => _context.Retirada.Find(id);

        public bool Cadastrar(Retirada retirada)
        {
            //validar se tem sangue disponivel
                _context.Retirada.Add(retirada);
                _context.SaveChanges();
                return true;
        }

        public void Remover(int id)
        {
            _context.Retirada.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }

        public void Editar(Retirada retirada)
        {
            _context.Retirada.Update(retirada);
            _context.SaveChanges();
        }

    }
}
