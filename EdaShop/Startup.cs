using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EdaShop.Models;

namespace SportsStore {
    public class Startup {
        public Startup(IConfiguration config) => Configuration = config;
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc();
            services.AddTransient<iRepository, DataRepository>();
            services.AddTransient<iOrderRepository, OrderRepository>();
            string conString = Configuration["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<DataContext>(options => options.UseSqlServer(conString));

            services.AddDistributedSqlServerCache(options =>
                {
                    options.ConnectionString = conString;
                    options.SchemaName = "dbо";
                    options.TableName = "SessionData";
                }
            );
            services.AddSession(options => 
                {
                    options.Cookie.Name = "EdaStore.Session";
                    options.IdleTimeout = System.TimeSpan.FromHours(48);
                    options.Cookie.HttpOnly = false;
                }
            );
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
