using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Ubicaciones.UbicacionA
{
    public partial class UbicacionAjax : System.Web.UI.Page
    {
        DUbicacion _dUbicacion;
        NUbicacionA _nUbicacionA;
        protected void Page_Load(object sender, EventArgs e)
        {
            _dUbicacion = new DUbicacion();
            _nUbicacionA = new NUbicacionA(_dUbicacion);
            try
            {
                switch (Request.Form["option"])
                {

                    case "InsertarUbicacion":
                        var Nombre = Request.Form["Nombre"];
                        var Descripcion = Request.Form["Descripcion"];
                        var IdPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var resultadoInsercion = _nUbicacionA.InsertarUbicacion(Nombre, Descripcion, IdPerfilEmpresa);
                        Response.Write(resultadoInsercion);
                        break;

                    case "ConsultarUbicaciones":
                        var idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var ubicaciones = _nUbicacionA.ConsultarUbicaciones(idPerfilEmpresa);
                        Response.Write(JsonConvert.SerializeObject(ubicaciones, Formatting.Indented));
                        break;

                    case "ActualizaUbicacion":
                        var idUbicacionA = Convert.ToInt32(Request.Form["IdUbicacionA"]);
                        var nombre = Request.Form["Nombre"];
                        var descripcion = Request.Form["Descripcion"];
                        var resultadoActualizar = _nUbicacionA.ActualizaUbicacion(idUbicacionA, nombre, descripcion);
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