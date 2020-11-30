using BancoDeSangueWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.DAL
{
    public class HospitalDAO
    {
        private readonly Context _context;

        public HospitalDAO(Context context) => _context = context;

        public List<Hospital> Listar() => _context.Hospital.ToList();

        public Hospital BurcarPorId(int id) => _context.Hospital.Find(id);
        public Hospital BurcarPorNome(string nome) => _context.Hospital.FirstOrDefault(c => c.Nome == nome);

        public void Cadastrar(Hospital hospital)
        {
            _context.Hospital.Add(hospital);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            _context.Hospital.Remove(BurcarPorId(id));
            _context.SaveChanges();
        }

        public void Editar(Hospital hospital)
        {
            _context.Hospital.Update(hospital);
            _context.SaveChanges();
        }

    }
}
