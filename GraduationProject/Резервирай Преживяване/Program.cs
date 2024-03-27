using CloudinaryDotNet;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Data.Account;
using Резервирай_Преживяване.Helpers;
using Резервирай_Преживяване.Services;

namespace Резервирай_Преживяване
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<User>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddControllersWithViews();

            builder.Services.ConfigureExternalCookie(options =>
            {
                options.LogoutPath = "/Account/Login";
            });

            builder.Services.AddScoped<IResortService, ResortService>();
            builder.Services.AddScoped<IRoomService, RoomService>();
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<IImageService, ImageService>();
            builder.Services.AddScoped<ILandmarkService, LandmarkService>();

            var cloudinarySettings = builder.Configuration
                .GetSection("CloudinarySettings").Get<CloudinarySettings>();
            builder.Services.AddSingleton<Cloudinary>((sp) =>
            {
                return new Cloudinary(new Account(cloudinarySettings.CloudName,
                    cloudinarySettings.ApiKey, cloudinarySettings.ApiSecret));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}