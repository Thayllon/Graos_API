using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Graos_API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor_tb",
                columns: table => new
                {
                    FornecedorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(100)", nullable: false),
                    UF = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Obs = table.Column<string>(type: "varchar(100)", nullable: true),
                    Data_Inclusao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Data_Alteracao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor_tb", x => x.FornecedorID);
                });

            migrationBuilder.CreateTable(
                name: "LogRequisicoes_tb",
                columns: table => new
                {
                    User = table.Column<Guid>(nullable: false),
                    RequestTime = table.Column<DateTime>(nullable: false),
                    ResponseMillis = table.Column<long>(nullable: false),
                    StatusCode = table.Column<int>(nullable: false),
                    Method = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: false),
                    QueryString = table.Column<string>(nullable: true),
                    RequestBody = table.Column<string>(nullable: true),
                    ResponseBody = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogRequisicoes_tb", x => x.User);
                });

            migrationBuilder.CreateTable(
                name: "Motorista_tb",
                columns: table => new
                {
                    MotoristaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(50)", nullable: true),
                    Placa = table.Column<string>(type: "varchar(10)", nullable: true),
                    Placa2 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Cpf_Cnpj = table.Column<string>(type: "varchar(14)", nullable: true),
                    Obs = table.Column<string>(type: "varchar(100)", nullable: true),
                    Data_Inclusao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Data_Alteracao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorista_tb", x => x.MotoristaID);
                });

            migrationBuilder.CreateTable(
                name: "Produto_tb",
                columns: table => new
                {
                    ProdutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Safra = table.Column<string>(type: "varchar(10)", nullable: true),
                    Umidade = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Obs = table.Column<string>(type: "varchar(100)", nullable: true),
                    Data_Inclusao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Data_Alteracao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_tb", x => x.ProdutoID);
                });

            migrationBuilder.CreateTable(
                name: "Propriedade_tb",
                columns: table => new
                {
                    PropriedadeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(100)", nullable: false),
                    UF = table.Column<string>(type: "varchar(20)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(100)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Obs = table.Column<string>(type: "varchar(100)", nullable: true),
                    Data_Inclusao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Data_Alteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    FornecedorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propriedade_tb", x => x.PropriedadeID);
                    table.ForeignKey(
                        name: "FK_Propriedade_tb_Fornecedor_tb_FornecedorID",
                        column: x => x.FornecedorID,
                        principalTable: "Fornecedor_tb",
                        principalColumn: "FornecedorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Saldo_tb",
                columns: table => new
                {
                    SaldoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Saldo_Entrada = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Saldo_Saida = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Saldo_Disponivel = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Obs = table.Column<string>(type: "varchar(100)", nullable: true),
                    Data_Inclusao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Data_Alteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    FornecedorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saldo_tb", x => x.SaldoID);
                    table.ForeignKey(
                        name: "FK_Saldo_tb_Fornecedor_tb_FornecedorID",
                        column: x => x.FornecedorID,
                        principalTable: "Fornecedor_tb",
                        principalColumn: "FornecedorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pesagem_tb",
                columns: table => new
                {
                    PesagemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Abertura = table.Column<DateTime>(type: "datetime", nullable: false),
                    Data_Fechamento = table.Column<DateTime>(type: "datetime", nullable: true),
                    Placa = table.Column<string>(type: "varchar(10)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Peso_Inicial = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Peso_Final = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Peso_Liquido = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NF = table.Column<string>(type: "varchar(50)", nullable: true),
                    Tipo_Pesagem = table.Column<int>(nullable: false),
                    Status_Pesagem = table.Column<int>(nullable: false),
                    Obs = table.Column<string>(type: "varchar(100)", nullable: true),
                    Data_Inclusao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Data_Alteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    MotoristaID = table.Column<int>(nullable: false),
                    ProdutoID = table.Column<int>(nullable: false),
                    PropriedadeID = table.Column<int>(nullable: false),
                    FornecedorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesagem_tb", x => x.PesagemID);
                    table.ForeignKey(
                        name: "FK_Pesagem_tb_Fornecedor_tb_FornecedorID",
                        column: x => x.FornecedorID,
                        principalTable: "Fornecedor_tb",
                        principalColumn: "FornecedorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pesagem_tb_Motorista_tb_MotoristaID",
                        column: x => x.MotoristaID,
                        principalTable: "Motorista_tb",
                        principalColumn: "MotoristaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pesagem_tb_Produto_tb_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "Produto_tb",
                        principalColumn: "ProdutoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pesagem_tb_Propriedade_tb_PropriedadeID",
                        column: x => x.PropriedadeID,
                        principalTable: "Propriedade_tb",
                        principalColumn: "PropriedadeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Avulsa_tb",
                columns: table => new
                {
                    AvulsaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Pago = table.Column<bool>(type: "bit", nullable: false),
                    Obs = table.Column<string>(type: "varchar(100)", nullable: true),
                    Data_Inclusao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Data_Alteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    PesagemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avulsa_tb", x => x.AvulsaID);
                    table.ForeignKey(
                        name: "FK_Avulsa_tb_Pesagem_tb_PesagemID",
                        column: x => x.PesagemID,
                        principalTable: "Pesagem_tb",
                        principalColumn: "PesagemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avulsa_tb_PesagemID",
                table: "Avulsa_tb",
                column: "PesagemID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pesagem_tb_FornecedorID",
                table: "Pesagem_tb",
                column: "FornecedorID");

            migrationBuilder.CreateIndex(
                name: "IX_Pesagem_tb_MotoristaID",
                table: "Pesagem_tb",
                column: "MotoristaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pesagem_tb_ProdutoID",
                table: "Pesagem_tb",
                column: "ProdutoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pesagem_tb_PropriedadeID",
                table: "Pesagem_tb",
                column: "PropriedadeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Propriedade_tb_FornecedorID",
                table: "Propriedade_tb",
                column: "FornecedorID");

            migrationBuilder.CreateIndex(
                name: "IX_Saldo_tb_FornecedorID",
                table: "Saldo_tb",
                column: "FornecedorID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avulsa_tb");

            migrationBuilder.DropTable(
                name: "LogRequisicoes_tb");

            migrationBuilder.DropTable(
                name: "Saldo_tb");

            migrationBuilder.DropTable(
                name: "Pesagem_tb");

            migrationBuilder.DropTable(
                name: "Motorista_tb");

            migrationBuilder.DropTable(
                name: "Produto_tb");

            migrationBuilder.DropTable(
                name: "Propriedade_tb");

            migrationBuilder.DropTable(
                name: "Fornecedor_tb");
        }
    }
}
