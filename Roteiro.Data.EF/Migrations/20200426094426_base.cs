using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Roteiro.Data.EF.Migrations
{
    public partial class @base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Uf",
                table: "Cadastro",
                newName: "uf");

            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "Cadastro",
                newName: "rua");

            migrationBuilder.RenameColumn(
                name: "Pais",
                table: "Cadastro",
                newName: "pais");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cadastro",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Cadastro",
                newName: "idade");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Cadastro",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Cadastro",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "Cadastro",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "Cadastro",
                newName: "bairro");

            migrationBuilder.RenameColumn(
                name: "XClasse",
                table: "Cadastro",
                newName: "x_Classe");

            migrationBuilder.RenameColumn(
                name: "NTelefone",
                table: "Cadastro",
                newName: "n_Telefone");

            migrationBuilder.RenameColumn(
                name: "NRua",
                table: "Cadastro",
                newName: "n_Rua");

            migrationBuilder.RenameColumn(
                name: "IInteresse",
                table: "Cadastro",
                newName: "i_Interesse");

            migrationBuilder.RenameColumn(
                name: "ICadAlt",
                table: "Cadastro",
                newName: "i_CadAlt");

            migrationBuilder.RenameColumn(
                name: "DAlteracao",
                table: "Cadastro",
                newName: "d_Alteracao");

            migrationBuilder.RenameColumn(
                name: "CpfCnpj",
                table: "Cadastro",
                newName: "cpf_cnpj");

            migrationBuilder.AlterColumn<string>(
                name: "uf",
                table: "Cadastro",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "rua",
                table: "Cadastro",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Cadastro",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Cadastro",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Cadastro",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "Cadastro",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cep",
                table: "Cadastro",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "Cadastro",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "n_Telefone",
                table: "Cadastro",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "d_Alteracao",
                table: "Cadastro",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cpf_cnpj",
                table: "Cadastro",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Dscr",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    NTabela = table.Column<string>(nullable: true),
                    NCampo = table.Column<string>(nullable: true),
                    NCod = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dscr", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interesse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: true),
                    i_CadAdm = table.Column<int>(nullable: true),
                    d_Inicio = table.Column<DateTime>(type: "date", nullable: true),
                    d_Fim = table.Column<DateTime>(type: "date", nullable: true),
                    x_Destino = table.Column<int>(nullable: true),
                    x_Interesse = table.Column<int>(nullable: true),
                    d_Alteracao = table.Column<DateTime>(type: "date", nullable: true),
                    i_CadAlt = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interesse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interesse_Cadastro_i_CadAdm",
                        column: x => x.i_CadAdm,
                        principalTable: "Cadastro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cadastro_i_Interesse",
                table: "Cadastro",
                column: "i_Interesse");

            migrationBuilder.CreateIndex(
                name: "IX_Interesse_i_CadAdm",
                table: "Interesse",
                column: "i_CadAdm");

            migrationBuilder.AddForeignKey(
                name: "FK_Cadastro_Interesse_i_Interesse",
                table: "Cadastro",
                column: "i_Interesse",
                principalTable: "Interesse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cadastro_Interesse_i_Interesse",
                table: "Cadastro");

            migrationBuilder.DropTable(
                name: "Dscr");

            migrationBuilder.DropTable(
                name: "Interesse");

            migrationBuilder.DropIndex(
                name: "IX_Cadastro_i_Interesse",
                table: "Cadastro");

            migrationBuilder.RenameColumn(
                name: "uf",
                table: "Cadastro",
                newName: "Uf");

            migrationBuilder.RenameColumn(
                name: "rua",
                table: "Cadastro",
                newName: "Rua");

            migrationBuilder.RenameColumn(
                name: "pais",
                table: "Cadastro",
                newName: "Pais");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cadastro",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "idade",
                table: "Cadastro",
                newName: "Idade");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Cadastro",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Cadastro",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Cadastro",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "bairro",
                table: "Cadastro",
                newName: "Bairro");

            migrationBuilder.RenameColumn(
                name: "x_Classe",
                table: "Cadastro",
                newName: "XClasse");

            migrationBuilder.RenameColumn(
                name: "n_Telefone",
                table: "Cadastro",
                newName: "NTelefone");

            migrationBuilder.RenameColumn(
                name: "n_Rua",
                table: "Cadastro",
                newName: "NRua");

            migrationBuilder.RenameColumn(
                name: "i_Interesse",
                table: "Cadastro",
                newName: "IInteresse");

            migrationBuilder.RenameColumn(
                name: "i_CadAlt",
                table: "Cadastro",
                newName: "ICadAlt");

            migrationBuilder.RenameColumn(
                name: "d_Alteracao",
                table: "Cadastro",
                newName: "DAlteracao");

            migrationBuilder.RenameColumn(
                name: "cpf_cnpj",
                table: "Cadastro",
                newName: "CpfCnpj");

            migrationBuilder.AlterColumn<string>(
                name: "Uf",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NTelefone",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DAlteracao",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CpfCnpj",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);
        }
    }
}
