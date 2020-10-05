using BancoSangueWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoSangueWPF.DAL
{
    class HospitalDAO
    {
        private static Context _context = new Context();

        public static Hospital BuscarPorNome(string nome) => _context.Hospital.FirstOrDefault(x => x.Nome== nome);

        public static bool Cadastrar(Hospital hospital)
        {
            if (BuscarPorNome(hospital.Nome) == null)
            {
                _context.Add(hospital);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public static void Remover(Hospital hospital)
        {
            _context.Remove(hospital);
            _context.SaveChanges();
        }

        public static void Alterar(Hospital hospital)
        {
            _context.Update(hospital);
            _context.SaveChanges();
        }

        public static List<Hospital> Listar() => _context.Hospital.ToList();

        public static Hospital BuscarPorId(int id) => _context.Hospital.Find(id);
    }
}
