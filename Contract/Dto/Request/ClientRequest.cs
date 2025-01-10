using System.ComponentModel.DataAnnotations;

namespace Contracts.Dto.Request
{
    public class ClientRequest
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[A-Za-z\s]{1,50}$", ErrorMessage = "El nombre solo puede contener letras y espacios y no puede exceder los 50 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [RegularExpression(@"^[A-Za-z\s]{1,50}$", ErrorMessage = "El apellido solo puede contener letras y espacios y no puede exceder los 50 caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$", ErrorMessage = "El email debe tener el formato correcto y pertenecer al dominio gmail.com.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El CUIT es obligatorio")]
        [Range(20000000000, 20999999999, ErrorMessage = "El CUIT debe ser un número válido de 11 dígitos entre 20-XXXXXXXX-X.")]
        public long Cuit { get; set; }

        [Required(ErrorMessage = "El DNI es obligatorio")]
        [Range(10000000, 99999999, ErrorMessage = "El DNI debe ser un número válido de 8 dígitos.")]
        public long Dni { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date, ErrorMessage = "Formato de fecha de nacimiento inválido")]
        [CustomValidation(typeof(ClientRequest), nameof(ValidateDateOfBirth))]
        public DateTime Nacimiento { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "El teléfono debe contener exactamente 10 dígitos.")]
        public long Phone { get; set; }

        public static ValidationResult ValidateDateOfBirth(DateTime nacimiento, ValidationContext context)
        {
            if (nacimiento > DateTime.Now)
            {
                return new ValidationResult("La fecha de nacimiento no puede ser futura.");
            }
            return ValidationResult.Success;
        }
    }
}
