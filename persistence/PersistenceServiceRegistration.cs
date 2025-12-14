using CleanArchitecture.application.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistence
{
    public static class PersistenceServiceRegistration
    {

        public static IServiceCollection ConfigurePersistanceService (this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<Database>(options => options.UseSqlServer(configuration.GetConnectionString("ConnDb")));
            services.AddScoped<IproductRepository, ProductRepository>();

            return services;
        }
    }
}
