﻿// <auto-generated />
using System;
using Graos_API.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Graos_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221228005840_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Graos_API.Domain.Models.Avulsa_tb", b =>
                {
                    b.Property<int>("AvulsaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Data_Alteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Data_Inclusao")
                        .HasColumnType("datetime");

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.Property<int>("PesagemID")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("AvulsaID");

                    b.HasIndex("PesagemID")
                        .IsUnique();

                    b.ToTable("Avulsa_tb");
                });

            modelBuilder.Entity("Graos_API.Domain.Models.Fornecedor_tb", b =>
                {
                    b.Property<int>("FornecedorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Data_Alteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Data_Inclusao")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FornecedorID");

                    b.ToTable("Fornecedor_tb");
                });

            modelBuilder.Entity("Graos_API.Domain.Models.LogRequisicoes_tb", b =>
                {
                    b.Property<Guid>("User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QueryString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResponseBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ResponseMillis")
                        .HasColumnType("bigint");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.HasKey("User");

                    b.ToTable("LogRequisicoes_tb");
                });

            modelBuilder.Entity("Graos_API.Domain.Models.Motorista_tb", b =>
                {
                    b.Property<int>("MotoristaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf_Cnpj")
                        .HasColumnType("varchar(14)");

                    b.Property<DateTime?>("Data_Alteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Data_Inclusao")
                        .HasColumnType("datetime");

                    b.Property<string>("Modelo")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Placa")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Placa2")
                        .HasColumnType("varchar(10)");

                    b.HasKey("MotoristaID");

                    b.ToTable("Motorista_tb");
                });

            modelBuilder.Entity("Graos_API.Domain.Models.Pesagem_tb", b =>
                {
                    b.Property<int>("PesagemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_Abertura")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Data_Alteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Data_Fechamento")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Data_Inclusao")
                        .HasColumnType("datetime");

                    b.Property<int>("FornecedorID")
                        .HasColumnType("int");

                    b.Property<int>("MotoristaID")
                        .HasColumnType("int");

                    b.Property<string>("NF")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Peso_Final")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Peso_Inicial")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Peso_Liquido")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Placa")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("ProdutoID")
                        .HasColumnType("int");

                    b.Property<int>("PropriedadeID")
                        .HasColumnType("int");

                    b.Property<int>("Status_Pesagem")
                        .HasColumnType("int");

                    b.Property<int>("Tipo_Pesagem")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("PesagemID");

                    b.HasIndex("FornecedorID");

                    b.HasIndex("MotoristaID")
                        .IsUnique();

                    b.HasIndex("ProdutoID")
                        .IsUnique();

                    b.HasIndex("PropriedadeID")
                        .IsUnique();

                    b.ToTable("Pesagem_tb");
                });

            modelBuilder.Entity("Graos_API.Domain.Models.Produto_tb", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Data_Alteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Data_Inclusao")
                        .HasColumnType("datetime");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Safra")
                        .HasColumnType("varchar(10)");

                    b.Property<decimal?>("Umidade")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("ProdutoID");

                    b.ToTable("Produto_tb");
                });

            modelBuilder.Entity("Graos_API.Domain.Models.Propriedade_tb", b =>
                {
                    b.Property<int>("PropriedadeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("Data_Alteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Data_Inclusao")
                        .HasColumnType("datetime");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("FornecedorID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UF")
                        .HasColumnType("varchar(20)");

                    b.HasKey("PropriedadeID");

                    b.HasIndex("FornecedorID");

                    b.ToTable("Propriedade_tb");
                });

            modelBuilder.Entity("Graos_API.Domain.Models.Saldo_tb", b =>
                {
                    b.Property<int>("SaldoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Data_Alteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Data_Inclusao")
                        .HasColumnType("datetime");

                    b.Property<int>("FornecedorID")
                        .HasColumnType("int");

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Saldo_Disponivel")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Saldo_Entrada")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Saldo_Saida")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("SaldoID");

                    b.HasIndex("FornecedorID")
                        .IsUnique();

                    b.ToTable("Saldo_tb");
                });

            modelBuilder.Entity("Graos_API.Domain.Models.Avulsa_tb", b =>
                {
                    b.HasOne("Graos_API.Domain.Models.Pesagem_tb", "Pesagem_tb")
                        .WithOne("Avulsa_tb")
                        .HasForeignKey("Graos_API.Domain.Models.Avulsa_tb", "PesagemID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Graos_API.Domain.Models.Pesagem_tb", b =>
                {
                    b.HasOne("Graos_API.Domain.Models.Fornecedor_tb", "Fornecedor_tb")
                        .WithMany("Pesagem_tb")
                        .HasForeignKey("FornecedorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Graos_API.Domain.Models.Motorista_tb", "Motorista_tb")
                        .WithOne("Pesagem_tb")
                        .HasForeignKey("Graos_API.Domain.Models.Pesagem_tb", "MotoristaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Graos_API.Domain.Models.Produto_tb", "Produto_tb")
                        .WithOne("Pesagem_tb")
                        .HasForeignKey("Graos_API.Domain.Models.Pesagem_tb", "ProdutoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Graos_API.Domain.Models.Propriedade_tb", "Propriedade_tb")
                        .WithOne("Pesagem_tb")
                        .HasForeignKey("Graos_API.Domain.Models.Pesagem_tb", "PropriedadeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Graos_API.Domain.Models.Propriedade_tb", b =>
                {
                    b.HasOne("Graos_API.Domain.Models.Fornecedor_tb", "Fornecedor_tb")
                        .WithMany("Propriedade_tb")
                        .HasForeignKey("FornecedorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Graos_API.Domain.Models.Saldo_tb", b =>
                {
                    b.HasOne("Graos_API.Domain.Models.Fornecedor_tb", "Fornecedor_tb")
                        .WithOne("Saldo_tb")
                        .HasForeignKey("Graos_API.Domain.Models.Saldo_tb", "FornecedorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
