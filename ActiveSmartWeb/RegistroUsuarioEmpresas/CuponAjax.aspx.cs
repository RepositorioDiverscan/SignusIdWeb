using ActiveSmartWeb.Contrasenna.CambioContrasena;
using ActiveSmartWeb.Login.Entidades;
using ActiveSmartWeb.Recursos.JSON;
using ActiveSmartWeb.RegistroUsuarioEmpresas.Cupon;
using ActiveSmartWeb.RegistroUsuarioEmpresas.Registro;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas
{
    public partial class CuponAjax : System.Web.UI.Page
    {
        NCupon ncupon = new NCupon();
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Request.Form["option"])
            {
                case "VerificarCodigo":
                    var codigo =  Request.Form["codigo"];
                    var respuesta = ncupon.VerificarCodigo(codigo);
                    Response.Write(respuesta);
                    break;
                    

            }
        }
    }
}