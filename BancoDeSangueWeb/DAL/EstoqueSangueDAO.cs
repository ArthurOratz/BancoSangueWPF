using BancoDeSangueWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.DAL
{
    public class EstoqueSangueDAO
    {
        private readonly Context _context;

        public EstoqueSangueDAO(Context context) => _context = context;

        public List<EstoqueSangue> Listar() => _context.EstoqueSangue.Include(x => x.TipoSanguineo).ToList();

        public EstoqueSangue BuscarPorTipoSanguineo(int tipoSanguineoId) => _context.EstoqueSangue.FirstOrDefault(c => c.TipoSanguineoId == tipoSanguineoId);

        public void AumentaEstoque(int tipoSanguineoId, double quantidade)
        {
            var estoque = BuscarPorTipoSanguineo(tipoSanguineoId);
            estoque.Quantidade += quantidade;

            _context.Update(estoque);
            _context.SaveChanges();
        }

        public void DiminuirEstoque(int tipoSanguineoId, double quantidade)
        {
            var estoque = BuscarPorTipoSanguineo(tipoSanguineoId);

            estoque.Quantidade -= quantidade;
            _context.Update(estoque);
            _context.SaveChanges();

        }

        public double VerificaQtEstoque(int tipoSanguineoId) => BuscarPorTipoSanguineo(tipoSanguineoId).Quantidade;










        public void CriarEstoqueSangue()
        {
            var aPos = new TipoSanguineo { FatorRH = "+", Tipo = "A" };
            var aNeg = new TipoSanguineo { FatorRH = "-", Tipo = "A" };
            var bPos = new TipoSanguineo { FatorRH = "+", Tipo = "B" };
            var bNeg = new TipoSanguineo { FatorRH = "-", Tipo = "B" };
            var abPos = new TipoSanguineo { FatorRH = "+", Tipo = "AB" };
            var abNeg = new TipoSanguineo { FatorRH = "-", Tipo = "AB" };
            var oPos = new TipoSanguineo { FatorRH = "+", Tipo = "O" };
            var oNeg = new TipoSanguineo { FatorRH = "-", Tipo = "O" };
            _context.TipoSanguineo.AddRange(aPos, aNeg, bPos, bNeg, abPos, abNeg, oPos, oNeg);
            _context.EstoqueSangue.Add(new EstoqueSangue { TipoSanguineo = aPos, Quantidade = 0 });
            _context.EstoqueSangue.Add(new EstoqueSangue { TipoSanguineo = aNeg, Quantidade = 0 });
            _context.EstoqueSangue.Add(new EstoqueSangue { TipoSanguineo = bPos, Quantidade = 0 });
            _context.EstoqueSangue.Add(new EstoqueSangue { TipoSanguineo = bNeg, Quantidade = 0 });
            _context.EstoqueSangue.Add(new EstoqueSangue { TipoSanguineo = abPos, Quantidade = 0 });
            _context.EstoqueSangue.Add(new EstoqueSangue { TipoSanguineo = abNeg, Quantidade = 0 });
            _context.EstoqueSangue.Add(new EstoqueSangue { TipoSanguineo = oPos, Quantidade = 0 });
            _context.EstoqueSangue.Add(new EstoqueSangue { TipoSanguineo = oNeg, Quantidade = 0 });
            _context.SaveChanges();
        }

    }
}
