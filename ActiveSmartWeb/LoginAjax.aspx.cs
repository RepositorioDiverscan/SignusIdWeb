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
        protected void Page_Load(object sender, EventArgs e)
        {
            NCambioPSW _nPassword = new NCambioPSW();
            Nlogin _nlogin = new Nlogin();
            MD5 md5Hash = MD5.Create(); 

            try {
                switch (Request.Form["opciones"])
                {
                    case "ValidUsers1":

                        var data = _nlogin.ValidUser(
                                Request.Form["Email"].ToString(),
                                Encrypt.EncriptarSHA3_512(Request.Form["Password"].ToString())
                            );

                        string res = _nlogin.ValidadInicioSesion(Request.Form["Email"].ToString(), Encrypt.EncriptarSHA3_512(Request.Form["Password"].ToString()));


                        if (res != "EXITO")
                        {
                            Response.Write(res);
                            break;
                        } else
                        if(data.Count == 0)
                        {
                            Response.Write("USAURIO NO VALIDO, POR FAVOR INTENTELO NUEVAMENTE");
                            break;
                        }
                        
                            Response.Write(JsonConvert.SerializeObject(data, Formatting.Indented));
                            break;


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

                       

                        /* case "ValidaLogin":
                             var correo = Request.Form["Email"].ToString();
                             string res = _nlogin.ValidadInicioSesion(correo);
                             Response.Write(JsonConvert.SerializeObject(res, Formatting.Indented));

                             break;*/

                }
            } 
            catch
            {
                Response.Write("ErrorAjax");
            }
        }
    }
}