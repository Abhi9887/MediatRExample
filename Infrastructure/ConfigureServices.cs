using DomainLayer.Repository;
using Infrastructure.Data;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection InfrastructureServices( this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(optionsAction =>
            {
                optionsAction.UseSqlServer(configuration.GetConnectionString("Conn") ?? throw new InvalidOperationException("Invailed Connectionn string"));
            });

            services.AddTransient<IBlogRepository, BlogRepository>();

            return services;
        }
    }
}
