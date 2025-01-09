using Data.Entitie;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class ChallengeContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public ChallengeContext(DbContextOptions<ChallengeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().HasData(
    new Client
    {
        Id = 1,
        Name = "Diego",
        LastName = "Maradona",
        Email = "maradona10@argentina.com",
        Cuit = 20304050601,
        Dni = 20304050,
        Nacimiento = new DateTime(1960, 10, 30),
        Phone = 1140000001
    },
    new Client
    {
        Id = 2,
        Name = "Lionel",
        LastName = "Messi",
        Email = "messi10@argentina.com",
        Cuit = 20708090101,
        Dni = 40708090,
        Nacimiento = new DateTime(1987, 6, 24),
        Phone = 1140000002
    },
    new Client
    {
        Id = 3,
        Name = "Gabriela",
        LastName = "Sabatini",
        Email = "sabatini@argentina.com",
        Cuit = 20333333401,
        Dni = 30333333,
        Nacimiento = new DateTime(1970, 5, 16),
        Phone = 1140000003
    },
    new Client
    {
        Id = 4,
        Name = "Jorge",
        LastName = "Bergoglio",
        Email = "papa_francisco@vaticano.com",
        Cuit = 20123456701,
        Dni = 10123456,
        Nacimiento = new DateTime(1936, 12, 17),
        Phone = 1140000004
    },
    new Client
    {
        Id = 5,
        Name = "Manuel",
        LastName = "Ginóbili",
        Email = "ginobili20@argentina.com",
        Cuit = 20567890101,
        Dni = 50678901,
        Nacimiento = new DateTime(1977, 7, 28),
        Phone = 1140000005
    },
    new Client
    {
        Id = 6,
        Name = "Mario",
        LastName = "Pergolini",
        Email = "pergolini@cqc.com",
        Cuit = 20122334455,
        Dni = 20122334,
        Nacimiento = new DateTime(1964, 7, 3),
        Phone = 1140000006
    },
    new Client
    {
        Id = 7,
        Name = "Guillermo",
        LastName = "Francella",
        Email = "francella@actor.com",
        Cuit = 20111223344,
        Dni = 20111223,
        Nacimiento = new DateTime(1955, 2, 14),
        Phone = 1140000007
    },
    new Client
    {
        Id = 8,
        Name = "Ricardo",
        LastName = "Darín",
        Email = "darin@actor.com",
        Cuit = 20444444401,
        Dni = 40444444,
        Nacimiento = new DateTime(1957, 1, 16),
        Phone = 1140000010
    }
);

        }
    }
}
