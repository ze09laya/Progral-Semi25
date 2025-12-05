using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Categoria")]
public class Categoria
{
    [Key]
    [Column("idCategoria")]
    public int IdCategoria { get; set; }

    [Required]
    [StringLength(100)]
    [Column("Descripcion")]
    public string Descripcion { get; set; }

    [Column("Estado")]
    public bool Estado { get; set; } = true;

    [Column("Fecha_Registro")]
    public DateTime Fecha_Registro { get; set; } = DateTime.Now;
}
