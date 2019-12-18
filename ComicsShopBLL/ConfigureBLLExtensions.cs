using Microsoft.Extensions.DependencyInjection;
using System;
using ComicsShopDAL;
using System.Collections.Generic;
using System.Text;
using ComicsShopBLL.Services.Interfaces;
using ComicsShopBLL.Services.Implementations;
using AutoMapper;
using ComicsShopBLL.Mappers;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace ComicsShopBLL
{
    public static class ConfigureBLLExtension
    {
        public static void ConfigureBLL(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureAutoMapper();
            services.ConfigureServices();

            services.AddScoped<IServiceFactory, ServiceFactory>();

            services.ConfigureDAL(configuration);
        }

        private static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }

        private static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddSingleton(new MapperConfiguration(c =>
            {
                c.AddProfile(new ProductProfile());
                c.AddProfile(new CartProfile());
                c.AddProfile(new CartProductProfile());
            }).CreateMapper());
        }
    }
}
