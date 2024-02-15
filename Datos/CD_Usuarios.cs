using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CD_Usuarios
    {
        public List<Usuario> Listar()
        {
            List<Usuario> ListaUsuarios = new List<Usuario>();

            try {
                using (SqlConnection oconexion = new SqlConnection (Conexion.cn)) {
                    string query = "select IdUsuario, Nombres, Apellidos, Correo, Clave, Restablecer, Activo from USUARIO";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ListaUsuarios.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Nombres = dr["Nombres"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Restableces = Convert.ToBoolean(dr["Restablecer"]),
                                Activo =Convert.ToBoolean(dr["Activo"])
                            });
                        }
                    }
                }
            }
            catch
            {
                ListaUsuarios = new List<Usuario>();
            }

            return ListaUsuarios;
        }
    }
}
