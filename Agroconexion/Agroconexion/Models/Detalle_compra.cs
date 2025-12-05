using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agroconexion.Models
{
    public class Detalle_compra
    {
        [Key]
        public int IdDetalle_Compra { get; set; }

        [Required]
        [ForeignKey("Compra")]
        public int idCompra { get; set; }

        [Required]
        [ForeignKey("Producto")]
        public int idProducto { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio_Compra { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio_Venta { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Monto_Total { get; set; }

        public DateTime? Fecha_Registro { get; set; }

        // Relaciones
        public Compra Compra { get; set; }
        public Producto Producto { get; set; }
    }
}
