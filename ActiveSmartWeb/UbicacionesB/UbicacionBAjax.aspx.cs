using System;
using ActiveSmartWeb.UbicacionesB.UbicacionB;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using ActiveSmartWeb.Utilities;

namespace ActiveSmartWeb.UbicacionesB
{
    public partial class UbicacionBAjax : System.Web.UI.Page
    {
        NUbicacionB nUbicacionB = new NUbicacionB();
         
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                var IdUbicacionA = Convert.ToInt32(Request.Form["IdUbicacionA"]);
                var Nombre = Request.Form["Nombre"];
                var Descripcion = Request.Form["Descripcion"];
                var IdPerfilEmpresa = Convert.ToInt32(Request.Form["IdPefil_Empresa"]);
                switch (Request.Form["option"])
                {
                    case "InsertarUbicacionB":

                        IdUbicacionA = Convert.ToInt32(Request.Form["IdUbicacionA"]);
                        Nombre = Request.Form["Nombre"];
                        Descripcion = Request.Form["Descripcion"];
                        IdPerfilEmpresa = Convert.ToInt32(Request.Form["IdPefil_Empresa"]);
                        var resultadoInsercion = nUbicacionB.InsertarUbicacion(Nombre, Descripcion, IdPerfilEmpresa, IdUbicacionA);
                        Response.Write(resultadoInsercion);
                        break;

                    case "ConsultarUbicacionesA": // carga el combobox de esa Ubicacion.
                        var idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresaU"]);
                        var listaUbisA = nUbicacionB.ConsultarUbicacionesA(idPerfilEmpresa);
                        Response.Write(JsonConvert.SerializeObject(listaUbisA, Formatting.Indented));
                        break;


                    case "ConsultarUbicacionesB": //cargarTablade la UbicacionB
                        idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresaU"]);
                        var listaUbisB = nUbicacionB.ConsultarUbicacionesB(idPerfilEmpresa);
                        Response.Write(JsonConvert.SerializeObject(listaUbisB, Formatting.Indented));
                        break;

                    case "ActualizaUbicacionB": //  proceso para editar registro.
                        var IdUbicacionB = Convert.ToInt32(Request.Form["IdUbicacionB"]);
                        IdUbicacionA = Convert.ToInt32(Request.Form["IdUbicacionA"]);
                        Nombre = Request.Form["Nombre"];
                        Descripcion = Request.Form["Descripcion"];
                        var resultadoActualizar = nUbicacionB.ActualizaUbicacion(IdUbicacionB, IdUbicacionA, Nombre, Descripcion);
                        Response.Write(resultadoActualizar);
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
