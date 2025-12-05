using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agroconexion.Models
{
    public class Permiso
    {
        [Key]
        public int idPermiso { get; set; }

        public int idRol { get; set; }  // FK a Rol

        public required string Nombre_Menu { get; set; }

        public DateTime Fecha_Registro { get; set; }

        [ForeignKey("idRol")]
        public required Rol Rol { get; set; }  // Relación con Rol
    }
}