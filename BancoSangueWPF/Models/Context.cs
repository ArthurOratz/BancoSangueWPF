using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSangueWPF.Models
{
    class Context : DbContext
    {
        public DbSet<Coleta> Coleta { get; set; }
        public DbSet<Doador> Doador { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<Retirada> Retirada { get; set; }
        public DbSet<TipoSanguineo> TipoSanguineo { get; set; }
        public DbSet<EstoqueSangue> EstoqueSangue { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BancoSangue;Trusted_Connection=true");
        }
    }
}
