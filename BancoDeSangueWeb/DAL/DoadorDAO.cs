using BancoDeSangueWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.DAL
{
    public class DoadorDAO
    {
        private readonly Context _context;

        public DoadorDAO(Context context) => _context = context;

        public List<Doador> Listar() => _context.Doador.Include(x => x.TipoSanguineo).ToList();
        public Doador BuscarPorId(int id) => _context.Doador.Find(id);
        public Doador BuscarPorCPF(string cpf) => _context.Doador.FirstOrDefault(c => c.Cpf == cpf);
        public List<Doador> ListarPorTipoSanguineo(int idTipoSanguineo) => _context.Doador.Where(x => x.TipoSanguineoId == idTipoSanguineo).ToList();

        public bool Cadastrar(Doador doador)
        {
            if (BuscarPorCPF(doador.Cpf) == null)
            {
                _context.Doador.Add(doador);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void Remover(int id)
        {
            _context.Doador.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }

        public void Editar(Doador doador)
        {
            _context.Doador.Update(doador);
            _context.SaveChanges();
        }
    }
}
