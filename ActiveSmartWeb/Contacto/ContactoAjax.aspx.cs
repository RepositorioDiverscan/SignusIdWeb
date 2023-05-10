using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using ActiveSmartWeb.Utilities;

namespace ActiveSmartWeb.Contacto
{
    public partial class ContactoAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {

                switch (Request.Form["option"])
                {


                    case "EnviarCorreoContacto":

                        var Nombre = Request.Form["Nombre"];
                        var Apellido = Request.Form["Apellido"];
                        var Email = Request.Form["Correo"];
                        var Telefono = Request.Form["Telefono"];
                        var Mensaje = Request.Form["Mensaje"];
                        var Asunto = Request.Form["Asunto"];
                        var realizadoClientre = Correo.EnviarCorreoContactoCliente("csalazar.diverscan@gmail.com");
                        var realizado = Correo.EnviarCorreoContactoInformacion("csalazar.diverscan@gmail.com", Asunto, Nombre, Apellido, Email,Telefono,Mensaje);

                        Response.Write(realizado);

                        break;


                }


            }
            catch (Exception ex)

            {

                Response.Write(ex);

            }


        }

    }
}