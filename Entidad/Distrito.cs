using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Distrito
    {
        public int IdDistrito { get; set; }
        public string Descripcion { get; set; }
        public Provincia Provincia { get; set; }
        public Departamento Departamento { get; set; }
    }
}
