using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Graos_API.Data.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto_tb>
    {
        public void Configure(EntityTypeBuilder<Produto_tb> builder)
        {
            builder.ToTable("Produto_tb");

            builder.HasKey(p => p.ProdutoID);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Safra)
                .HasColumnType("varchar(10)");

            builder.Property(p => p.Umidade)
                .HasColumnType("decimal(18, 2)");

            builder.Property(p => p.Obs)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Data_Inclusao)
                .HasColumnType("datetime");

            builder.Property(p => p.Data_Alteracao)
                .HasColumnType("datetime");
        }
    }
}


