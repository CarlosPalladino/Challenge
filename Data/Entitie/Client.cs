using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Entitie
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Cuit { get; set; }
        public int Dni { get; set; }
        public DateTime Nacimiento { get; set; }
        public int Phone { get; set; }

    }
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd().IsRequired();

            builder.Property(x => x.Name).HasColumnName("Name").IsRequired();

            builder.Property(x => x.LastName).HasColumnName("LastName").IsRequired();

            builder.Property(x => x.Email).HasColumnName("Email").IsRequired();

            builder.Property(x => x.Cuit).HasColumnName("Cuit").IsRequired();

            builder.Property(x => x.Dni).HasColumnName("Dni").IsRequired();

            builder.Property(x => x.Nacimiento).HasColumnName("Nacimiento").IsRequired();

            builder.Property(x => x.Dni).HasColumnName("Dni").IsRequired();

            builder.Property(x => x.Phone).HasColumnName("Phone").IsRequired();
        }
    }
}