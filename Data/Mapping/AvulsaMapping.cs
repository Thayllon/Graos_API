using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Graos_API.Data.Mapping
{
    public class AvulsaMapping : IEntityTypeConfiguration<Avulsa_tb>
    {
        public void Configure(EntityTypeBuilder<Avulsa_tb> builder)
        {
            builder.ToTable("Avulsa_tb");

            builder.HasKey(a => a.AvulsaID);

            builder.Property(a => a.Valor)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(a => a.Pago)
                .IsRequired()
                .HasColumnType("bit");

            builder.Property(a => a.Obs)
                .HasColumnType("varchar(100)");

            builder.Property(a => a.Data_Inclusao)
                .HasColumnType("datetime");

            builder.Property(a => a.Data_Alteracao)
                .HasColumnType("datetime");
        }
    }
}
