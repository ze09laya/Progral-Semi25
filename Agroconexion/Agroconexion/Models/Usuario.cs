using Agroconexion.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Usuario")] // Mapea a la tabla exacta
public class Usuario
{
    [Key]
    [Column("idUsuario")]
    public int idUsuario { get; set; }

    [Required]
    [MaxLength(50)]
    [Column("Documento")]
    public string Documento { get; set; }

    [Required]
    [MaxLength(150)]
    [Column("Nombre_Completo")]
    public string Nombre_Completo { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("Correo")]
    public string Correo { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("Clave")]
    public string Clave { get; set; }

    [Required]
    [Column("idRol")]
    public int idRol { get; set; }

    // Relación con Rol
    [ForeignKey("idRol")]
    public Rol? Rol { get; set; }  // Correcto: es navegación, puede ser nullable

    [Column("Estado")]
    public bool? Estado { get; set; } = true;  // TU TABLA PERMITE NULL

    [Column("Fecha_Registro")]
    public DateTime? Fecha_Registro { get; set; } = DateTime.Now; // También permite NULL según tabla
}
