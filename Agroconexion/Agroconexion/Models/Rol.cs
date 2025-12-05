using System;
using System.ComponentModel.DataAnnotations;

namespace Agroconexion.Models
{
    public class Rol
    {
        [Key]
        public int idRol { get; set; }

        public required string Descripcion { get; set; }  // required elimina la advertencia

        public DateTime Fecha_Registro { get; set; }
    }
}
