using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Graos_API.Data.Mapping
{
    public class SaldoMapping : IEntityTypeConfiguration<Saldo_tb>
    {
        public void Configure(EntityTypeBuilder<Saldo_tb> builder)
        {
            builder.ToTable("Saldo_tb");

            builder.HasKey(s => s.SaldoID);

            builder.Property(s => s.Saldo_Entrada)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(s => s.Saldo_Saida)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(s => s.Saldo_Disponivel)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(s => s.Obs)
                .HasColumnType("varchar(100)");

            builder.Property(s => s.Data_Inclusao)
                .HasColumnType("datetime");

            builder.Property(s => s.Data_Alteracao)
                .HasColumnType("datetime");

            builder.HasOne(s => s.Fornecedor_tb).WithOne(f => f.Saldo_tb);

        }
    }
}
