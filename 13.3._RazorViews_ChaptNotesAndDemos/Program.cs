using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace _13._3._RazorViews_ChaptNotesAndDemos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        private static void Lecture()
        {
            /*
             * 13.1 Templates: 
             * Support Dynamic Content
             * They provide more flexibility than hard coding. 
             * Templates provide structure not content. 
             * 
             * 13.2 Creating a Template: 
             * For LC101, we'll be using Razor templates, which allows us to write C# in HTML template pages
             * Razor reference page: 
             * https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-3.1
             * 
             * 
             * 1.  create a .cshtml view template and populate it.
             * 2. Update controller to return the template with the view() method. 
             * 
             * The view method returns the template based on the IActionResult
             * method name.  
             * Razor templates-
             * use {variables} in curly brackets
             */
        }
    }
}
