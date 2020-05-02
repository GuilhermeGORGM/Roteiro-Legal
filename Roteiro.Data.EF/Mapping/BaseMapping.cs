using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Roteiro.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roteiro.Data.EF.Mapping
{
    public abstract class BaseMapping<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        public virtual void Configure(EntityTypeBuilder<T> b)
        {
            b.HasKey(p => p.Id);
        }
    }
}
