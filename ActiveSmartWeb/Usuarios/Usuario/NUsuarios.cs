using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Usuarios.Usuario
{
    public class NUsuarios
    {
        DUsuarios dUsuarios = new DUsuarios();

        public List<Usuario> ConsultarUsuarios(int idPerfilEmpresa)
        {
            try {
                List<Usuario> usuarios = dUsuarios.ConsultarUsuarios(idPerfilEmpresa);
                return usuarios;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<Usuario>();
            }
        }

        public string RegistrarActualizarUsuarioEmpleado(int idPerfilEmpresa, int idRol, string correo, string contrasena)
        {

            try
            {
                return dUsuarios.RegistrarActualizarUsuarioEmpleado(idPerfilEmpresa,idRol,correo,contrasena);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

    }
}