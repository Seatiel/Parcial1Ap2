using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1Ap2.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nombres { get; set; }
        public int CantidadTelefonos { get; set; }

    }
}
