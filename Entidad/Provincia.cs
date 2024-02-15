using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public string Descripcion { get; set; }
        public Departamento Departamento { get; set; }
    }
}
