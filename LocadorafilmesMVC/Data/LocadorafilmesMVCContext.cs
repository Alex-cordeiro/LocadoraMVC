using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LocadorafilmesMVC.Models;

namespace LocadorafilmesMVC.Data
{
    public class LocadorafilmesMVCContext : DbContext
    {
        public LocadorafilmesMVCContext (DbContextOptions<LocadorafilmesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
    }
}
