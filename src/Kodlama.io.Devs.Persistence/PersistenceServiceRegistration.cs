using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kodlama.io.Devs.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kodlama.io.Devs.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistanceService(this IServiceCollection services,
                                                    IConfiguration configuration)
        {
            services.AddDbContext<MsSqlCommandDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MssqlCommandString")));
            services.AddDbContext<MsSqlQueryDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MssqlQueryString")));
            return services;
        }
    }
}