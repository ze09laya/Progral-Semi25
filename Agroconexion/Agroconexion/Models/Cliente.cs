using System.ComponentModel.DataAnnotations;

namespace Agroconexion.Models
{
    public class Cliente
    {
  
            [Key]
            public int idCliente { get; set; }

            [Required]
            [StringLength(50)]
            public string Documento { get; set; }

            [Required]
            [StringLength(150)]
            public string Nombre_Completo { get; set; }

            [StringLength(100)]
            public string Correo { get; set; }

            [StringLength(50)]
            public string Telefono { get; set; }

            [StringLength(200)]
            public string Direccion { get; set; }

            public bool? Estado { get; set; }

            public DateTime? Fecha_Registro { get; set; }
        }
    }

