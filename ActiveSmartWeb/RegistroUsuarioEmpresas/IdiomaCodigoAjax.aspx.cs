using ActiveSmartWeb.RegistroUsuarioEmpresas.Codigo;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas
{
    public partial class IdiomaCodigoAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaCodigoGeneral eIdioma = new EIdiomaCodigoGeneral();

            try
            {
                switch (Request.Form["idi"])
                {
                    case "ES":

                        eIdioma.Bienvenido =   EIdiomaCodigoEspanol._bienvenido;
                        eIdioma.ParrafoCodigo1 =    EIdiomaCodigoEspanol._parrafoCodigo1;
                        eIdioma.ParrafoCodigo2 = EIdiomaCodigoEspanol._parrafoCodigo2;
                        eIdioma.CodigoVerificacion =  EIdiomaCodigoEspanol._codigoVerificacion;
                        eIdioma.IngreseCodigo =    EIdiomaCodigoEspanol._ingreseCodigo;
                        eIdioma.GenerarCodigo =     EIdiomaCodigoEspanol._generarCodigo;
                        eIdioma.Aceptar =  EIdiomaCodigoEspanol._aceptar;
                    
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;

                    case "EN":

                        eIdioma.Bienvenido = EIdiomaCodigoIngles._bienvenido;
                        eIdioma.ParrafoCodigo1 = EIdiomaCodigoIngles._parrafoCodigo1;
                        eIdioma.ParrafoCodigo2 = EIdiomaCodigoIngles._parrafoCodigo2;
                        eIdioma.CodigoVerificacion = EIdiomaCodigoIngles._codigoVerificacion;
                        eIdioma.IngreseCodigo = EIdiomaCodigoIngles._ingreseCodigo;
                        eIdioma.GenerarCodigo = EIdiomaCodigoIngles._generarCodigo;
                        eIdioma.Aceptar = EIdiomaCodigoIngles._aceptar;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;


                    default:

                        eIdioma.Bienvenido = EIdiomaCodigoEspanol._bienvenido;
                        eIdioma.ParrafoCodigo1 = EIdiomaCodigoEspanol._parrafoCodigo1;
                        eIdioma.ParrafoCodigo2 = EIdiomaCodigoEspanol._parrafoCodigo2;
                        eIdioma.CodigoVerificacion = EIdiomaCodigoEspanol._codigoVerificacion;
                        eIdioma.IngreseCodigo = EIdiomaCodigoEspanol._ingreseCodigo;
                        eIdioma.GenerarCodigo = EIdiomaCodigoEspanol._generarCodigo;
                        eIdioma.Aceptar = EIdiomaCodigoEspanol._aceptar;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));

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