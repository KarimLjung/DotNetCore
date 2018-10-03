using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                var list = new List<int>();
            }

            app.Run(async (context) =>
            {
                var message = "090384-1125";
                var message2 = "Hello world. I am finally free in this world. I will now conquer the world";
                var match = Regex.Match(message, @"(\d{6})-(\d{4})");
                var match2 = Regex.Matches(message2, "world").Count;
                var match3 = Regex.Matches(message2, @"(wor)\b\w+");
                
                //await context.Response.WriteAsync($"group 1: {match.Groups[1]}");
                //await context.Response.WriteAsync($"Number of worlds: {match2}");
                foreach (var matchx in match3)
                {
                    await context.Response.WriteAsync(matchx.ToString());
                }
                
                
            });

        }
    }
}
