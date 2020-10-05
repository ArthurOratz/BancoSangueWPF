using BancoSangueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoSangueWPF.DAL
{
    class DoadorDAO
    {
        private static Context _context = new Context();

        public static Doador BuscarPorCPF(string cpf)
        {
           return _context.Doador.FirstOrDefault(x => x.Cpf== cpf);
            //doador.TipoSanguineo = _context.TipoSanguineo.FirstOrDefault(x => x.Id == doador.TipoSanguineo.Id);
        }

        public static bool Salvar(Doador doador)
        {
            if(BuscarPorCPF(doador.Cpf) == null)
            {
                _context.Add(doador);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public static void Remover(Doador doador)
        {
            _context.Remove(doador);
            _context.SaveChanges();
        }

        public static void Alterar(Doador doador)
        {
            _context.Update(doador);
            _context.SaveChanges();
        }

        public static List<Doador> Listar() => _context.Doador.ToList();

        public static Doador BuscarPorId(int id) => _context.Doador.Find(id);
    }
}
