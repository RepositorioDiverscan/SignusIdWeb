using ActiveSmartWeb.Perfil.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ActiveSmartWeb.Perfil
{
    public partial class AjaxIdiomaPerfilUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaPerfilGeneral idioma = new EIdiomaPerfilGeneral();

            try
            {
                switch (Request.Form["IdiomaPerfilUsuario"])
                {
                    case "ES":
                        idioma.Titulo = EIdiomaPerfilEspañol.Titulo;
                        idioma.TipoUsuario = EIdiomaPerfilEspañol.TipoUsuario;
                        idioma.NumeroCuenta = EIdiomaPerfilEspañol.NumeroCuenta;
                        idioma.PerfilGeneral = EIdiomaPerfilEspañol.PerfilGeneral;
                        idioma.Nombre = EIdiomaPerfilEspañol.Nombre;
                        idioma.Apellidos = EIdiomaPerfilEspañol.Apellidos;
                        idioma.IdentificacionPersonal = EIdiomaPerfilEspañol.IdentificacionPersonal;
                        idioma.Correo = EIdiomaPerfilEspañol.Correo;
                        idioma.Puesto = EIdiomaPerfilEspañol.Puesto;
                        idioma.Telefono = EIdiomaPerfilEspañol.Telefono;
                        idioma.CambiarContra = EIdiomaPerfilEspañol.CambiarContra;
                        idioma.ContraActual = EIdiomaPerfilEspañol.ContraActual;
                        idioma.NuevaContra = EIdiomaPerfilEspañol.NuevaContra;
                        idioma.ConfirmaContra = EIdiomaPerfilEspañol.ConfirmaContra;
                        idioma.Descubra = EIdiomaPerfilEspañol.Descubra;
                        idioma.IrTienda = EIdiomaPerfilEspañol.IrTienda;
                        idioma.CorreoError = EIdiomaPerfilEspañol.CorreoError;
                        idioma.TelefonoError = EIdiomaPerfilEspañol.TelefonoError;
                        idioma.FaltanCampos = EIdiomaPerfilEspañol.FaltanCampos;
                        idioma.UsuarioActualizado = EIdiomaPerfilEspañol.UsuarioActualizado;
                        idioma.ErrorContrasIguales = EIdiomaPerfilEspañol.ErrorContrasIguales;
                        idioma.ErrorContraActNoCoincide = EIdiomaPerfilEspañol.ErrorContraActNoCoincide;
                        idioma.ErrorNuevaContraConf = EIdiomaPerfilEspañol.ErrorNuevaContraConf;
                        idioma.ContraActualizada = EIdiomaPerfilEspañol.ContraActualizada;
                        idioma.ErrorNuevaContraLargo = EIdiomaPerfilEspañol.ErrorNuevaContraLargo;
                        idioma.ErrorNuevaContraNumero = EIdiomaPerfilEspañol.ErrorNuevaContraNumero;
                        idioma.ErrorNuevaContraEspecial = EIdiomaPerfilEspañol.ErrorNuevaContraEspecial;
                        idioma.ErrorNuevaContraMayus = EIdiomaPerfilEspañol.ErrorNuevaContraMayus;
                        idioma.ErrorNuevaContraMinus = EIdiomaPerfilEspañol.ErrorNuevaContraMinus;
                        idioma.ErrorNuevaContraActualizar = EIdiomaPerfilEspañol.ErrorNuevaContraActualizar;
                        idioma.ErrorNuevaContranIgual = EIdiomaPerfilEspañol.ErrorNuevaContranIgual;
                        idioma.LlenarIdentificacion = EIdiomaPerfilEspañol.LlenarIdentificacion;
                        idioma.LlenarPuesto = EIdiomaPerfilEspañol.LlenarPuesto;
                        idioma.LlenarTelefono = EIdiomaPerfilEspañol.LlenarTelefono;
                        idioma.Atencion = EIdiomaPerfilEspañol.Atencion;
                        idioma.MsjInfo1 = EIdiomaPerfilEspañol.MsjInfo1;
                        idioma.MsjInfo2 = EIdiomaPerfilEspañol.MsjInfo2;
                        Response.Write(JsonConvert.SerializeObject(idioma, Formatting.Indented));
                        break;

                    case "EN":
                        idioma.Titulo = EIdiomaPerfilIngles.Titulo;
                        idioma.TipoUsuario = EIdiomaPerfilIngles.TipoUsuario;
                        idioma.NumeroCuenta = EIdiomaPerfilIngles.NumeroCuenta;
                        idioma.PerfilGeneral = EIdiomaPerfilIngles.PerfilGeneral;
                        idioma.Nombre = EIdiomaPerfilIngles.Nombre;
                        idioma.Apellidos = EIdiomaPerfilIngles.Apellidos;
                        idioma.IdentificacionPersonal = EIdiomaPerfilIngles.IdentificacionPersonal;
                        idioma.Correo = EIdiomaPerfilIngles.Correo;
                        idioma.Puesto = EIdiomaPerfilIngles.Puesto;
                        idioma.Telefono = EIdiomaPerfilIngles.Telefono;
                        idioma.CambiarContra = EIdiomaPerfilIngles.CambiarContra;
                        idioma.ContraActual = EIdiomaPerfilIngles.ContraActual;
                        idioma.NuevaContra = EIdiomaPerfilIngles.NuevaContra;
                        idioma.ConfirmaContra = EIdiomaPerfilIngles.ConfirmaContra;
                        idioma.Descubra = EIdiomaPerfilIngles.Descubra;
                        idioma.IrTienda = EIdiomaPerfilIngles.IrTienda;
                        idioma.CorreoError = EIdiomaPerfilIngles.CorreoError;
                        idioma.TelefonoError = EIdiomaPerfilIngles.TelefonoError;
                        idioma.FaltanCampos = EIdiomaPerfilIngles.FaltanCampos;
                        idioma.UsuarioActualizado = EIdiomaPerfilIngles.UsuarioActualizado;
                        idioma.ErrorContrasIguales = EIdiomaPerfilIngles.ErrorContrasIguales;
                        idioma.ErrorContraActNoCoincide = EIdiomaPerfilIngles.ErrorContraActNoCoincide;
                        idioma.ErrorNuevaContraConf = EIdiomaPerfilIngles.ErrorNuevaContraConf;
                        idioma.ContraActualizada = EIdiomaPerfilIngles.ContraActualizada;
                        idioma.ErrorNuevaContraLargo = EIdiomaPerfilIngles.ErrorNuevaContraLargo;
                        idioma.ErrorNuevaContraNumero = EIdiomaPerfilIngles.ErrorNuevaContraNumero;
                        idioma.ErrorNuevaContraEspecial = EIdiomaPerfilIngles.ErrorNuevaContraEspecial;
                        idioma.ErrorNuevaContraMayus = EIdiomaPerfilIngles.ErrorNuevaContraMayus;
                        idioma.ErrorNuevaContraMinus = EIdiomaPerfilIngles.ErrorNuevaContraMinus;
                        idioma.ErrorNuevaContraActualizar = EIdiomaPerfilIngles.ErrorNuevaContraActualizar;
                        idioma.ErrorNuevaContranIgual = EIdiomaPerfilIngles.ErrorNuevaContranIgual;
                        idioma.LlenarIdentificacion = EIdiomaPerfilIngles.LlenarIdentificacion;
                        idioma.LlenarPuesto = EIdiomaPerfilIngles.LlenarPuesto;
                        idioma.LlenarTelefono = EIdiomaPerfilIngles.LlenarTelefono;
                        idioma.Atencion = EIdiomaPerfilIngles.Atencion; 
                        idioma.MsjInfo2 = EIdiomaPerfilIngles.MsjInfo2;
                        idioma.MsjInfo1 = EIdiomaPerfilIngles.MsjInfo1;
                        Response.Write(JsonConvert.SerializeObject(idioma, Formatting.Indented));
                        break;
                    default:
                        idioma.Titulo = EIdiomaPerfilEspañol.Titulo;
                        idioma.TipoUsuario = EIdiomaPerfilEspañol.TipoUsuario;
                        idioma.NumeroCuenta = EIdiomaPerfilEspañol.NumeroCuenta;
                        idioma.PerfilGeneral = EIdiomaPerfilEspañol.PerfilGeneral;
                        idioma.Nombre = EIdiomaPerfilEspañol.Nombre;
                        idioma.Apellidos = EIdiomaPerfilEspañol.Apellidos;
                        idioma.IdentificacionPersonal = EIdiomaPerfilEspañol.IdentificacionPersonal;
                        idioma.Correo = EIdiomaPerfilEspañol.Correo;
                        idioma.Puesto = EIdiomaPerfilEspañol.Puesto;
                        idioma.Telefono = EIdiomaPerfilEspañol.Telefono;
                        idioma.CambiarContra = EIdiomaPerfilEspañol.CambiarContra;
                        idioma.ContraActual = EIdiomaPerfilEspañol.ContraActual;
                        idioma.NuevaContra = EIdiomaPerfilEspañol.NuevaContra;
                        idioma.ConfirmaContra = EIdiomaPerfilEspañol.ConfirmaContra;
                        idioma.Descubra = EIdiomaPerfilEspañol.Descubra;
                        idioma.IrTienda = EIdiomaPerfilEspañol.IrTienda;
                        idioma.CorreoError = EIdiomaPerfilEspañol.CorreoError;
                        idioma.TelefonoError = EIdiomaPerfilEspañol.TelefonoError;
                        idioma.FaltanCampos = EIdiomaPerfilEspañol.FaltanCampos;
                        idioma.UsuarioActualizado = EIdiomaPerfilEspañol.UsuarioActualizado;
                        idioma.ErrorContrasIguales = EIdiomaPerfilEspañol.ErrorContrasIguales;
                        idioma.ErrorContraActNoCoincide = EIdiomaPerfilEspañol.ErrorContraActNoCoincide;
                        idioma.ErrorNuevaContraConf = EIdiomaPerfilEspañol.ErrorNuevaContraConf;
                        idioma.ContraActualizada = EIdiomaPerfilEspañol.ContraActualizada;
                        idioma.ErrorNuevaContraLargo = EIdiomaPerfilEspañol.ErrorNuevaContraLargo;
                        idioma.ErrorNuevaContraNumero = EIdiomaPerfilEspañol.ErrorNuevaContraNumero;
                        idioma.ErrorNuevaContraEspecial = EIdiomaPerfilEspañol.ErrorNuevaContraEspecial;
                        idioma.ErrorNuevaContraMayus = EIdiomaPerfilEspañol.ErrorNuevaContraMayus;
                        idioma.ErrorNuevaContraMinus = EIdiomaPerfilEspañol.ErrorNuevaContraMinus;
                        idioma.ErrorNuevaContraActualizar = EIdiomaPerfilEspañol.ErrorNuevaContraActualizar;
                        idioma.ErrorNuevaContranIgual = EIdiomaPerfilEspañol.ErrorNuevaContranIgual;
                        idioma.LlenarIdentificacion = EIdiomaPerfilEspañol.LlenarIdentificacion;
                        idioma.LlenarPuesto = EIdiomaPerfilEspañol.LlenarPuesto;
                        idioma.LlenarTelefono = EIdiomaPerfilEspañol.LlenarTelefono;
                        idioma.Atencion = EIdiomaPerfilEspañol.Atencion;
                        idioma.MsjInfo2 = EIdiomaPerfilEspañol.MsjInfo2;
                        idioma.MsjInfo1 = EIdiomaPerfilEspañol.MsjInfo1;
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