using Microsoft.EntityFrameworkCore;
using Agendify.Models;

namespace Agendify.Data
{
    public class AgendifyDbContext : DbContext
    {
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Area> Areas { get; set; }

        public AgendifyDbContext(DbContextOptions<AgendifyDbContext> options)
            : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Area>().HasData(
                new Area { Id = 1, Name = "Construcao" },
                new Area { Id = 2, Name = "Informatica" },
                new Area { Id = 3, Name = "Medico" },
                new Area { Id = 4, Name = "Beleza" },
                new Area { Id = 5, Name = "Educacao" },
                new Area { Id = 6, Name = "Transporte" }
            );

            modelBuilder.Entity<Servico>()
                .HasOne(s => s.AreaDeAtuacao)
                .WithMany(a => a.Servicos)
                .HasForeignKey(s => s.AreaDeAtuacaoId);
        }
    }
}