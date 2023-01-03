using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Graos_API.Data.Mapping
{
    public class MotoristaMapping : IEntityTypeConfiguration<Motorista_tb>
    {
        public void Configure(EntityTypeBuilder<Motorista_tb> builder)
        {
            builder.ToTable("Motorista_tb");

            builder.HasKey(m => m.MotoristaID);

            builder.Property(m => m.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(m => m.Modelo)
                .HasColumnType("varchar(50)");

            builder.Property(m => m.Placa)
                .HasColumnType("varchar(10)");

            builder.Property(m => m.Placa2)
                .HasColumnType("varchar(10)");

            builder.Property(m => m.Cpf_Cnpj)
                .HasColumnType("varchar(14)");

            builder.Property(m => m.Obs)
                .HasColumnType("varchar(100)");

            builder.Property(m => m.Data_Inclusao)
                .HasColumnType("datetime");

            builder.Property(m => m.Data_Alteracao)
                .HasColumnType("datetime");
        }
    }
}

