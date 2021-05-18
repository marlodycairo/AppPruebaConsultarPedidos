using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infrastructure.Repositories.Entities
{
    public class Clientes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        [Key]
        public int Identificacion { get; set; }
        public string Direccion { get; set; }
    }
}
