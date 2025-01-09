using Data.Context;
using Data.Entitie;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class Seed
    {

        private readonly ChallengeContext _context;
        public Seed(ChallengeContext context)
        {
            _context = context;
        }
        protected void OnModelCreating(ModelBuilder modelBuilder)
        {


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
                        Name = "Carlos",
                        LastName = "Gardel",
                        Email = "gardel@tango.com",
                        Cuit = 20112233401,
                        Dni = 20112233,
                        Nacimiento = new DateTime(1890, 12, 11),
                        Phone = 1140000006
                    },
                    new Client
                    {
                        Id = 7,
                        Name = "Mercedes",
                        LastName = "Sosa",
                        Email = "sosa@argentina.com",
                        Cuit = 20555555501,
                        Dni = 30555555,
                        Nacimiento = new DateTime(1935, 7, 9),
                        Phone = 1140000007
                    },
                    new Client
                    {
                        Id = 8,
                        Name = "Juan",
                        LastName = "Perón",
                        Email = "peron@justicialismo.com",
                        Cuit = 20987654301,
                        Dni = 40987654,
                        Nacimiento = new DateTime(1895, 10, 8),
                        Phone = 1140000008
                    },
                    new Client
                    {
                        Id = 9,
                        Name = "Eva",
                        LastName = "Duarte",
                        Email = "evita@peronismo.com",
                        Cuit = 20999999901,
                        Dni = 30999999,
                        Nacimiento = new DateTime(1919, 5, 7),
                        Phone = 1140000009
                    },
                    new Client
                    {
                        Id = 10,
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
