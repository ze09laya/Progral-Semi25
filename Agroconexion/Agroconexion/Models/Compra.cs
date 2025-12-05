using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agroconexion.Models
{
    public class Compra
    {
        [Key]
        public int idCompra { get; set; }

        [Required]
        public int idUsuario { get; set; }

        [Required]
        public int idProveedor { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo_Documento { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero_Documento { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Monto_Total { get; set; }

        public DateTime? Fecha_Registro { get; set; }

        // 🔥 ELIMINADO: estas propiedades obligaban al API a pedir TODO
        // public Usuario Usuario { get; set; }
        // public Proveedor Proveedor { get; set; }
        // public ICollection<Detalle_compra> DetallesCompra { get; set; }
    }
}
