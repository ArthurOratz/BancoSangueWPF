using BancoDeSangueWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.DAL
{
    public class RetiradaDAO
    {
        private readonly Context _context;
        private readonly EstoqueSangueDAO _estoqueSangueDAO;

        public RetiradaDAO(Context context, EstoqueSangueDAO estoqueSangueDAO)
        {
            _context = context;
            _estoqueSangueDAO = estoqueSangueDAO;
        }

        //public List<Retirada> Listar() => _context.Retirada.ToList();
        public List<Retirada> Listar() => _context.Retirada.Include(x => x.TipoSanguineo).Include(x => x.Hospital).ToList();

        public Retirada BuscarPorId(int id) => _context.Retirada.Find(id);

        public bool Cadastrar(Retirada retirada)
        {
            if (retirada.Quantidade <= _estoqueSangueDAO.VerificaQtEstoque(retirada.TipoSanguineoId))
            {
                //validar se tem sangue disponivel
                retirada.Data = DateTime.Now;
                _context.Retirada.Add(retirada);
                _context.SaveChanges();
                _estoqueSangueDAO.DiminuirEstoque(retirada.TipoSanguineoId, retirada.Quantidade);
                return true;
            }
            return false;
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
