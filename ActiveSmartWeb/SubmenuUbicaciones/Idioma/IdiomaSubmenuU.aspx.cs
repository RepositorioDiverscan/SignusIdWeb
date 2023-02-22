using ActiveSmartWeb.SubmenuUbicaciones.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.SubmenuUbicaciones.Idioma
{
    public partial class IdiomaSubmenuU : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaGeneralSubmenuU Idioma = new IdiomaGeneralSubmenuU();
            try
            {
                switch (Request.Form["IdiomaSubmenuUbi"])
                {
                    case "ES":
                        Idioma.Titulo = IdiomaEspanolSubmenuU._titulo;
                        Idioma.UbicacionA = IdiomaEspanolSubmenuU._ubicacionA;
                        Idioma.UbicacionB = IdiomaEspanolSubmenuU._ubicacionB;
                        Idioma.UbicacionC = IdiomaEspanolSubmenuU._ubicacionC;
                        Idioma.UbicacionD = IdiomaEspanolSubmenuU._ubicacionD;
                        Idioma.MsjbtnTienda = IdiomaEspanolSubmenuU._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaEspanolSubmenuU._msjTienda;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    case "EN":
                        Idioma.Titulo = IdiomaInglesSubmenuU._titulo;
                        Idioma.UbicacionA = IdiomaInglesSubmenuU._ubicacionA;
                        Idioma.UbicacionB = IdiomaInglesSubmenuU._ubicacionB;
                        Idioma.UbicacionC = IdiomaInglesSubmenuU._ubicacionC;
                        Idioma.UbicacionD = IdiomaInglesSubmenuU._ubicacionD;
                        Idioma.MsjbtnTienda = IdiomaInglesSubmenuU._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaInglesSubmenuU._msjTienda;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:
                        Idioma.Titulo = IdiomaEspanolSubmenuU._titulo;
                        Idioma.UbicacionA = IdiomaEspanolSubmenuU._ubicacionA;
                        Idioma.UbicacionB = IdiomaEspanolSubmenuU._ubicacionB;
                        Idioma.UbicacionC = IdiomaEspanolSubmenuU._ubicacionC;
                        Idioma.UbicacionD = IdiomaEspanolSubmenuU._ubicacionD;
                        Idioma.MsjbtnTienda = IdiomaEspanolSubmenuU._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaEspanolSubmenuU._msjTienda;
                        break;
                }
            }catch(Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
        }
    }
}