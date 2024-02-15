using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidad;

namespace Negocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objDatos = new CD_Usuarios();

        public List<Usuario> Listar()
        {
            return objDatos.Listar();
        }
    }
}
