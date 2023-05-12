using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using ActiveSmartWeb.Utilities;
using ActiveSmartWeb.Contacto.Entidades;

namespace ActiveSmartWeb.Contacto
{
    public partial class ContactoAjax : System.Web.UI.Page
    {

        NContacto _nContacto = new NContacto();

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

                        EContacto contacto = new EContacto();

                        contacto.Asunto = Asunto;
                        contacto.Nombre = Nombre;
                        contacto.Apellido = Apellido;
                        contacto.Correo = Email;
                        contacto.Telefono = Telefono;
                        contacto.Mensaje = Mensaje;

                        var resultado = _nContacto.InsertarContacto(contacto);
                        var realizado = -1;

                        if (resultado == "Ok")
                        {
                            realizado = Correo.EnviarCorreoContactoInformacion(Asunto, Nombre, Apellido, Email, Telefono, Mensaje);

                            if (realizado == 0)
                            {
                                Correo.EnviarCorreoContactoCliente(Email);
                            }
                        }

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