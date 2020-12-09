using BancoDeSangueWeb.Models;
using Microsoft.EntityFrameworkCore;
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

        //public List<Coleta> Listar() => _context.Coleta.ToList();
        public List<Coleta> Listar() => _context.Coleta.Include(x => x.Doador.TipoSanguineo).Include(x => x.Funcionario).ToList();


        public Coleta BuscarPorId(int id) => _context.Coleta.Find(id);

        public bool Cadastrar(Coleta coleta)
        {
            var ultimaColeta = _context.Coleta.Where(x => x.DoadorId == coleta.DoadorId).OrderBy(c => c.Data).LastOrDefault();
            if (DateTime.Now >= ultimaColeta.Data.AddDays(90))
            {
                coleta.Data = DateTime.Now;
                _context.Coleta.Add(coleta);
                _context.SaveChanges();
                return true;
            }
            return false;
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
