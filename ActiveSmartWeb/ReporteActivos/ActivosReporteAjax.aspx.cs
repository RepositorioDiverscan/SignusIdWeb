using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.ReporteActivos.ReporteActivos;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System.IO;
using ActiveSmartWeb.ReporteActivos;
using ActiveSmartWeb.ReporteActivos.Idioma;
using OfficeOpenXml;

namespace ActiveSmartWeb.ReporteActivos
{
    public partial class ActivosReporteAjax : System.Web.UI.Page
    {
        DReporteActivos _dReporteAct;
        NReporteActivos _nReporteAct;

        private List<EReporteActivos> _activos
        {
            get
            {
                var data = Session["activos"] as List<EReporteActivos>;
                if (data == null)
                {
                    data = new List<EReporteActivos>();
                    Session["activos"] = data;
                }
                return data;
            }
            set
            {
                Session["activos"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _dReporteAct = new DReporteActivos();
            _nReporteAct = new NReporteActivos(_dReporteAct);
            try
            {
                switch (Request.Form["option"])
                {
                    case "ObtenerReportePorNumAct":
                        var numActivo = Convert.ToString(Request.Form["NumeroActivo"]);
                        var idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var reporte = _nReporteAct.ObtenerReporteActPorNumActivo(numActivo, idPerfilEmpresa);
                        _activos = reporte;
                        Response.Write(JsonConvert.SerializeObject(reporte, Formatting.Indented));
                        break;
                    case "ObtenerReportePorNumPlaca":
                        var numPlaca = Convert.ToString(Request.Form["PlacaActivo"]);
                        var idPerfilEmpresaplac = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);

                        var reporteAct = _nReporteAct.ObtenerReporteActPorNumPlaca(numPlaca, idPerfilEmpresaplac);
                        _activos = reporteAct;
                        Response.Write(JsonConvert.SerializeObject(reporteAct, Formatting.Indented));
                        break;
                    case "ObtenerReportePorDescrip":
                        var descripcion = Convert.ToString(Request.Form["DescripcionActivo"]);
                        var idPerfilEmpresadesc = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);

                        var reporteActivos = _nReporteAct.ObtenerReporteActPorDescripcion(descripcion, idPerfilEmpresadesc);
                        _activos = reporteActivos;
                        Response.Write(JsonConvert.SerializeObject(reporteActivos, Formatting.Indented));
                        break;

                    case "ObtenerReporteActivo":
                        var empresa = Convert.ToInt32(Request.Form["idPerfilEmpresa"]);

                        var re = _nReporteAct.ObtenerReporteActivos(empresa);
                        _activos = re;
                        Response.Write(JsonConvert.SerializeObject(re, Formatting.Indented));
                        break;

                    case "Exportar":
                        var activosJson = Request.Form["Lista"];
                        var IdEmpresa = Convert.ToInt32(Request.Form["PerfilEmpresa"]);
                        List<EReporteActivos> ListaActivos = JsonConvert.DeserializeObject<List<EReporteActivos>>(activosJson);
                        var base64Excel = obtenerBase64Excel(IdEmpresa, ListaActivos);
                        Response.Write(base64Excel);
                        break;
                }
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
        }
        private string obtenerBase64Excel(int idPerfilEmpresa,List<EReporteActivos> ListaActivos)
        {

            DReporteActivos DreproteActivos= new DReporteActivos();
            NReporteActivos nReporteActivos= new NReporteActivos(DreproteActivos);

            var activos = nReporteActivos.ObtenerReporteActivos(idPerfilEmpresa);
            IdiomaGeneralReporteA idioma = obtenerHeadersPorIdioma();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(EReporteActivos));
            PropertyDescriptor[] propertiesSelected = new PropertyDescriptor[8];
            propertiesSelected[0] = properties.Find("NumActivo", false);
            propertiesSelected[1] = properties.Find("NumPlaca", false);
            propertiesSelected[2] = properties.Find("DescripcionActivo", false);
            propertiesSelected[3] = properties.Find("NombreEstado", false);
            propertiesSelected[4] = properties.Find("NombreCategoria", false);
            propertiesSelected[5] = properties.Find("NombreUbicacionA", false);
            propertiesSelected[6] = properties.Find("FechaRegistroMostrar", false);
            propertiesSelected[7] = properties.Find("FechaActualizaMostrar", false);

            var propertySelected = new PropertyDescriptorCollection(propertiesSelected);
            var rutaVirtual = "~/temp/" + string.Format("ReporteInventario-" + idPerfilEmpresa + ".xlsx");
            var fileName = Server.MapPath(rutaVirtual);
            List<string> headersTomaA = new List<string>() { idioma.NumActivo, idioma.NumPlaca, idioma.Descripcion, idioma.IdEstadoActivo, 
            idioma.IdCategoria, idioma.IdUbicacionA, idioma.FechaRegistro, idioma.FechaActualiza};

            List<List<string>> headers = new List<List<string>>() { headersTomaA };
            ExcelExporter.ExportData(activos, fileName, propertySelected, headers);

            //LO CONVIERTE EN BSE 64
            string cadenaADevolver = Convert.ToBase64String(System.IO.File.ReadAllBytes(fileName));
            if (File.Exists(fileName))
            {
                File.Delete(fileName); //ELIMINA 
            }
            return "data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64," + cadenaADevolver; //ENCABEZADO DE BSE 64 Y LE PASA LA DATA
        }
   
