using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.Usuarios.idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;

namespace ActiveSmartWeb.Usuarios
{
    public partial class IdiomaUsuariosAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EIdiomaUsuariosGeneral eIdioma = new EIdiomaUsuariosGeneral();

            try
            {

                switch (Request.Form["idioma"])
                {

                    //Opcion del switch para cargar el idioma en español.
                    case "ES":

                        eIdioma.Titulo = EIdiomaUsuariosEspañol.Titulo;
                        eIdioma.Titulo1TablaUsuarios = EIdiomaUsuariosEspañol.Titulo1TablaUsuarios;
                        eIdioma.Titulo2TablaUsuarios = EIdiomaUsuariosEspañol.Titulo2TablaUsuarios;
                        eIdioma.Titulo3TablaUsuarios = EIdiomaUsuariosEspañol.Titulo3TablaUsuarios;
                        eIdioma.Titulo4TablaUsuarios = EIdiomaUsuariosEspañol.Titulo4TablaUsuarios;
                        eIdioma.Titulo5TablaUsuarios = EIdiomaUsuariosEspañol.Titulo5TablaUsuarios;
                        eIdioma.Titulo6TablaUsuarios = EIdiomaUsuariosEspañol.Titulo6TablaUsuarios;
                        eIdioma.TextoLeyenda = EIdiomaUsuariosEspañol.TextoLeyenda;
                        eIdioma.BotonIrTienda = EIdiomaUsuariosEspañol.BotonIrTienda;
                        eIdioma.CreaUsuario = EIdiomaUsuariosEspañol.CreaUsuario;
                        eIdioma.RolUsuario = EIdiomaUsuariosEspañol.RolUsuario;
                        eIdioma.Atencion = EIdiomaUsuariosEspañol.Atencion;
                        eIdioma.Msj1 = EIdiomaUsuariosEspañol.Msj1;
                        eIdioma.Msj2 = EIdiomaUsuariosEspañol.Msj2;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));

                        break;

                    //Opcion del switch para cargar el idioma en ingles.
                    case "EN":

                        eIdioma.Titulo = EIdiomaUsuariosIngles.Titulo;
                        eIdioma.Titulo1TablaUsuarios = EIdiomaUsuariosIngles.Titulo1TablaUsuarios;
                        eIdioma.Titulo2TablaUsuarios = EIdiomaUsuariosIngles.Titulo2TablaUsuarios;
                        eIdioma.Titulo3TablaUsuarios = EIdiomaUsuariosIngles.Titulo3TablaUsuarios;
                        eIdioma.Titulo4TablaUsuarios = EIdiomaUsuariosIngles.Titulo4TablaUsuarios;
                        eIdioma.Titulo5TablaUsuarios = EIdiomaUsuariosIngles.Titulo5TablaUsuarios;
                        eIdioma.Titulo6TablaUsuarios = EIdiomaUsuariosIngles.Titulo6TablaUsuarios;
                        eIdioma.TextoLeyenda = EIdiomaUsuariosIngles.TextoLeyenda;
                        eIdioma.BotonIrTienda = EIdiomaUsuariosIngles.BotonIrTienda;
                        eIdioma.CreaUsuario = EIdiomaUsuariosIngles.CreaUsuario;
                        eIdioma.RolUsuario = EIdiomaUsuariosIngles.RolUsuario;
                        eIdioma.Atencion = EIdiomaUsuariosIngles.Atencion;
                        eIdioma.Msj1 = EIdiomaUsuariosIngles.Msj1;
                        eIdioma.Msj2 = EIdiomaUsuariosIngles.Msj2;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;

                    default:

                        eIdioma.Titulo = EIdiomaUsuariosEspañol.Titulo;
                        eIdioma.Titulo1TablaUsuarios = EIdiomaUsuariosEspañol.Titulo1TablaUsuarios;
                        eIdioma.Titulo2TablaUsuarios = EIdiomaUsuariosEspañol.Titulo2TablaUsuarios;
                        eIdioma.Titulo3TablaUsuarios = EIdiomaUsuariosEspañol.Titulo3TablaUsuarios;
                        eIdioma.Titulo4TablaUsuarios = EIdiomaUsuariosEspañol.Titulo4TablaUsuarios;
                        eIdioma.Titulo5TablaUsuarios = EIdiomaUsuariosEspañol.Titulo5TablaUsuarios;
                        eIdioma.Titulo6TablaUsuarios = EIdiomaUsuariosEspañol.Titulo6TablaUsuarios;
                        eIdioma.TextoLeyenda = EIdiomaUsuariosEspañol.TextoLeyenda;
                        eIdioma.BotonIrTienda = EIdiomaUsuariosEspañol.BotonIrTienda;
                        eIdioma.CreaUsuario = EIdiomaUsuariosEspañol.CreaUsuario;
                        eIdioma.RolUsuario = EIdiomaUsuariosEspañol.RolUsuario;
                        eIdioma.Atencion = EIdiomaUsuariosEspañol.Atencion;
                        eIdioma.Msj1 = EIdiomaUsuariosEspañol.Msj1;
                        eIdioma.Msj2 = EIdiomaUsuariosEspañol.Msj2;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));

                        break;

                }

            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }

        }
    }
}