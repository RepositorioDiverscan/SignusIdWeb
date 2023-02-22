using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.ConfiguracionPlanes.IdiomaConfiguracion;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;

namespace ActiveSmartWeb.ConfiguracionPlanes
{
    public partial class IdiomaConfiguracionAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EIdiomaConfiguracionGeneral eIdioma = new EIdiomaConfiguracionGeneral();

            try
            {

                switch (Request.Form["idioma"])
                {

                    //Opcion del switch para cargar el idioma en español.
                    case "ES":

                        eIdioma.Titulo = EIdiomaConfiguracionEspañol.Titulo;
                        eIdioma.TituloPlanDisponible = EIdiomaConfiguracionEspañol.TituloPlanDisponible;
                        eIdioma.TextoLeyenda = EIdiomaConfiguracionEspañol.TextoLeyenda;
                        eIdioma.BotonIrTienda = EIdiomaConfiguracionEspañol.BotonIrTienda;
                        eIdioma.TablaCampo1 = EIdiomaConfiguracionEspañol.TablaCampo1;
                        eIdioma.TablaCampo2 = EIdiomaConfiguracionEspañol.TablaCampo2;
                        eIdioma.TablaCampo3 = EIdiomaConfiguracionEspañol.TablaCampo3;
                        eIdioma.TablaCampo4 = EIdiomaConfiguracionEspañol.TablaCampo4;
                        eIdioma.CampoSelect = EIdiomaConfiguracionEspañol.CampoSelect;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));

                        break;

                    //Opcion del switch para cargar el idioma en ingles.
                    case "EN":

                        eIdioma.Titulo = EIdiomaConfiguracionIngles.Titulo;
                        eIdioma.TituloPlanDisponible = EIdiomaConfiguracionIngles.TituloPlanDisponible;
                        eIdioma.TextoLeyenda = EIdiomaConfiguracionIngles.TextoLeyenda;
                        eIdioma.BotonIrTienda = EIdiomaConfiguracionIngles.BotonIrTienda;
                        eIdioma.TablaCampo1 = EIdiomaConfiguracionIngles.TablaCampo1;
                        eIdioma.TablaCampo2 = EIdiomaConfiguracionIngles.TablaCampo2;
                        eIdioma.TablaCampo3 = EIdiomaConfiguracionIngles.TablaCampo3;
                        eIdioma.TablaCampo4 = EIdiomaConfiguracionIngles.TablaCampo4;
                        eIdioma.CampoSelect = EIdiomaConfiguracionIngles.CampoSelect;


                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;

                    default:

                        eIdioma.Titulo = EIdiomaConfiguracionEspañol.Titulo;
                        eIdioma.TituloPlanDisponible = EIdiomaConfiguracionEspañol.TituloPlanDisponible;
                        eIdioma.TextoLeyenda = EIdiomaConfiguracionEspañol.TextoLeyenda;
                        eIdioma.BotonIrTienda = EIdiomaConfiguracionEspañol.BotonIrTienda;
                        eIdioma.TablaCampo1 = EIdiomaConfiguracionEspañol.TablaCampo1;
                        eIdioma.TablaCampo2 = EIdiomaConfiguracionEspañol.TablaCampo2;
                        eIdioma.TablaCampo3 = EIdiomaConfiguracionEspañol.TablaCampo3;
                        eIdioma.TablaCampo4 = EIdiomaConfiguracionEspañol.TablaCampo4;
                        eIdioma.CampoSelect = EIdiomaConfiguracionEspañol.CampoSelect;

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