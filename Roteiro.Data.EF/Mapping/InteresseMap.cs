using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roteiro.Data.EF.Mapping
{
    public class InteresseMap : BaseMapping<Interesse>
    {
        public override void Configure(EntityTypeBuilder<Interesse> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.DAlteracao).HasColumnName("d_Alteracao").HasColumnType("date");
            builder.Property(c => c.DInicio).HasColumnName("d_Inicio").HasColumnType("date");
            builder.Property(c => c.DFim).HasColumnName("d_Fim").HasColumnType("date");
            builder.Property(c => c.ICadAdm).HasColumnName("i_CadAdm");
            builder.Property(c => c.ICadAlt).HasColumnName("i_CadAlt");
            builder.Property(c => c.XDestino).HasColumnName("x_Destino");
            builder.Property(c => c.XInteresse).HasColumnName("x_Interesse");

            builder.HasOne(d => d.ICadAdmNavigation).WithMany(p => p.Interesse).HasForeignKey(d => d.ICadAdm);
            //builder.HasOne(o => o.Ext).WithMany().HasForeignKey(f => f.ExtId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
