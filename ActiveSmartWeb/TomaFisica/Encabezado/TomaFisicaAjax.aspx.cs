using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.TomaFisica.Encabezado
{
    public partial class TomaFisicaAjax : System.Web.UI.Page
    {
        DTomaFisica _dTomaFisica;
        NTomaFisica _nTomaFisica;
        protected void Page_Load(object sender, EventArgs e)
        {
            _dTomaFisica = new DTomaFisica();
            _nTomaFisica = new NTomaFisica(_dTomaFisica);
            try
            {
                switch (Request.Form["option"])
                {
                    case "InsertarTomaFisica":
                        var Nombre = Request.Form["Nombre"];
                        var Descripcion = Request.Form["Descripcion"];
                        var FechaIncial = Convert.ToDateTime(Request.Form["FechaInicial"]);
                        var FechaFinal = Convert.ToDateTime(Request.Form["FechaFinal"]);
                        var IdPerfilActive = Convert.ToInt32(Request.Form["IdPerfilActive"]);
                        var IdUsuarioAsignado = Convert.ToInt32(Request.Form["IdUsuarioAsignado"]);
                        var IdCategoriaActivo = Convert.ToInt32(Request.Form["IdCategoriaActivo"]);
                        var IdUbicacionA = Convert.ToInt32(Request.Form["IdUbicacionA"]);
                        var Resultado = _nTomaFisica.InsertarTomaFisica(Nombre, Descripcion, FechaIncial, FechaFinal, IdCategoriaActivo, IdPerfilActive , IdUsuarioAsignado , IdUbicacionA );

                        Response.Write(Resultado);
                        break;
                    case "ActualizarTomaFisica":
                        var IdTomaFisica = Convert.ToInt32(Request.Form["idTomaFisica"]);
                        var NombreToma = Request.Form["NombreToma"];
                        var DescToma = Request.Form["DescripcionToma"];
                        var FechaInicialToma = Convert.ToDateTime(Request.Form["FechaInicialToma"]);
                        var FechaFinalToma = Convert.ToDateTime(Request.Form["FechaFinalToma"]);
                        var Categoria = Convert.ToInt32(Request.Form["IdCategoriaToma"]);
                        var UsuarioAsignado = Convert.ToInt32(Request.Form["UsuarioAsignado"]);
                        var Ubicacion = Convert.ToInt32(Request.Form["Ubicacion"]);
                        var ResultadoToma = _nTomaFisica.ActualizarTomaFisica(IdTomaFisica, NombreToma, DescToma, FechaInicialToma, FechaFinalToma, Categoria, UsuarioAsignado, Ubicacion);

                        Response.Write(ResultadoToma);
                        break;
                    case "ConsultaTomaFisica":
                        var fechaInicial = Convert.ToDateTime(Request.Form["FechaInicial"]);
                        var fechaFinal = Convert.ToDateTime(Request.Form["FechaFinal"]);
                        var idPerfilActive = Convert.ToInt32(Request.Form["IdPerfilActive"]);
                        var TomasFisicasFijos = _nTomaFisica.ConsultarTomaFisica(idPerfilActive, fechaInicial, fechaFinal);
                        Response.Write(JsonConvert.SerializeObject(TomasFisicasFijos, Formatting.Indented));
                        break;
                    case "ConsultaTodosTomaFisica":
                        var idPerfil = Convert.ToInt32(Request.Form["IdPerfilActive"]);
                        var TomasFisicas= _nTomaFisica.ConsultarTodosTomaFisica(idPerfil);
                        Response.Write(JsonConvert.SerializeObject(TomasFisicas, Formatting.Indented));
                        break;

                    case "ConsultaIDTomaFisica":
                        var IdTomaFisicaI = Convert.ToInt32(Request.Form["IdTomaFisicaI"]);
                        var ConsTomaFisicaID = _nTomaFisica.ConsultaIDEditarTomaFisica(IdTomaFisicaI);
                        Response.Write(JsonConvert.SerializeObject(ConsTomaFisicaID, Formatting.Indented));
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