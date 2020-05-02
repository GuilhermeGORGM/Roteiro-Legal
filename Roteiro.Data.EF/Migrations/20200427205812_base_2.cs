using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Roteiro.Data.EF.Migrations
{
    public partial class base_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Interesse");

            migrationBuilder.DropColumn(
                name: "DataInativacao",
                table: "Interesse");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Dscr");

            migrationBuilder.DropColumn(
                name: "DataInativacao",
                table: "Dscr");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "DataInativacao",
                table: "Cadastro");

            migrationBuilder.RenameColumn(
                name: "DNasc",
                table: "Cadastro",
                newName: "d_Nasc");

            migrationBuilder.AlterColumn<DateTime>(
                name: "d_Nasc",
                table: "Cadastro",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "d_Nasc",
                table: "Cadastro",
                newName: "DNasc");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Interesse",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInativacao",
                table: "Interesse",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Dscr",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInativacao",
                table: "Dscr",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DNasc",
                table: "Cadastro",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Cadastro",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInativacao",
                table: "Cadastro",
                nullable: true);
        }
    }
}
