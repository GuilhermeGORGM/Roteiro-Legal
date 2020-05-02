using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roteiro.Data.EF.Mapping
{
    public class DscrMap : BaseMapping<Dscr>
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dscr>(entity =>
            {
                entity.ToTable("DSCR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NCampo)
                    .IsRequired()
                    .HasColumnName("n_Campo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NCod)
                    .IsRequired()
                    .HasColumnName("n_Cod")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NTabela)
                    .IsRequired()
                    .HasColumnName("n_Tabela")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
