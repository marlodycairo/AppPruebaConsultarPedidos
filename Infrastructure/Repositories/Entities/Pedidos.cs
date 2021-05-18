using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infrastructure.Repositories.Entities
{
    public class Pedidos
    {
        [Key]
        public int IdPedido { get; set; }
        public int IdDocumentoCliente { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
    }
}
