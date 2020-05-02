﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Roteiro.Data.EF.Context;

namespace Roteiro.Data.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200427205812_base_2")]
    partial class base_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Roteiro.Data.EF.Cadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .HasColumnName("bairro")
                        .HasMaxLength(25);

                    b.Property<string>("Cep")
                        .HasColumnName("cep")
                        .HasMaxLength(8);

                    b.Property<string>("Cidade")
                        .HasColumnName("cidade")
                        .HasMaxLength(30);

                    b.Property<string>("Complemento")
                        .HasMaxLength(10);

                    b.Property<string>("CpfCnpj")
                        .HasColumnName("cpf_cnpj")
                        .HasMaxLength(15);

                    b.Property<DateTime?>("DAlteracao")
                        .HasColumnName("d_Alteracao")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DNasc")
                        .HasColumnName("d_Nasc")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(50);

                    b.Property<int?>("ICadAlt")
                        .HasColumnName("i_CadAlt");

                    b.Property<int?>("IInteresse")
                        .HasColumnName("i_Interesse");

                    b.Property<short?>("Idade")
                        .HasColumnName("idade");

                    b.Property<int?>("NRua")
                        .HasColumnName("n_Rua");

                    b.Property<string>("NTelefone")
                        .HasColumnName("n_Telefone")
                        .HasMaxLength(15);

                    b.Property<string>("Nome")
                        .HasColumnName("nome")
                        .HasMaxLength(50);

                    b.Property<int?>("Pais")
                        .HasColumnName("pais");

                    b.Property<string>("Rua")
                        .HasColumnName("rua")
                        .HasMaxLength(40);

                    b.Property<string>("Sexo");

                    b.Property<string>("Uf")
                        .HasColumnName("uf")
                        .HasMaxLength(2);

                    b.Property<int?>("XClasse")
                        .HasColumnName("x_Classe");

                    b.HasKey("Id");

                    b.HasIndex("IInteresse");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("Roteiro.Data.EF.Dscr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("NCampo");

                    b.Property<string>("NCod");

                    b.Property<string>("NTabela");

                    b.HasKey("Id");

                    b.ToTable("Dscr");
                });

            modelBuilder.Entity("Roteiro.Data.EF.Interesse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DAlteracao")
                        .HasColumnName("d_Alteracao")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DFim")
                        .HasColumnName("d_Fim")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DInicio")
                        .HasColumnName("d_Inicio")
                        .HasColumnType("date");

                    b.Property<int?>("ICadAdm")
                        .HasColumnName("i_CadAdm");

                    b.Property<int?>("ICadAlt")
                        .HasColumnName("i_CadAlt");

                    b.Property<int?>("XDestino")
                        .HasColumnName("x_Destino");

                    b.Property<int?>("XInteresse")
                        .HasColumnName("x_Interesse");

                    b.HasKey("Id");

                    b.HasIndex("ICadAdm");

                    b.ToTable("Interesse");
                });

            modelBuilder.Entity("Roteiro.Data.EF.Cadastro", b =>
                {
                    b.HasOne("Roteiro.Data.EF.Interesse", "IInteresseNavigation")
                        .WithMany("Cadastro")
                        .HasForeignKey("IInteresse");
                });

            modelBuilder.Entity("Roteiro.Data.EF.Interesse", b =>
                {
                    b.HasOne("Roteiro.Data.EF.Cadastro", "ICadAdmNavigation")
                        .WithMany("Interesse")
                        .HasForeignKey("ICadAdm");
                });
#pragma warning restore 612, 618
        }
    }
}
