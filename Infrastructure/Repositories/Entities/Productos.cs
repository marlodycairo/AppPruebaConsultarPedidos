using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infrastructure.Repositories.Entities
{
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
