using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Configuration
{
    public static class ServiceCollectionExtension
    {

        public static void DbContext(this IServiceCollection services)
        {
            IConfiguration _configuration;

            using (var serviceScope = services.BuildServiceProvider().CreateScope())
            {
                _configuration = serviceScope.ServiceProvider.GetService<IConfiguration>()!;
            }

            var applicationOptions = new ApplicationOptions();


            services.AddDbContext<ChallengeContext>(options => options.UseSqlServer(applicationOptions.ConnectionString));
        }

    }
}
