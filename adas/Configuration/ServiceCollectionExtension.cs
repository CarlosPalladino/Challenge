using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.DependencyInjection;
namespace Data.Configuration
{
    public static class ServiceCollectionExtension
    {

        public static void AddChallengeDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var applicationOptions = new ApplicationOptions();
            configuration.GetSection(ApplicationOptions.Section).Bind(applicationOptions);

            services.AddDbContext<ChallengeContext>(options =>
                options.UseSqlServer(applicationOptions.ConnectionString));
        }

    }



}
