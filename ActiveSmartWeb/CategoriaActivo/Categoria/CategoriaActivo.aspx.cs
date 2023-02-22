using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.CategoriaActivo.Categoria
{
    public partial class CategoriaActivo : System.Web.UI.Page
    {
        DCategoriaActivo _dCategoriaActivo;
        NCategoriaActivo _nCategoriaActivo;
        protected void Page_Load(object sender, EventArgs e)
        {
            _dCategoriaActivo = new DCategoriaActivo();
            _nCategoriaActivo = new NCategoriaActivo(_dCategoriaActivo);
            try
            {
                switch (Request.Form["option"])
                {
                    case "ConsultaCategoriaActivo":
                        var resultadoCategoria = _nCategoriaActivo.ConsultaCategoriaActivos();
                        Response.Write(JsonConvert.SerializeObject(resultadoCategoria, Formatting.Indented));
                        break;
                    case "ConsultaDescCategoriaX":
                        var IdCat = Convert.ToInt32(Request.Form["IdCategoria"]);
                        var resultadoCategoriaX = _nCategoriaActivo.ConsultaDescCategoriaX(IdCat);
                        Response.Write(resultadoCategoriaX);
                        break;
                }

            }catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }

        }
    }
}