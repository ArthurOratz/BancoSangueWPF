using BancoSangueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoSangueWPF.DAL
{
    class FuncionarioDAO
    {
        private static Context _context = new Context();

        public static Funcionario BuscarPorCPF(string cpf) => _context.Funcionario.FirstOrDefault(x => x.Cpf == cpf);

        public static bool Cadastrar(Funcionario funcionario)
        {
            if (BuscarPorCPF(funcionario.Cpf) == null)
            {
                _context.Add(funcionario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public static void Remover(Funcionario funcionario)
        {
            _context.Remove(funcionario);
            _context.SaveChanges();
        }

        public static void Alterar(Funcionario funcionario)
        {
            _context.Update(funcionario);
            _context.SaveChanges();
        }

        public static List<Funcionario> Listar() => _context.Funcionario.ToList();

        public static Funcionario BuscarPorId(int id) => _context.Funcionario.Find(id);
    }
}