        private IdiomaGeneralReporteA obtenerHeadersPorIdioma()
        {
            IdiomaGeneralReporteA Idioma = new IdiomaGeneralReporteA();
            switch (Request.Form["IdiomaReporteActivo"])
            {
                case "ES":
                    Idioma.NumActivo = IdiomaEspanolReporteA._numActivo;
                    Idioma.NumPlaca = IdiomaEspanolReporteA._numPlaca;
                    Idioma.Descripcion = IdiomaEspanolReporteA._descripcion;
                    Idioma.IdEstadoActivo = IdiomaEspanolReporteA._idEstadoActivo;
                    Idioma.IdCategoria = IdiomaEspanolReporteA._idCategoria;
                    Idioma.IdUbicacionA = IdiomaEspanolReporteA._idUbicacionA;
                    Idioma.FechaRegistro = IdiomaEspanolReporteA._fechaRegistro;
                    Idioma.FechaActualiza = IdiomaEspanolReporteA._fechaActualiza;
                    break;
                case "EN":

                    Idioma.NumActivo = IdiomaInglesReporteA._numActivo;
                    Idioma.NumPlaca = IdiomaInglesReporteA._numPlaca;
                    Idioma.Descripcion = IdiomaInglesReporteA._descripcion;
                    Idioma.IdEstadoActivo = IdiomaInglesReporteA._idEstadoActivo;
                    Idioma.IdCategoria = IdiomaInglesReporteA._idCategoria;
                    Idioma.IdUbicacionA = IdiomaInglesReporteA._idUbicacionA;
                    Idioma.FechaRegistro = IdiomaInglesReporteA._fechaRegistro;
                    Idioma.FechaActualiza = IdiomaInglesReporteA._fechaActualiza;

                    break;
                default:

                    Idioma.NumActivo = IdiomaEspanolReporteA._numActivo;
                    Idioma.NumPlaca = IdiomaEspanolReporteA._numPlaca;
                    Idioma.Descripcion = IdiomaEspanolReporteA._descripcion;
                    Idioma.IdEstadoActivo = IdiomaEspanolReporteA._idEstadoActivo;
                    Idioma.IdCategoria = IdiomaEspanolReporteA._idCategoria;
                    Idioma.IdUbicacionA = IdiomaEspanolReporteA._idUbicacionA;
                    Idioma.FechaRegistro = IdiomaEspanolReporteA._fechaRegistro;
                    Idioma.FechaActualiza = IdiomaEspanolReporteA._fechaActualiza;
                    break;
            }
            return Idioma;

        }
    }
}