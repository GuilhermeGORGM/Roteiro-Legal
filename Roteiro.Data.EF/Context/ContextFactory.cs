using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roteiro.Data.EF.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder().Build();
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            var connString = "Data Source=35.223.229.207;Initial Catalog=gaadb;User ID=aplicacao;Password=gaaaplicacao";
            builder.UseMySql(connString);
            return new AppDbContext(builder.Options);
        }
    }
}
