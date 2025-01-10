using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Entitie
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Client
    {
        [Key] // Unicidad del campo ID
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[A-Za-z\s]{1,50}$", ErrorMessage = "El nombre solo puede contener letras y espacios y no puede exceder los 50 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [RegularExpression(@"^[A-Za-z\s]{1,50}$", ErrorMessage = "El apellido solo puede contener letras y espacios y no puede exceder los 50 caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El CUIT es obligatorio")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "El formato de CUIT debe ser de 11 dígitos.")]
        public long Cuit { get; set; }

        [Required(ErrorMessage = "El DNI es obligatorio")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "El formato de DNI debe ser de 8 dígitos.")]
        public long Dni { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date, ErrorMessage = "Formato de fecha de nacimiento inválido")]
        public DateTime Nacimiento { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Formato de teléfono inválido")]
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