using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Graos_API.Data.Mapping
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor_tb>
    {
        public void Configure(EntityTypeBuilder<Fornecedor_tb> builder)
        {
            builder.ToTable("Fornecedor_tb");

            builder.HasKey(f => f.FornecedorID);

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(f => f.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(f => f.Obs)
                .HasColumnType("varchar(100)");

            builder.Property(f => f.Data_Inclusao)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(f => f.Data_Alteracao)
                .HasColumnType("datetime");

            builder.HasMany(p => p.Propriedade_tb).WithOne(f => f.Fornecedor_tb).HasForeignKey(f => f.FornecedorID).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.Pesagem_tb).WithOne(f => f.Fornecedor_tb).HasForeignKey(f => f.FornecedorID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}





