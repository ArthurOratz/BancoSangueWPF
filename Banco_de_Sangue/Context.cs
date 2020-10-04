using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_de_Sangue
{
    class Context : DbContext

    {
        public DbSet<Doador> Doador { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;
                    Database = BancoDados;
                    Trusted_Connection = true");
        }
    }
}
