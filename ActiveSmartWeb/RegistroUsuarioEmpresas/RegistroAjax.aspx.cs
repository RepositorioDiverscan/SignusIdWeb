using ActiveSmartWeb.Contrasenna.CambioContrasena;
using ActiveSmartWeb.Login.Entidades;
using ActiveSmartWeb.Recursos.JSON;
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

  
    public partial class RegistroAjax : System.Web.UI.Page
    {

        NUsuarioEmpresa nUsuarioEmpresa = new NUsuarioEmpresa();
        NCambioPSW _nCambioPSW;

        protected void Page_Load(object sender, EventArgs e)
        {
            _nCambioPSW = new NCambioPSW();

            try
            {

                switch (Request.Form["option"])
                {

                    case "RegistroUsuariosEmpresas":

                        var UsuarioEmpresaJson = Request.Form["InfoUsuarioEmpresa"];

                        EUsuarioEmpresa eUsuarioEmpresa = JsonConvert.DeserializeObject<EUsuarioEmpresa>(UsuarioEmpresaJson);

                        var ResultadoInsert = nUsuarioEmpresa.IngresarUsuarioEmpresa(eUsuarioEmpresa);

                        Response.Write(ResultadoInsert);

                    break;

                    case "CargarIndustrias":

                         

                       var ResultadoIndustrias= nUsuarioEmpresa.CargarIndustrias();

                        Response.Write(JsonConvert.SerializeObject(ResultadoIndustrias, Formatting.Indented));
                        break;

                    case "CargarEmpresaTamano":



                        var ResultadoEmpresaTamano = nUsuarioEmpresa.CargarEmpresaTamano();

                        Response.Write(JsonConvert.SerializeObject(ResultadoEmpresaTamano, Formatting.Indented));
                        break;

                    case "ValidarPassword":
                        var cadena = Convert.ToString(Request.Form["passW"]);

                        var respuesta = _nCambioPSW.ValidaContrasena(cadena);

                        Response.Write(respuesta);
                        break;

                    case "ValidarCodigo":

                        var correo = Convert.ToString(Request.Form["Correo"]);
                        var codigo = Convert.ToString(Request.Form["Codigo"]);

                        var resp= nUsuarioEmpresa.ValidarCodigo(correo, codigo);

                        Response.Write(resp);
                        break;

                    case "NuevoCodigo":

                        var correo1 = Convert.ToString(Request.Form["Correo"]);

                        var resp1 = nUsuarioEmpresa.GenerarNuevoCodigo(correo1);
                        Response.Write(resp1);

                        break;
                }


            }catch (Exception ex)

            {


            }


            }
    }
}