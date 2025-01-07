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
            builder.ToTable("Player");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd().IsRequired();
            builder.HasKey(x => x.Name);
            builder.Property(x => x.Name).HasColumnName("Name").ValueGeneratedOnAdd().IsRequired();
            builder.HasKey(x => x.LastName);
            builder.Property(x => x.LastName).HasColumnName("LastName").ValueGeneratedOnAdd().IsRequired();
            builder.HasKey(x => x.Email);
            builder.Property(x => x.Email).HasColumnName("Email").ValueGeneratedOnAdd().IsRequired();
            builder.HasKey(x => x.Cuit);
            builder.Property(x => x.Cuit).HasColumnName("Cuit").ValueGeneratedOnAdd().IsRequired();
            builder.HasKey(x => x.Dni);
            builder.Property(x => x.Dni).HasColumnName("Dni").ValueGeneratedOnAdd().IsRequired();
            builder.HasKey(x => x.Nacimiento);
            builder.Property(x => x.Nacimiento).HasColumnName("Nacimiento").ValueGeneratedOnAdd().IsRequired();
            builder.HasKey(x => x.Dni);
            builder.Property(x => x.Dni).HasColumnName("Dni").ValueGeneratedOnAdd().IsRequired();
            builder.HasKey(x => x.Phone);
            builder.Property(x => x.Phone).HasColumnName("Phone").ValueGeneratedOnAdd().IsRequired();
        }
    }
}