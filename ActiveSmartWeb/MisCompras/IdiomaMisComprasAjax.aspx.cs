using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.MisCompras.IdiomaMisCompras;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;

namespace ActiveSmartWeb.MisCompras
{
    public partial class IdiomaMisComprasAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EIdiomaMiscomprasGeneral eIdioma = new EIdiomaMiscomprasGeneral();

            try
            {

                switch (Request.Form["idioma"])
                {

                    //Opcion del switch para cargar el idioma en español.
                    case "ES":

                        eIdioma.Titulo = EIdiomaMisComprasEspañol.Titulo;
                        eIdioma.Titulo1TablaInfo = EIdiomaMisComprasEspañol.Titulo1TablaInfo;
                        eIdioma.Titulo2TablaInfo = EIdiomaMisComprasEspañol.Titulo2TablaInfo;
                        eIdioma.BotonRenovar = EIdiomaMisComprasEspañol.BotonRenovar;
                        eIdioma.TituloAdicionales = EIdiomaMisComprasEspañol.TituloAdicionales;
                        eIdioma.Titulo1TablaAdicionales = EIdiomaMisComprasEspañol.Titulo1TablaAdicionales;
                        eIdioma.Titulo2TablaAdicionales = EIdiomaMisComprasEspañol.Titulo2TablaAdicionales;
                        eIdioma.Titulo3TablaAdicionales = EIdiomaMisComprasEspañol.Titulo3TablaAdicionales;
                        eIdioma.TextoLeyenda = EIdiomaMisComprasEspañol.TextoLeyenda;
                        eIdioma.BotonIrTienda = EIdiomaMisComprasEspañol.BotonIrTienda;
                        eIdioma.Msj1 = EIdiomaMisComprasEspañol.Msj1;
                        eIdioma.Msj2 = EIdiomaMisComprasEspañol.Msj2;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));

                        break;

                    //Opcion del switch para cargar el idioma en ingles.
                    case "EN":

                        eIdioma.Titulo = EIdiomaMisComprasIngles.Titulo;
                        eIdioma.Titulo1TablaInfo = EIdiomaMisComprasIngles.Titulo1TablaInfo;
                        eIdioma.Titulo2TablaInfo = EIdiomaMisComprasIngles.Titulo2TablaInfo;
                        eIdioma.BotonRenovar = EIdiomaMisComprasIngles.BotonRenovar;
                        eIdioma.TituloAdicionales = EIdiomaMisComprasIngles.TituloAdicionales;
                        eIdioma.Titulo1TablaAdicionales = EIdiomaMisComprasIngles.Titulo1TablaAdicionales;
                        eIdioma.Titulo2TablaAdicionales = EIdiomaMisComprasIngles.Titulo2TablaAdicionales;
                        eIdioma.Titulo3TablaAdicionales = EIdiomaMisComprasIngles.Titulo3TablaAdicionales;
                        eIdioma.TextoLeyenda = EIdiomaMisComprasIngles.TextoLeyenda;
                        eIdioma.BotonIrTienda = EIdiomaMisComprasIngles.BotonIrTienda;
                        eIdioma.Msj1 = EIdiomaMisComprasIngles.Msj1;
                        eIdioma.Msj2 = EIdiomaMisComprasIngles.Msj2;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;

                    default:

                        eIdioma.Titulo = EIdiomaMisComprasEspañol.Titulo;
                        eIdioma.Titulo1TablaInfo = EIdiomaMisComprasEspañol.Titulo1TablaInfo;
                        eIdioma.Titulo2TablaInfo = EIdiomaMisComprasEspañol.Titulo2TablaInfo;
                        eIdioma.BotonRenovar = EIdiomaMisComprasEspañol.BotonRenovar;
                        eIdioma.TituloAdicionales = EIdiomaMisComprasEspañol.TituloAdicionales;
                        eIdioma.Titulo1TablaAdicionales = EIdiomaMisComprasEspañol.Titulo1TablaAdicionales;
                        eIdioma.Titulo2TablaAdicionales = EIdiomaMisComprasEspañol.Titulo2TablaAdicionales;
                        eIdioma.Titulo3TablaAdicionales = EIdiomaMisComprasEspañol.Titulo3TablaAdicionales;
                        eIdioma.TextoLeyenda = EIdiomaMisComprasEspañol.TextoLeyenda;
                        eIdioma.BotonIrTienda = EIdiomaMisComprasEspañol.BotonIrTienda;
                        eIdioma.Msj1 = EIdiomaMisComprasEspañol.Msj1;
                        eIdioma.Msj2 = EIdiomaMisComprasEspañol.Msj2;

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