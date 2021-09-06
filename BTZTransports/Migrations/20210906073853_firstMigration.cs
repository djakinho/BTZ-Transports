using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BTZTransports.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Combustivel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Preco = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combustivel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motorista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cnh = table.Column<string>(type: "varchar(50)", nullable: false),
                    CategoriaCnh = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "varchar(50)", nullable: false),
                    NomeVeiculo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Fabricante = table.Column<string>(type: "varchar(100)", nullable: false),
                    AnoFabricacao = table.Column<string>(type: "varchar(25)", nullable: false),
                    CapacidadeMaximaTanque = table.Column<double>(type: "float", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    IdCombustivel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculo_Combustivel_IdCombustivel",
                        column: x => x.IdCombustivel,
                        principalTable: "Combustivel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Abastecimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    QuantidadeAbastecida = table.Column<double>(type: "float", nullable: false),
                    IdVeiculo = table.Column<int>(type: "int", nullable: false),
                    IdMotorista = table.Column<int>(type: "int", nullable: false),
                    IdCombustivel = table.Column<int>(type: "int", nullable: false),
                    CombustivelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abastecimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abastecimento_Combustivel_CombustivelId",
                        column: x => x.CombustivelId,
                        principalTable: "Combustivel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Abastecimento_Motorista_IdMotorista",
                        column: x => x.IdMotorista,
                        principalTable: "Motorista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Abastecimento_Veiculo_IdVeiculo",
                        column: x => x.IdVeiculo,
                        principalTable: "Veiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimento_CombustivelId",
                table: "Abastecimento",
                column: "CombustivelId");

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimento_IdMotorista",
                table: "Abastecimento",
                column: "IdMotorista");

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimento_IdVeiculo",
                table: "Abastecimento",
                column: "IdVeiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_IdCombustivel",
                table: "Veiculo",
                column: "IdCombustivel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abastecimento");

            migrationBuilder.DropTable(
                name: "Motorista");

            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Combustivel");
        }
    }
}
