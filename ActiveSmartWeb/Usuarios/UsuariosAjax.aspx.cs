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

                        string Contrasena = "GrupoDiverscan2022.";

                        var Respuesta = nMisCompras.RegistrarActualizarUsuarioEmpleado(IdEmpresaIngresar, IdRol, Correo, Contrasena);

                        Response.Write(Respuesta);

                        break;


                }


            }
            catch (Exception ex)

            {


            }

        }
    }
}