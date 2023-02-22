using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.EstadoActivoFijo.EstadoActivo
{
    public partial class EstadoActivo : System.Web.UI.Page
    {
        DEstadoActivo _dEstadoActivo;
        NEstadoActivo _nEstadoActivo;
        protected void Page_Load(object sender, EventArgs e)
        {
            _dEstadoActivo = new DEstadoActivo();
            _nEstadoActivo = new NEstadoActivo(_dEstadoActivo);
            try
            {
                switch (Request.Form["option"])
                {
                    case "ConsultaEstadoActivo":
                        
                        var resultadoEstado = _nEstadoActivo.ConsultaEstadoActivo();
                        Response.Write(JsonConvert.SerializeObject(resultadoEstado, Formatting.Indented));
                        break;
                    case "ConsultaDescEstadoX":
                        var IdEstado = Convert.ToInt32(Request.Form["IdEstado"]);
                        var resultadoEstadoX = _nEstadoActivo.ConsultaDescEstadoX(IdEstado);
                        Response.Write(resultadoEstadoX);
                        break;
                }
            }
            catch(Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
        }
    }
}