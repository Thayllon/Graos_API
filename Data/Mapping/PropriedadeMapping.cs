using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Graos_API.Data.Mapping
{
    public class PropriedadeMapping : IEntityTypeConfiguration<Propriedade_tb>
    {
        public void Configure(EntityTypeBuilder<Propriedade_tb> builder)
        {
            builder.ToTable("Propriedade_tb");

            builder.HasKey(p => p.PropriedadeID);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.UF)
                .HasColumnType("varchar(20)");

            builder.Property(p => p.Cidade)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Bairro)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Numero)
                .HasColumnType("int");

            builder.Property(p => p.Obs)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Data_Inclusao)
                .HasColumnType("datetime");

            builder.Property(p => p.Data_Alteracao)
                .HasColumnType("datetime");
        }
    }
}



