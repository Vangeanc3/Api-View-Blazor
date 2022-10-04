using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API_BLAZOR_
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        :   base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Gerencia>()
            .HasOne(gerencia => gerencia.Gerente)
            .WithOne(gerente => gerente.Gerencia)
            .HasForeignKey<Gerente>(gerente => gerente.GerenciaId);

        }

    public DbSet<Gerente> Gerentes { get; set; } = default!;
    public DbSet<Gerencia> Gerencias { get; set; } = default!;
    }
}