using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agroconexion.Models
{
    public class Venta
    {
        [Key]
        public int idVenta { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int idUsuario { get; set; }

        [ForeignKey("Cliente")]
        public int? idCliente { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo_Documento { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero_Documento { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Monto_Pago { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Monto_Cambio { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Monto_Total { get; set; }

        public DateTime? Fecha_Registro { get; set; }

        // Relaciones
        public Usuario? Usuario { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
