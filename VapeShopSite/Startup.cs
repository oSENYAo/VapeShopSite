using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VapeShopeSite.Application;
using VapeShopeSite.DAL.TestDBSpace;
using VapeShopeSite.Domain.Handlers.TestHandler;
using VapeShopeSite.Domain.Handlers.TestHandlerSpace;
using VapeShopeSite.Domain.Models;
using VapeShopeSite.WebApi.Controllers.TestController.Models;
using VapeShopSite.Common.Infrastructure;

namespace VapeShopeSite.WebApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHandlerProvider, HandlerProvider>();
            services.AddSingleton<IRequestHandler<TestRequest, TestDomainEntity>, TestHandler>();
            services.AddSingleton<IDataBase, TestDB>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
