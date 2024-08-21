using LAB1.Data;
using LAB1.Models;
using LAB1.Models.Interface;
using Microsoft.EntityFrameworkCore;

namespace LAB1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<SchoolContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolContext")));

            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IUploadFileService, UploadFileService>();


            var app = builder.Build();
            using (var scope=app.Services.CreateScope())
            {
                var services=scope.ServiceProvider;
                DbInitalizer.Initialize(services);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
              name: "transformRouteListStudent",
              pattern: "Admin/Student/List",
              defaults: new { controller = "Student", action = "Index" }
            );
            app.MapControllerRoute(
              name: "transformRouteCreateStudent",
              pattern: "Admin/Student/Add",
              defaults: new { controller = "Student", action = "Create" }
             );
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=student}/{action=Index}/{id?}");

            app.Run();
        }
    }
}