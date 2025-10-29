using System.ComponentModel.DataAnnotations;

namespace Comunidad_Conectada.Models
{
    public class Persona
    {
        
        public int ID { get; set; }

        [Required(ErrorMessage = "Para poder agregar a la persona es necesario ingresar el nombre")]
        [StringLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Para poder agregar a la persona es necesario ingresar los apellidos")]
        [StringLength(3, ErrorMessage = "El apellido debe tener al menos 3 caracteres")]
        public string Apellidos { get; set; } = string.Empty;

        [Required(ErrorMessage = "Para poder agregar a la persona es necesario ingresar el teléfono")]
        [Range(10000000, 99999999, ErrorMessage = "El número debe tener exactamente 8 dígitos.")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "Para poder agregar a la persona es necesario ingresar el email")]
        [EmailAddress(ErrorMessage = "El formato del email no es correcto, por favor verifique")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Para poder agregar a la persona es necesario ingresar el género")]
        [RegularExpression("^[MFO]$", ErrorMessage = "El género debe ser 'M' para masculino, 'F' para femenino, o 'O' en caso de otro")]
        public char Genero { get; set; } = ' ';

        [Required(ErrorMessage = "Para poder agregar a la persona es necesario ingresar la edad")]
        [Range(1, 120, ErrorMessage = "La edad debe estar entre 0 y 120 años")]
        public int Edad { get; set; }

    }
}
