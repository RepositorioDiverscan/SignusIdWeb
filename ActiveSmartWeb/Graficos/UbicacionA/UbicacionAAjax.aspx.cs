using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Graficos.UbicacionA
{
    public partial class UbicacionAAjax : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
            NUbicacionA _nUbicacionA = new NUbicacionA();
            try
            {
                switch (Request.Form["option"])
                {
                    case "ConsultarCantidad_ActivosUbicacionA":
                  
                        var ubicaciones = _nUbicacionA.ConsultarCantidad_ActivosUbicaciones();
                        Response.Write(JsonConvert.SerializeObject(ubicaciones, Formatting.Indented));
                        break;

                    case "ConsultarCantidad_ActivosUbicacionB":

                        var id = Convert.ToInt32(Request.Form["id"]);
                        var ubicacionB= _nUbicacionA.ConsultarCantidad_ActivosUbicacionB(id);
                        Response.Write(JsonConvert.SerializeObject(ubicacionB, Formatting.Indented));
                        break;

                    case "ConsultarCantidad_ActivosUbicacionC":

                        var idb= Convert.ToInt32(Request.Form["id"]);
                        var ubicacionC = _nUbicacionA.ConsultarCantidad_ActivosUbicacionC(idb);
                        Response.Write(JsonConvert.SerializeObject(ubicacionC, Formatting.Indented));
                        break;

                    case "ConsultarCantidad_ActivosUbicacionD":

                        var idd = Convert.ToInt32(Request.Form["id"]);
                        var ubicacionD = _nUbicacionA.ConsultarCantidad_ActivosUbicacionD(idd);
                        Response.Write(JsonConvert.SerializeObject(ubicacionD, Formatting.Indented));
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