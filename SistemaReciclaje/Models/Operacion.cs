using System;

namespace SistemaReciclaje.Models
{
    public class Operacion
    {
        public int ID_Operacion { get; set; }
        public int ID_Barco { get; set; }
        public string Tipo_Operacion { get; set; }
        public DateTime Fecha_Operacion { get; set; }
        public float Kilos { get; set; }

        // Relación con la clase TipoBasura
        public TipoBasura TipoBasura { get; set; }
    }
}
