using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.MisCompras.Compras;
using Newtonsoft.Json;

namespace ActiveSmartWeb.MisCompras
{
    public partial class MisComprasAjax : System.Web.UI.Page
    {

        NMisCompras nMisCompras = new NMisCompras();

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

                switch (Request.Form["option"])
                {

                    //Opcion del switch para cargar las configuraciones de los planes.
                    case "CargarFechaVencimiento":

                        var IdEmpresa = Convert.ToInt32(Request.Form["idEmpresa"]);

                        var eConfiguracionesPlan = nMisCompras.CargarFechaVencimiento(IdEmpresa);

                        Response.Write(JsonConvert.SerializeObject(eConfiguracionesPlan, Formatting.Indented));

                        break;

                    //Opcion del switch para cargar las configuraciones por plan.
                    case "CargarAdicionalesMisCompras":

                        var IdEmpresamiscompras = Convert.ToInt32(Request.Form["idEmpresa"]);

                        var eConfiguracionesPorPlan = nMisCompras.CargarAdicionalesMisCompras(IdEmpresamiscompras);

                        Response.Write(JsonConvert.SerializeObject(eConfiguracionesPorPlan, Formatting.Indented));

                        break;


                }


            }
            catch (Exception ex)

            {


            }

        }
    }
}