using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
//using Swashbuckle.AspNetCore.Swagger;
using Microsoft.Extensions.Options;
using Roteiro.Data.EF.Context;
using RoteiroLegal.Config;

namespace RoteiroLegal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private IServiceCollection _services;

        public void ConfigureServices(IServiceCollection services)
        {
            //ConfigureAuthentication(services);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(
                    op =>
                    {
                        op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                        op.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                    }
                );
            services.AddCors();
            _services = services;
            RepositoryConfig.Configure(_services, Configuration);
            ServicesConfig.Configure(_services);

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new Info { Title = Configuration["ApiConfigs:Title"], Version = "v1" });
            //});
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            //ConfigureSwagger(app);


            app.UseCors(c =>
            {
                c.AllowAnyOrigin();
                c.AllowAnyMethod();
                c.AllowAnyHeader();
            });

            //app.UseHttpsRedirection();
            app.UseMvc();
            using (var ss = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                //if (!ss.ServiceProvider.GetService<AppDbContext>().AllMigrationsApplied())
                //{
                //    ss.ServiceProvider.GetService<AppDbContext>().Database.Migrate();
                //}
                ss.ServiceProvider.GetService<AppDbContext>().InitialSeed();
            }

        }

        //private static void ConfigureSwagger(IApplicationBuilder app)
        //{
        //    app.UseSwagger();

        //    app.UseSwaggerUI(c =>
        //    {
        //        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        //    });
        //}
        //private void ConfigureAuthentication(IServiceCollection services)
        //{
        //    services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        //                    .AddJwtBearer(options =>
        //                    {
        //                        options.TokenValidationParameters = new TokenValidationParameters
        //                        {
        //                            ValidateIssuer = true,
        //                            ValidateAudience = true,
        //                            ValidateLifetime = true,
        //                            ValidateIssuerSigningKey = true,
        //                            ValidIssuer = Configuration["Jwt:Issuer"],
        //                            ValidAudience = Configuration["Jwt:Issuer"],
        //                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
        //                        };
        //                    });
        //}
    }
}
