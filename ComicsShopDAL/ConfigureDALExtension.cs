using Microsoft.Extensions.Configuration;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;
using ComicsShopDAL.Repositories.InterfaceRepositories;
using ComicsShopDAL.Repositories.ImplementedRepositories;
using Microsoft.EntityFrameworkCore;
using ComicsShopDAL.Data;
using ComicsShopDAL.UnitOfWork;

namespace ComicsShopDAL
{
    public static class ConfigureDALExtension
    {
        public static void ConfigureDAL(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.ConfigureRepositories();
            services.ConfigureDbContext(configuration);

            services.AddScoped<IUnitOfWork,UnitOfWork.UnitOfWork>();
        }

        private static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICartProductRepository, CartProductRepository>();
        }

        private static void ConfigureDbContext(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            void ConfigureConnection(DbContextOptionsBuilder options)
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("ComicsShop.DAL"));
            }

            services.AddDbContext<ApplicationDbContext>(ConfigureConnection);
        }

        //private static void ConfigureIdentity(this IServiceCollection services)
        //{
        //    services.AddIdentity<User, Role>(options => options.Stores.MaxLengthForKeys = 128)
        //        .AddEntityFrameworkStores<StudVoiceDBContext>()
        //        .AddRoleManager<RoleManager<Role>>()
        //        .AddUserManager<UserManager<User>>();

        //    services.Configure<IdentityOptions>(options =>
        //    {
        //        options.Password.RequireNonAlphanumeric = false;
        //        options.Password.RequireDigit = false;
        //        options.Password.RequireLowercase = false;
        //        options.Password.RequireUppercase = false;
        //        options.Password.RequiredLength = 6;
        //        options.Password.RequiredUniqueChars = 1;
        //    });
        //}
    }
}
