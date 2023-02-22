using ActiveSmartWeb.ActualizacionActivos.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.ActualizacionActivos.Idioma
{
    public partial class IdiomaActualizaAct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaActualizGeneral Idioma = new IdiomaActualizGeneral();
            try
            {
                switch (Request.Form["IdiomaActualizaActivos"]){
                    case "ES":
                        Idioma.Titulo = IdiomaActualizEspannol._titulo;
                        Idioma.SelectAct = IdiomaActualizEspannol._selectAct;
                        Idioma.NumActivo = IdiomaActualizEspannol._numActivo;
                        Idioma.PlacaActivo = IdiomaActualizEspannol._placaActivo;
                        Idioma.Descripcion = IdiomaActualizEspannol._descripcion;
                        Idioma.IdPerfilEmpresa = IdiomaActualizEspannol._idPerfilEmpresa;
                        Idioma.IdEstadoActivo = IdiomaActualizEspannol._idEstadoActivo;
                        Idioma.IdCategoria = IdiomaActualizEspannol._idCategoria;
                        Idioma.IdUbicacionA = IdiomaActualizEspannol._idUbicacionA;
                        Idioma.Marca = IdiomaActualizEspannol._marca;
                        Idioma.Modelo = IdiomaActualizEspannol._modelo;
                        Idioma.Serie = IdiomaActualizEspannol._serie;
                        Idioma.Observacion = IdiomaActualizEspannol._observacion;
                        Idioma.FechaBaja = IdiomaActualizEspannol._fechaBaja;
                        Idioma.Numerotag = IdiomaActualizEspannol._numerotag;
                        Idioma.FechaRegistro = IdiomaActualizEspannol._fechaRegistro;
                        Idioma.SelectFiltro = IdiomaActualizEspannol._selecFiltro;
                        Idioma.Selectmsj = IdiomaActualizEspannol._selectmsj;
                        Idioma.IngrErrDescripcion = IdiomaActualizEspannol._ingrErrDescripcion;
                        Idioma.IngrErrNumPlaca = IdiomaActualizEspannol._ingErrNumPlaca;
                        Idioma.IngrErrNumActivo = IdiomaActualizEspannol._ingErrNumActivo;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;

                    case "EN":
                        Idioma.Titulo = IdiomaActualizIngles._titulo;
                        Idioma.SelectAct = IdiomaActualizIngles._selectAct;
                        Idioma.NumActivo = IdiomaActualizIngles._numActivo;
                        Idioma.PlacaActivo = IdiomaActualizIngles._placaActivo;
                        Idioma.Descripcion = IdiomaActualizIngles._descripcion;
                        Idioma.IdPerfilEmpresa = IdiomaActualizIngles._idPerfilEmpresa;
                        Idioma.IdEstadoActivo = IdiomaActualizIngles._idEstadoActivo;
                        Idioma.IdCategoria = IdiomaActualizIngles._idCategoria;
                        Idioma.IdUbicacionA = IdiomaActualizIngles._idUbicacionA;
                        Idioma.Marca = IdiomaActualizIngles._marca;
                        Idioma.Modelo = IdiomaActualizIngles._modelo;
                        Idioma.Serie = IdiomaActualizIngles._serie;
                        Idioma.Observacion = IdiomaActualizIngles._observacion;
                        Idioma.FechaBaja = IdiomaActualizIngles._fechaBaja;
                        Idioma.Numerotag = IdiomaActualizIngles._numerotag;
                        Idioma.FechaRegistro = IdiomaActualizIngles._fechaRegistro;
                        Idioma.SelectFiltro = IdiomaActualizIngles._selecFiltro;
                        Idioma.Selectmsj = IdiomaActualizIngles._selectmsj;
                        Idioma.IngrErrDescripcion = IdiomaActualizIngles._ingrErrDescripcion;
                        Idioma.IngrErrNumActivo = IdiomaActualizIngles._ingErrNumActivo;
                        Idioma.IngrErrNumPlaca = IdiomaActualizIngles._ingErrNumPlaca;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:
                        Idioma.Titulo = IdiomaActualizEspannol._titulo;
                        Idioma.SelectAct = IdiomaActualizEspannol._selectAct;
                        Idioma.NumActivo = IdiomaActualizEspannol._numActivo;
                        Idioma.PlacaActivo = IdiomaActualizEspannol._placaActivo;
                        Idioma.Descripcion = IdiomaActualizEspannol._descripcion;
                        Idioma.IdPerfilEmpresa = IdiomaActualizEspannol._idPerfilEmpresa;
                        Idioma.IdEstadoActivo = IdiomaActualizEspannol._idEstadoActivo;
                        Idioma.IdCategoria = IdiomaActualizEspannol._idCategoria;
                        Idioma.IdUbicacionA = IdiomaActualizEspannol._idUbicacionA;
                        Idioma.Marca = IdiomaActualizEspannol._marca;
                        Idioma.Modelo = IdiomaActualizEspannol._modelo;
                        Idioma.Serie = IdiomaActualizEspannol._serie;
                        Idioma.Observacion = IdiomaActualizEspannol._observacion;
                        Idioma.FechaBaja = IdiomaActualizEspannol._fechaBaja;
                        Idioma.Numerotag = IdiomaActualizEspannol._numerotag;
                        Idioma.FechaRegistro = IdiomaActualizEspannol._fechaRegistro;
                        Idioma.SelectFiltro = IdiomaActualizEspannol._selecFiltro;
                        Idioma.Selectmsj = IdiomaActualizEspannol._selectmsj;
                        Idioma.IngrErrDescripcion = IdiomaActualizEspannol._ingrErrDescripcion;
                        Idioma.IngrErrNumPlaca = IdiomaActualizEspannol._ingErrNumPlaca;
                        Idioma.IngrErrNumActivo = IdiomaActualizEspannol._ingErrNumActivo;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
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