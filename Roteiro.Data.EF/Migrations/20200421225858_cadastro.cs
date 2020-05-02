using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Roteiro.Data.EF.Migrations
{
    public partial class cadastro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    IInteresse = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    XClasse = table.Column<int>(nullable: true),
                    Idade = table.Column<short>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NTelefone = table.Column<string>(nullable: true),
                    DNasc = table.Column<DateTime>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    NRua = table.Column<int>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Pais = table.Column<int>(nullable: true),
                    DAlteracao = table.Column<DateTime>(nullable: true),
                    CpfCnpj = table.Column<string>(nullable: true),
                    ICadAlt = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastro");
        }
    }
}
