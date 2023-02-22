using ActiveSmartWeb.Contrasenna.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Contrasenna
{
    public partial class IdiomaCambioAJAX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaGeneralPassword Idioma = new IdiomaGeneralPassword();
            try
            {
                switch (Request.Form["IdiomaOption"])
                {
                    case "ES":
                        Idioma.Titulo = IdiomaPasswordESP._titulo;
                        Idioma.Password = IdiomaPasswordESP._Password;
                        Idioma.PlhPassword = IdiomaPasswordESP._PlhPassword;
                        Idioma.ConfirmarPassword = IdiomaPasswordESP._ConfirmarPassword;
                        Idioma.PlhConfirmarPassword = IdiomaPasswordESP._PlhConfirmarPassword;
                        Idioma.Guardar = IdiomaPasswordESP._guardar;
                        Idioma.ErrorLargoAd = IdiomaPasswordESP._errorLargoAd;
                        Idioma.ErrorLargoOp = IdiomaPasswordESP._errorLargoOp;
                        Idioma.ErrorLetraMayusMinus = IdiomaPasswordESP._errorLetraMayusMinus;
                        Idioma.ErrorCaracterEspecial = IdiomaPasswordESP._errorCaracterEspecial;
                        Idioma.ErrorNoCoinciden = IdiomaPasswordESP._errorNoCoinciden;
                        Idioma.Atencion = IdiomaPasswordESP._atencion;
                        Idioma.ErrorNumero = IdiomaPasswordESP._errorNumero;
                        Idioma.ContraCambiada = IdiomaPasswordESP._contraCambiada;
                        Idioma.NingunaIgual = IdiomaPasswordESP._ningunaIgual;
                        Idioma.OlvidoContrasenna = IdiomaPasswordESP._olvidoContrasenna;
                        Idioma.TxtAyudaCorreo = IdiomaPasswordESP._txtAyudaCorreo;
                        Idioma.Correo = IdiomaPasswordESP._correo;
                        Idioma.Enviar = IdiomaPasswordESP._enviar;
                        Idioma.OlCorreoNo = IdiomaPasswordESP._olCorreoNo;
                        Idioma.OlCorreoIn = IdiomaPasswordESP._olCorreoIn;
                        Idioma.OlCorreoEr = IdiomaPasswordESP._olCorreoEr;
                        Idioma.OlCorreoEn = IdiomaPasswordESP._olCorreoEn;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;

                    case "EN":
                        Idioma.Titulo = IdiomaPasswordENG._titulo;
                        Idioma.Password = IdiomaPasswordENG._Password;
                        Idioma.PlhPassword = IdiomaPasswordENG._PlhPassword;
                        Idioma.ConfirmarPassword = IdiomaPasswordENG._ConfirmarPassword;
                        Idioma.PlhConfirmarPassword = IdiomaPasswordENG._PlhConfirmarPassword;
                        Idioma.Guardar = IdiomaPasswordENG._guardar;
                        Idioma.ErrorLargoAd = IdiomaPasswordENG._errorLargoAd;
                        Idioma.ErrorLargoOp = IdiomaPasswordENG._errorLargoOp;
                        Idioma.ErrorLetraMayusMinus = IdiomaPasswordENG._errorLetraMayusMinus;
                        Idioma.ErrorCaracterEspecial = IdiomaPasswordENG._errorCaracterEspecial;
                        Idioma.ErrorNoCoinciden = IdiomaPasswordENG._errorNoCoinciden;
                        Idioma.Atencion = IdiomaPasswordENG._atencion;
                        Idioma.ErrorNumero = IdiomaPasswordENG._errorNumero;
                        Idioma.ContraCambiada = IdiomaPasswordENG._contraCambiada;
                        Idioma.NingunaIgual = IdiomaPasswordENG._ningunaIgual;
                        Idioma.OlvidoContrasenna = IdiomaPasswordENG._olvidoContrasenna;
                        Idioma.TxtAyudaCorreo = IdiomaPasswordENG._txtAyudaCorreo;
                        Idioma.Correo = IdiomaPasswordENG._correo;
                        Idioma.Enviar = IdiomaPasswordENG._enviar;
                        Idioma.OlCorreoNo = IdiomaPasswordENG._olCorreoNo;
                        Idioma.OlCorreoIn = IdiomaPasswordENG._olCorreoIn;
                        Idioma.OlCorreoEr = IdiomaPasswordENG._olCorreoEr;
                        Idioma.OlCorreoEn = IdiomaPasswordENG._olCorreoEn;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:
                        Idioma.Titulo = IdiomaPasswordESP._titulo;
                        Idioma.Password = IdiomaPasswordESP._Password;
                        Idioma.PlhPassword = IdiomaPasswordESP._PlhPassword;
                        Idioma.ConfirmarPassword = IdiomaPasswordESP._ConfirmarPassword;
                        Idioma.PlhConfirmarPassword = IdiomaPasswordESP._PlhConfirmarPassword;
                        Idioma.Guardar = IdiomaPasswordESP._guardar;
                        Idioma.ErrorLargoAd = IdiomaPasswordESP._errorLargoAd;
                        Idioma.ErrorLargoOp = IdiomaPasswordESP._errorLargoOp;
                        Idioma.ErrorLetraMayusMinus = IdiomaPasswordESP._errorLetraMayusMinus;
                        Idioma.ErrorCaracterEspecial = IdiomaPasswordESP._errorCaracterEspecial;
                        Idioma.ErrorNoCoinciden = IdiomaPasswordESP._errorNoCoinciden;
                        Idioma.Atencion = IdiomaPasswordESP._atencion;
                        Idioma.ErrorNumero = IdiomaPasswordESP._errorNumero;
                        Idioma.ContraCambiada = IdiomaPasswordESP._contraCambiada;
                        Idioma.NingunaIgual = IdiomaPasswordESP._ningunaIgual;
                        Idioma.OlvidoContrasenna = IdiomaPasswordESP._olvidoContrasenna;
                        Idioma.TxtAyudaCorreo = IdiomaPasswordESP._txtAyudaCorreo;
                        Idioma.Correo = IdiomaPasswordESP._correo;
                        Idioma.Enviar = IdiomaPasswordESP._enviar;
                        Idioma.OlCorreoNo = IdiomaPasswordESP._olCorreoNo;
                        Idioma.OlCorreoIn = IdiomaPasswordESP._olCorreoIn;
                        Idioma.OlCorreoEr = IdiomaPasswordESP._olCorreoEr;
                        Idioma.OlCorreoEn = IdiomaPasswordESP._olCorreoEn;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
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