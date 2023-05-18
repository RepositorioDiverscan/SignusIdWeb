using ActiveSmartWeb.Authorize;
using ActiveSmartWeb.Contrasenna.CambioContrasena;
using ActiveSmartWeb.Login.Entidades;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Login
{
    public partial class LoginAjax : System.Web.UI.Page
    {
        private string validarSubscripcion(string subscripcion)
        {
            
            if(subscripcion != "")
            {
                string estado = pagoAuthorize.getStatus(subscripcion);
                if (estado != "active")
                {
                    return "Su subscripción se encuentra suspendida";
                }
                else
                {
                    return "BIEN";
                }
                
            }
            
            return "Este usuario no posee una subscripcón";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            NCambioPSW _nPassword = new NCambioPSW();
            Nlogin _nlogin = new Nlogin();
            MD5 md5Hash = MD5.Create(); 

            try {
                switch (Request.Form["opciones"])
                {


                    case "ValidUsers":
                        string Resultado = "BIEN";
                        var data1 = _nlogin.ValidUser(
                                Request.Form["Email"].ToString(),
                                 Encrypt.EncriptarSHA3_512(Request.Form["Password"].ToString())
                            );
                        string res1 = _nlogin.ValidadInicioSesion(Request.Form["Email"].ToString(), Encrypt.EncriptarSHA3_512(Request.Form["Password"].ToString()));


                        if (res1 != "EXITO" && res1 != "EL USUARIO NO A VERIFICADO SU CORREO")
                        {
                            Resultado = res1;
                        }
                        else if (data1.Count == 0)
                        {
                            Resultado  = "USAURIO NO VALIDO, POR FAVOR INTENTELO NUEVAMENTE";
                        }

                        if(Resultado == "Validar Subscripcion" || Resultado == "Actualizar")
                        {
                            string subscripcion = _nlogin.obtenerSubscripcionPorCorreo(Request.Form["Email"].ToString());
                            string resultadoValidacion = validarSubscripcion(subscripcion);
                            if(Resultado == "Actualizar" && resultadoValidacion== "BIEN")
                            {
                                _nlogin.actualizarFechaExpiracion(Request.Form["Email"].ToString());
                            }
                            Resultado = resultadoValidacion;
                        }

                        if (Resultado != "BIEN")
                        {
                            Response.Write(Resultado);
                            break;
                        }
                        else
                        {
                            Response.Write(JsonConvert.SerializeObject(data1, Formatting.Indented));
                            break;
                        }

                    case "validarSuscripcionEmpresa":
                        var idEmpresa = int.Parse(Request.Form["idEmpresa"]);
                        var idSuscripcion = _nlogin.obtenerSubscripcionPorIdEmpresa(idEmpresa);
                        string resultado = validarSubscripcion(idSuscripcion);

                        Response.Write(resultado);
                        break;

                }
            } 
            catch
            {
                Response.Write("ErrorAjax");
            }
        }
    }
}