using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Carrito
    {
        public int IdCarrito { get; set; }
        public Cliente Cliente { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
