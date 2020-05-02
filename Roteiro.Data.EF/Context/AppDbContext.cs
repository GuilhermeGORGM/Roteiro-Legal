using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Roteiro.Data.EF.Context
{
    public class AppDbContext : DbContext
    {
        #region DBSets
        public virtual DbSet<Interesse> Interesse { get; set; }
        public virtual DbSet<Cadastro> Cadastro { get; set; }
        public virtual DbSet<Dscr> Dscr { get; set; }
        //public virtual DbSet<LogCadastro> LogCadastro { get; set; }
        //public virtual DbSet<LogInteresse> LogInteresse { get; set; }

        #endregion

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var types = Assembly.GetAssembly(typeof(AppDbContext)).GetTypes()
                .Where(
                    w => w.AssemblyQualifiedName.Contains("Roteiro.Data.EF.Mapping")
                    && !w.IsNestedPrivate
                    && !w.IsAbstract
                    && w.IsPublic);
            foreach (var t in types)
            {
                dynamic o = Activator.CreateInstance(t);
                modelBuilder.ApplyConfiguration(o);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
