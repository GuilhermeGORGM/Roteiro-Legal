using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Roteiro.Data.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoteiroLegal.Config
{
    public static class RepositoryConfig
    {
        public static void Configure(this IServiceCollection services, IConfiguration configuration)

        {
            var connString = configuration.GetConnectionString("RoteiroLegal");
            services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connString));
        }
    }
}
