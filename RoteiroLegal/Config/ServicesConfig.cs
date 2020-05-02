using Microsoft.Extensions.DependencyInjection;
using Roteiro.Application;
using Roteiro.Data.EF;
using Roteiro.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoteiroLegal.Config
{
    public static class ServicesConfig
    {
        public static void Configure(this IServiceCollection services)
        {
            services.AddTransient<IGenericService<Cadastro>, CadastroService>();


        }
    }
}
