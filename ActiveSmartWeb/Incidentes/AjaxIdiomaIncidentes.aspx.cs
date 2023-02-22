using ActiveSmartWeb.Incidentes.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Incidentes
{
    public partial class AjaxIdiomaIncidentes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaIncidenteGeneral idioma = new EIdiomaIncidenteGeneral();
            try
            {
                switch (Request.Form["IdiomaPerfilUsuario"])
                {
                    case "ES":
                        idioma.Titulo = EIdiomaIncidenteEspañol.Titulo;
                        idioma.Asunto = EIdiomaIncidenteEspañol.Asunto;
                        idioma.Nombre = EIdiomaIncidenteEspañol.Nombre;
                        idioma.Apellidos = EIdiomaIncidenteEspañol.Apellidos;
                        idioma.NumeroTelefono = EIdiomaIncidenteEspañol.NumeroTelefono;
                        idioma.Correo = EIdiomaIncidenteEspañol.Correo;
                        idioma.Mensaje = EIdiomaIncidenteEspañol.Mensaje;
                        idioma.PhMensaje = EIdiomaIncidenteEspañol.PhMensaje;
                        idioma.Enviar = EIdiomaIncidenteEspañol.Enviar;
                        idioma.Descubra = EIdiomaIncidenteEspañol.Descubra;
                        idioma.Tienda = EIdiomaIncidenteEspañol.Tienda;
                        idioma.LlenarTipoIcidente = EIdiomaIncidenteEspañol.LlenarTipoIcidente;
                        idioma.LlenarTelefono = EIdiomaIncidenteEspañol.LlenarTelefono;
                        idioma.LlenarMensaje = EIdiomaIncidenteEspañol.LlenarMensaje;
                        idioma.Guardado = EIdiomaIncidenteEspañol.Guardado;
                        idioma.Error = EIdiomaIncidenteEspañol.Error;
                        idioma.TelNoValido = EIdiomaIncidenteEspañol.TelNoValido;
                        idioma.Atencion = EIdiomaIncidenteEspañol.Atencion;
                        idioma.Msj1 = EIdiomaIncidenteEspañol.Msj1;
                        idioma.Msj2 = EIdiomaIncidenteEspañol.Msj2;
                        Response.Write(JsonConvert.SerializeObject(idioma, Formatting.Indented));
                        break;
                    case "EN":
                        idioma.Titulo = EIdiomaIncidenteIngles.Titulo;
                        idioma.Asunto = EIdiomaIncidenteIngles.Asunto;
                        idioma.Nombre = EIdiomaIncidenteIngles.Nombre;
                        idioma.Apellidos = EIdiomaIncidenteIngles.Apellidos;
                        idioma.NumeroTelefono = EIdiomaIncidenteIngles.NumeroTelefono;
                        idioma.Correo = EIdiomaIncidenteIngles.Correo;
                        idioma.Mensaje = EIdiomaIncidenteIngles.Mensaje;
                        idioma.PhMensaje = EIdiomaIncidenteIngles.PhMensaje;
                        idioma.Enviar = EIdiomaIncidenteIngles.Enviar;
                        idioma.Descubra = EIdiomaIncidenteIngles.Descubra;
                        idioma.Tienda = EIdiomaIncidenteIngles.Tienda;
                        idioma.LlenarTipoIcidente = EIdiomaIncidenteIngles.LlenarTipoIcidente;
                        idioma.LlenarTelefono = EIdiomaIncidenteIngles.LlenarTelefono;
                        idioma.LlenarMensaje = EIdiomaIncidenteIngles.LlenarMensaje;
                        idioma.Guardado = EIdiomaIncidenteIngles.Guardado;
                        idioma.Error = EIdiomaIncidenteIngles.Error;
                        idioma.TelNoValido = EIdiomaIncidenteIngles.TelNoValido;
                        idioma.Atencion = EIdiomaIncidenteIngles.Atencion;
                        idioma.Msj1 = EIdiomaIncidenteIngles.Msj1;
                        idioma.Msj2 = EIdiomaIncidenteIngles.Msj2;
                        Response.Write(JsonConvert.SerializeObject(idioma, Formatting.Indented));
                        break;
                    default:
                        idioma.Titulo = EIdiomaIncidenteEspañol.Titulo;
                        idioma.Asunto = EIdiomaIncidenteEspañol.Asunto;
                        idioma.Nombre = EIdiomaIncidenteEspañol.Nombre;
                        idioma.Apellidos = EIdiomaIncidenteEspañol.Apellidos;
                        idioma.NumeroTelefono = EIdiomaIncidenteEspañol.NumeroTelefono;
                        idioma.Correo = EIdiomaIncidenteEspañol.Correo;
                        idioma.Mensaje = EIdiomaIncidenteEspañol.Mensaje;
                        idioma.PhMensaje = EIdiomaIncidenteEspañol.PhMensaje;
                        idioma.Enviar = EIdiomaIncidenteEspañol.Enviar;
                        idioma.Descubra = EIdiomaIncidenteEspañol.Descubra;
                        idioma.Tienda = EIdiomaIncidenteEspañol.Tienda;
                        idioma.LlenarTipoIcidente = EIdiomaIncidenteEspañol.LlenarTipoIcidente;
                        idioma.LlenarTelefono = EIdiomaIncidenteEspañol.LlenarTelefono;
                        idioma.LlenarMensaje = EIdiomaIncidenteEspañol.LlenarMensaje;
                        idioma.Guardado = EIdiomaIncidenteEspañol.Guardado;
                        idioma.Error = EIdiomaIncidenteEspañol.Error;
                        idioma.TelNoValido = EIdiomaIncidenteEspañol.TelNoValido;
                        idioma.Atencion = EIdiomaIncidenteEspañol.Atencion;
                        idioma.Msj1 = EIdiomaIncidenteEspañol.Msj1;
                        idioma.Msj2 = EIdiomaIncidenteEspañol.Msj2;
                        Response.Write(JsonConvert.SerializeObject(idioma, Formatting.Indented));
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