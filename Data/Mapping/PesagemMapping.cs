using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Graos_API.Data.Mapping
{
    public class PesagemMapping : IEntityTypeConfiguration<Pesagem_tb>
    {
        public void Configure(EntityTypeBuilder<Pesagem_tb> builder)
        {
            builder.ToTable("Pesagem_tb");

            builder.HasKey(s => s.PesagemID);
            
            builder.Property(s => s.Data_Abertura)
                .IsRequired()
                .HasColumnType("datetime");
            
            builder.Property(s => s.Data_Fechamento)
                .HasColumnType("datetime");
            
            builder.Property(s => s.Placa)
                .HasColumnType("varchar(10)");

            builder.Property(s => s.Valor)
                .HasColumnType("decimal(18, 2)");

            builder.Property(s => s.Peso_Inicial)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(s => s.Peso_Final)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(s => s.Peso_Liquido)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(s => s.NF)
                .HasColumnType("varchar(50)");
            
            builder.Property(s => s.Obs)
                .HasColumnType("varchar(100)");

            builder.Property(s => s.Data_Inclusao)
                .HasColumnType("datetime");

            builder.Property(s => s.Data_Alteracao)
                .HasColumnType("datetime");
        }
    }

}
