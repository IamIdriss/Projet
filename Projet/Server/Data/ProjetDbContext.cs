#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projet.Shared;

namespace Projet.Server.Data
{
    public class ProjetDbContext : DbContext
    {
        public ProjetDbContext (DbContextOptions<ProjetDbContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JDGBI4U;Database=ProjetDB");
        }



        public DbSet<Projet.Shared.Agent> Agent { get; set; }

        public DbSet<Projet.Shared.Position> Position { get; set; }
         
        public DbSet<Projet.Shared.Mail> Mail { get; set; }
    }
}
