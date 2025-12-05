using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agroconexion.Models
{
    [Table("Proveedor")]
    public class Proveedor
    {
        [Key]
        [Column("idProveedor")]
        public int idProveedor { get; set; }

        [Required]
        [Column("Documento")]
        public string Documento { get; set; }

        [Required]
        [Column("Razon_Social")]
        public string Razon_Social { get; set; }

        [Column("Correo")]
        public string? Correo { get; set; }

        [Column("Telefono")]
        public string? Telefono { get; set; }

        [Column("Estado")]
        public bool? Estado { get; set; } = true;   // ← la tabla permite NULL

        [Column("Fecha_Registro", TypeName = "datetime")]
        public DateTime? Fecha_Registro { get; set; } = DateTime.Now;  // ← la tabla permite NULL
    }
}
