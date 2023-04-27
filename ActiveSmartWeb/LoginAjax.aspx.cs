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
        private string validarSubscripcion(Nlogin _nlogin, string correo)
        {

            return _nlogin.obtenerSubscripcion(correo);
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

                        if(Resultado == "Validar Subscripcion")
                        {
                            string subscripcion = validarSubscripcion(_nlogin, Request.Form["Email"].ToString());
                            Resultado = subscripcion == ""?"No Tiene":subscripcion;
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

                }
            } 
            catch
            {
                Response.Write("ErrorAjax");
            }
        }
    }
}