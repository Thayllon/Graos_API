using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Graos_API.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Avulsa_tb> Avulsa_tb { get; set; }
        public DbSet<Fornecedor_tb> Fornecedor_tb { get; set; }
        public DbSet<LogRequisicoes_tb> LogRequisicoes_tb { get; set; }
        public DbSet<Motorista_tb> Motorista_tb { get; set; }
        public DbSet<Pesagem_tb> Pesagem_tb { get; set; }
        public DbSet<Produto_tb> Produto_tb { get; set; }
        public DbSet<Propriedade_tb> Propriedade_tb { get; set; }
        public DbSet<Saldo_tb> Saldo_tb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            modelBuilder.Entity<Motorista_tb>()
                .HasOne(b => b.Pesagem_tb)
                .WithOne(i => i.Motorista_tb)
                .HasForeignKey<Pesagem_tb>(b => b.MotoristaID).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Produto_tb>()
                .HasOne(b => b.Pesagem_tb)
                .WithOne(i => i.Produto_tb)
                .HasForeignKey<Pesagem_tb>(b => b.ProdutoID).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Fornecedor_tb>()
                .HasOne(b => b.Saldo_tb)
                .WithOne(i => i.Fornecedor_tb)
                .HasForeignKey<Saldo_tb>(b => b.FornecedorID).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pesagem_tb>()
                .HasOne(b => b.Avulsa_tb)
                .WithOne(i => i.Pesagem_tb)
                .HasForeignKey<Avulsa_tb>(b => b.PesagemID).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
