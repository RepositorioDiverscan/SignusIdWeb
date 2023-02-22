using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using ActiveSmartWeb.UbicacionesC.UbicacionC;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.UbicacionesC
{
    public partial class UbicacionCAjax : System.Web.UI.Page
    {
        NUbicacionC nUbicacionC = new NUbicacionC();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Request.Form["option"])
                {
                    case "ConsultarUbicacionesA":
                        var idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresaU"]);
                        var listaUbisA = nUbicacionC.ConsultarUbicacionesA(idPerfilEmpresa);
                        Response.Write(JsonConvert.SerializeObject(listaUbisA, Formatting.Indented));
                        break;
                    case "ConsultarUbicacionesB":
                        idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresaU"]);
                        var idUbicacionA = Convert.ToInt32(Request.Form["IdUbicacionA"]);
                        var listaUbisb = nUbicacionC.ConsultarUbicacionesB(idPerfilEmpresa, idUbicacionA);
                        Response.Write(JsonConvert.SerializeObject(listaUbisb, Formatting.Indented));
                        break;

                    case "ConsultarUbicacionesC":
                        idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresaU"]);
                        var listaUbisC = nUbicacionC.ConsultarUbicacionesC(idPerfilEmpresa);
                        Response.Write(JsonConvert.SerializeObject(listaUbisC, Formatting.Indented));
                        break;

                    case "ConsultarUbicacionesXId":
                        var IdUbicacionB = Convert.ToInt32(Request.Form["IdUbicacionB"]);
                        var listaUbisCId = nUbicacionC.ConsultarUbicacionesXId(IdUbicacionB);
                        Response.Write(listaUbisCId);
                        break;

                    case "RegistrarUbicacionC":
                        IdUbicacionB = Convert.ToInt32(Request.Form["IdUbicacionB"]);
                        var Nombre = Request.Form["Nombre"];
                        var Descripcion = Request.Form["Descripcion"];
                        var IdPerfilEmpresa = Convert.ToInt32(Request.Form["IdPefil_Empresa"]);
                        var resultadoInsercion = nUbicacionC.InsertarUbicacion(Nombre, Descripcion, IdPerfilEmpresa, IdUbicacionB);
                        Response.Write(resultadoInsercion);
                        break;

                    case "ActualizaUbicacionC":
                        var IdUbicacionC = Convert.ToInt32(Request.Form["IdUbicacionC"]);
                        IdUbicacionB = Convert.ToInt32(Request.Form["IdUbicacionB"]);
                        Nombre = Request.Form["Nombre"];
                        Descripcion = Request.Form["Descripcion"];
                        resultadoInsercion = nUbicacionC.ActualizaUbicacion(IdUbicacionC, IdUbicacionB, Nombre, Descripcion);
                        Response.Write(resultadoInsercion);
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