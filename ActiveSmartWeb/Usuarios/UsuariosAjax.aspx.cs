using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.Usuarios.Usuario;
using Newtonsoft.Json;


namespace ActiveSmartWeb.Usuarios
{
    public partial class UsuariosAjax : System.Web.UI.Page
    {

        NUsuarios nMisCompras = new NUsuarios();
        Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

                switch (Request.Form["option"])
                {

                    //Opcion del switch para cargar las configuraciones de los planes.
                    case "CargarUsuarios":

                        var IdEmpresa = Convert.ToInt32(Request.Form["idEmpresa"]);

                        var eusuarios = nMisCompras.ConsultarUsuarios(IdEmpresa);

                        Response.Write(JsonConvert.SerializeObject(eusuarios, Formatting.Indented));

                        break;

                    //Opcion del switch para registrar o actualizar un usuario de una empresa.
                    case "RegistrarActualizarUsuarioEmpleado":

                        var IdEmpresaIngresar = Convert.ToInt32(Request.Form["idEmpresa"]);

                        var IdRol = Convert.ToInt32(Request.Form["idRol"]);

                        var Correo = Request.Form["correo"];

                        var Contrasena = "";

                        //Asignar posibles caracteres para crear una contraseña
                        char[] Mayusculas = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
                        char[] Minusculas = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
                        char[] Simbolos = { '¿', '?', '-', '_', '@', '&', '#', '/', '=', '*','¡'};
                        char[] Numeros = Enumerable.Range('0', 10).Select(x => (char)x).ToArray();

                        char[] PassList = Mayusculas.Concat(Minusculas).Concat(Simbolos).Concat(Numeros).ToArray();

                        //Crear contraseña random
                        var longitud = 10;
                        for (int i = 0; i < longitud; i++)
                        {
                            int randomNumber = random.Next(0, PassList.Length);
                            Contrasena = Contrasena + PassList[randomNumber];

                        }




                        var Respuesta = nMisCompras.RegistrarActualizarUsuarioEmpleado(IdEmpresaIngresar, IdRol, Correo, Contrasena);

                        Response.Write(Respuesta);

                        break;

                    case "ActualizarRol":

                        var empresa = Convert.ToInt32(Request.Form["idEmpresa"]);

                        var rol = Convert.ToInt32(Request.Form["idRol"]);

                        var correo = Request.Form["correo"];

                        Response.Write(nMisCompras.ActualizarRol(empresa, rol, correo));

                        break;

                }


            }
            catch (Exception ex)

            {


            }

        }
    }
}