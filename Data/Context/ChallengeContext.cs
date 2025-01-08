using Data.Entitie;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Data.Context
{
    public class ChallengeContext : DbContext
    {
        public ChallengeContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Client> Client { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.ApplyConfiguration(new ClientConfig());

        }
    }
}
