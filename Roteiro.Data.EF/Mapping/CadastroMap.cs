using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roteiro.Data.EF.Mapping
{
    public class CadastroMap : BaseMapping<Cadastro>
    {
        //public void Configure(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Cadastro>(entity =>
        //    {
        //        entity.ToTable("CADASTRO");

        //        entity.Property(e => e.Id).HasColumnName("id");

        //        entity.Property(e => e.Bairro)
        //            .HasColumnName("bairro")
        //            .HasMaxLength(25)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Cep)
        //            .HasColumnName("cep")
        //            .HasMaxLength(8)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Cidade)
        //            .HasColumnName("cidade")
        //            .HasMaxLength(30)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Complemento)
        //            .HasColumnName("complemento")
        //            .HasMaxLength(10)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CpfCnpj)
        //            .IsRequired()
        //            .HasColumnName("cpf_cnpj")
        //            .HasMaxLength(15)
        //            .IsUnicode(false);

        //        entity.Property(e => e.DAlteracao)
        //            .HasColumnName("d_Alteracao")
        //            .HasColumnType("date");

        //        entity.Property(e => e.DNasc)
        //            .HasColumnName("d_Nasc")
        //            .HasColumnType("date");

        //        entity.Property(e => e.Email)
        //            .HasColumnName("email")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.ICadAlt).HasColumnName("i_CadAlt");

        //        entity.Property(e => e.IInteresse).HasColumnName("i_Interesse");

        //        entity.Property(e => e.Idade).HasColumnName("idade");

        //        entity.Property(e => e.NRua).HasColumnName("n_Rua");

        //        entity.Property(e => e.NTelefone)
        //            .HasColumnName("n_Telefone")
        //            .HasMaxLength(15)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Nome)
        //            .HasColumnName("nome")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Pais).HasColumnName("pais");

        //        entity.Property(e => e.Rua)
        //            .HasColumnName("rua")
        //            .HasMaxLength(40)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Sexo)
        //            .HasColumnName("sexo")
        //            .HasMaxLength(1)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Uf)
        //            .HasColumnName("uf")
        //            .HasMaxLength(2)
        //            .IsUnicode(false);

        //        entity.Property(e => e.XClasse).HasColumnName("x_Classe");

        //        entity.HasOne(d => d.IInteresseNavigation)
        //            .WithMany(p => p.Cadastro)
        //            .HasForeignKey(d => d.IInteresse)
        //            .HasConstraintName("FK__CADASTRO__i_Inte__4222D4EF");
        //    });
        //    //base.Configure(builder);
        //    //builder.Property(c => c.Bairro).HasMaxLength(25).IsRequired();

        //}
        public override void Configure(EntityTypeBuilder<Cadastro> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Bairro).HasColumnName("bairro").HasMaxLength(25);
            builder.Property(c => c.Cep).HasColumnName("cep").HasMaxLength(8);
            builder.Property(c => c.Cidade).HasColumnName("cidade").HasMaxLength(30);
            builder.Property(c => c.Complemento).HasMaxLength(10);
            builder.Property(c => c.CpfCnpj).HasColumnName("cpf_cnpj").HasMaxLength(15);
            builder.Property(c => c.DNasc).HasColumnName("d_Nasc").HasColumnType("date");
            builder.Property(c => c.DAlteracao).HasColumnName("d_Alteracao").HasColumnType("date");
            builder.Property(c => c.Email).HasColumnName("email").HasMaxLength(50);
            builder.Property(c => c.ICadAlt).HasColumnName("i_CadAlt");
            builder.Property(c => c.IInteresse).HasColumnName("i_Interesse");
            builder.Property(c => c.Idade).HasColumnName("idade");
            builder.Property(c => c.NRua).HasColumnName("n_Rua");
            builder.Property(c => c.NTelefone).HasColumnName("n_Telefone").HasMaxLength(15);
            builder.Property(c => c.Nome).HasColumnName("nome").HasMaxLength(50);
            builder.Property(c => c.Pais).HasColumnName("pais");
            builder.Property(c => c.Rua).HasColumnName("rua").HasMaxLength(40);
            builder.Property(c => c.Uf).HasColumnName("uf").HasMaxLength(2);
            builder.Property(c => c.XClasse).HasColumnName("x_Classe");

            builder.HasOne(o => o.IInteresseNavigation).WithMany(p => p.Cadastro).HasForeignKey(f => f.IInteresse);
            //builder.HasOne(o => o.Ext).WithMany().HasForeignKey(f => f.ExtId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
