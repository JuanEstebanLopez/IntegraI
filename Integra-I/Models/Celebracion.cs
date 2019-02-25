using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Integra_I.Models
{
    public class Celebracion
    {
        public int Id { get; set; }
        // Evento
        public string TipoEvento { get; set; }
        public string Direccion { get; set; }
        public string Necesidades { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public int Asistentes { get; set; }
        public string Detalles { get; set; }
        // Información de contacto
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
    }
}
