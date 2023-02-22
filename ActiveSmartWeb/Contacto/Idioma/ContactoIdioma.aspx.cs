using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Contacto.Idioma
{
    public partial class ContactoIdioma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaGeneral Idioma = new EIdiomaGeneral();
            try
            {
                switch (Request.Form["IdiomaContactos"])
                {
                    case "ES":
                        Idioma.Nombre = EIdiomaEspannol._nombre;
                        Idioma.Apellido = EIdiomaEspannol._apellido;
                        Idioma.Correo = EIdiomaEspannol._correo;
                        Idioma.NumTelefono = EIdiomaEspannol._numTelefono;
                        Idioma.Mensaje = EIdiomaEspannol._mensaje;
                        Idioma.Enviar = EIdiomaEspannol._enviar;
                        Idioma.ErrNombre = EIdiomaEspannol._errNombre;
                        Idioma.ErrApellido = EIdiomaEspannol._errApellido;
                        Idioma.ErrCorreo = EIdiomaEspannol._errCorreo;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    case "EN":
                        Idioma.Nombre = EIdiomaIngles._nombre;
                        Idioma.Apellido = EIdiomaIngles._apellido;
                        Idioma.Correo = EIdiomaIngles._correo;
                        Idioma.NumTelefono = EIdiomaIngles._numTelefono;
                        Idioma.Mensaje = EIdiomaIngles._mensaje;
                        Idioma.Enviar = EIdiomaIngles._enviar;
                        Idioma.ErrNombre = EIdiomaIngles._errNombre;
                        Idioma.ErrApellido = EIdiomaIngles._errApellido;
                        Idioma.ErrCorreo = EIdiomaIngles._errCorreo;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));

                        break;
                    default:
                        Idioma.Nombre = EIdiomaEspannol._nombre;
                        Idioma.Apellido = EIdiomaEspannol._apellido;
                        Idioma.Correo = EIdiomaEspannol._correo;
                        Idioma.Mensaje = EIdiomaEspannol._mensaje;
                        Idioma.NumTelefono = EIdiomaEspannol._numTelefono;
                        Idioma.Enviar = EIdiomaEspannol._enviar;
                        Idioma.ErrNombre = EIdiomaEspannol._errNombre;
                        Idioma.ErrApellido = EIdiomaEspannol._errApellido;
                        Idioma.ErrCorreo = EIdiomaEspannol._errCorreo;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));

                        break;
                }
            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message,ex.StackTrace);
            }
        }
    }
}