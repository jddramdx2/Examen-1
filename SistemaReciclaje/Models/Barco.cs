using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaReciclaje.Models
{
    public class Barco
    {
        [Key]
        public int ID_Barco { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero_Unico { get; set; }

        [Required]
        public DateTime Fecha_Ingreso { get; set; }
    }
}
