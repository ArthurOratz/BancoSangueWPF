using BancoDeSangueWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.DAL
{
    public class FuncionarioDAO
    {
        private readonly Context _context;

        public FuncionarioDAO(Context context) => _context = context;

        public List<Funcionario> Listar() => _context.Funcionario.ToList();

        public Funcionario BuscarPorId(int id) => _context.Funcionario.Find(id);
        public Funcionario BuscarPorCPF(string cpf) => _context.Funcionario.FirstOrDefault(c => c.Cpf == cpf);

        public bool Cadastrar(Funcionario funcionario)
        {
            if (BuscarPorCPF(funcionario.Cpf) == null)
            {
                _context.Funcionario.Add(funcionario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void Remover(int id)
        {
            _context.Funcionario.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }

        public void Editar(Funcionario funcionario)
        {
            _context.Funcionario.Update(funcionario);
            _context.SaveChanges();
        }

    }
}
