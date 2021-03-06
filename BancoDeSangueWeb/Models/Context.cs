﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDeSangueWeb.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Doador> Doador { get; set; }
        public DbSet<TipoSanguineo> TipoSanguineo { get; set; }
        public DbSet<EstoqueSangue> EstoqueSangue { get; set; }
        public DbSet<Coleta> Coleta { get; set; }
        public DbSet<Retirada> Retirada { get; set; }
        public DbSet<UsuarioView> Usuario { get; set; }
    }
}
