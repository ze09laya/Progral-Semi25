using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Agroconexion.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        [Column("idProducto")]
        [JsonPropertyName("idProducto")]
        public int idProducto { get; set; }

        [Column("Codigo")]
        [JsonPropertyName("codigo")]
        public string Codigo { get; set; }

        [Column("Nombre")]
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [Column("Descripcion")]
        [JsonPropertyName("descripcion")]
        public string? Descripcion { get; set; }

        [Column("idCategoria")]
        [JsonPropertyName("idCategoria")]
        public int idCategoria { get; set; }

        [Column("Stock")]
        [JsonPropertyName("stock")]
        public int? Stock { get; set; }

        [Column("Precio_Compra")]
        [JsonPropertyName("precio_Compra")]
        public decimal Precio_Compra { get; set; }

        [Column("Precio_Venta")]
        [JsonPropertyName("precio_Venta")]
        public decimal Precio_Venta { get; set; }

        [Column("Estado")]
        [JsonPropertyName("estado")]
        public bool? Estado { get; set; }

        [Column("Fecha_Registro")]
        [JsonPropertyName("fecha_Registro")]
        public DateTime? Fecha_Registro { get; set; }

        [ForeignKey("idCategoria")]
        [JsonPropertyName("categoria")]
        public Categoria? Categoria { get; set; }
    }
}
