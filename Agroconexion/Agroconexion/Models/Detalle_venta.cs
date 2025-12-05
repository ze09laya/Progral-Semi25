using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agroconexion.Models
{
    public class Detalle_venta
    {
        [Key]
        public int IdDetalle_Venta { get; set; }

        [Required]
        [ForeignKey("Venta")]
        public int idVenta { get; set; }

        [Required]
        [ForeignKey("Producto")]
        public int idProducto { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio_Venta { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }

        public DateTime? Fecha_Registro { get; set; }

        // Relaciones
        public Venta Venta { get; set; }
        public Producto Producto { get; set; }
    }
}
