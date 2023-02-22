using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.ReporteInventario.ReporteInventario;
using System.ComponentModel;
using ActiveSmartWeb.TomaFisica.DetalleToma;
using System.IO;
using OfficeOpenXml;

using ActiveSmartWeb.ReporteInventario.Idioma;

namespace ActiveSmartWeb.ReporteInventario
{
    public partial class ReporteInventarioAjax : System.Web.UI.Page
    {
        DReporteInventario _dReporteInventario;
        NReporteInventario _nReporteInventario;
        protected void Page_Load(object sender, EventArgs e)
        {
            _dReporteInventario = new DReporteInventario();
            _nReporteInventario = new NReporteInventario(_dReporteInventario);
            try
            {
                switch (Request.Form["option"])
                {
                    case "ConsultarReporteInventario":
                        var fechaInicial = Convert.ToDateTime(Request.Form["FechaInicial"]);
                        var fechaFinal = Convert.ToDateTime(Request.Form["FechaFinal"]);
                        var idPerfilActive = Convert.ToInt32(Request.Form["IdPerfilActive"]);
                        var TomasFisicasFijos = _nReporteInventario.ConsultarReporteInventario(idPerfilActive, fechaInicial, fechaFinal);
                        Response.Write(JsonConvert.SerializeObject(TomasFisicasFijos, Formatting.Indented));
                        break;
                    case "ConsultaIDTomaFisica":
                        var IdTomaFisicaI = Convert.ToInt32(Request.Form["IdTomaFisicaI"]);
                        var ConsTomaFisicaID = _nReporteInventario.ConsultaIDTomaFisica(IdTomaFisicaI);
                        Response.Write(JsonConvert.SerializeObject(ConsTomaFisicaID, Formatting.Indented));
                        break;
                    case "Exportar":
                        var idToma = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var nombreToma = Request.Form["Nombre"];
                        var descripcion  = Request.Form["Descripcion"];
                        var fechainicio = Convert.ToDateTime(Request.Form["FechaInicial"]);
                        var fechafin = Convert.ToDateTime(Request.Form["FechaFinal"]);
                        var categoria = Request.Form["NombreCategoria"];
                        var cantidadActivos = Convert.ToInt32(Request.Form["CantidadActivos"]);
                        var nombreUsuario = Request.Form["NombreUsuario"];
                        var base64Excel = obtenerBase64Excel(idToma, nombreToma, descripcion, fechainicio,
                            fechafin, categoria, cantidadActivos, nombreUsuario);
                        Response.Write(base64Excel);
                        break;

                }
            }catch(Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
        }
        private string obtenerBase64Excel(int idToma, string nombreToma, string descripcion, DateTime fechaInicio,
            DateTime fechaFin, string categoria, int cantidadActivos, string nombreUsuario)
        {
            if (idToma < 0)
                return "";

            DDetalleToma dDetalleToma = new DDetalleToma();
            NDetalleToma nDetalleToma = new NDetalleToma(dDetalleToma);

            var activos = nDetalleToma.ConsultaActivoporID(idToma);
            IdiomaGeneralReporte idioma = obtenerHeadersPorIdioma();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(EDetalleToma));
            PropertyDescriptor[] propertiesSelected = new PropertyDescriptor[4];
            propertiesSelected[0] = properties.Find("NumeroActivo", false);
            propertiesSelected[1] = properties.Find("PlacaActivo", false);
            propertiesSelected[2] = properties.Find("ObservacionActivo", false);
            propertiesSelected[3] = properties.Find("DescripcionActivo", false);
   
            var propertySelected = new PropertyDescriptorCollection(propertiesSelected);
            var rutaVirtual = "~/temp/" + string.Format("ReporteInventario-" + idToma+ ".xlsx");
            var fileName = Server.MapPath(rutaVirtual);
            List<string> headersTomaA = new List<string>() { idioma.NombreTomaF,idioma.DescripcionTomaF, idioma.FechaInicial,idioma.FechaFinal,
                idioma.Categoria,idioma.CantidadActivos, idioma.NombreUsuario};
            List<string> headersTomaB = new List<string>() { nombreToma, descripcion, Convert.ToString(fechaInicio), Convert.ToString(fechaFin),
            categoria, Convert.ToString(cantidadActivos), nombreUsuario};
            List<string> headersActivos = new List<string>() { idioma.NumActivo,idioma.PlacaActivo, idioma.ObservActivo, idioma.DescripActivo};
            List<List<string>> headers = new List<List<string>>() { headersTomaA , headersTomaB , headersActivos };
            ExcelExporter.ExportData(activos, fileName, propertySelected, headers);

                     //LO CONVIERTE EN BSE 64
            string cadenaADevolver = Convert.ToBase64String(System.IO.File.ReadAllBytes(fileName));
            if (File.Exists(fileName))
            {
                File.Delete(fileName); //ELIMINA 
            }
            return "data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64," + cadenaADevolver; //ENCABEZADO DE BSE 64 Y LE PASA LA DATA
        }


        private IdiomaGeneralReporte obtenerHeadersPorIdioma()
        {
            IdiomaGeneralReporte Idioma = new IdiomaGeneralReporte();
            switch (Request.Form["IdiomaTomaGeneral"])
            {
                case "ES":
                    Idioma.NombreTomaF = IdiomaEspañolReporte._nombreToma;
                    Idioma.DescripcionTomaF = IdiomaEspañolReporte._decripcionToma;
                    Idioma.FechaFinal = IdiomaEspañolReporte._fechaFinal;
                    Idioma.FechaInicial = IdiomaEspañolReporte._fechaInicial;
                    Idioma.Categoria = IdiomaEspañolReporte._categoria;
                    Idioma.CantidadActivos = IdiomaEspañolReporte._cantidadActivos;
                    Idioma.NombreUsuario = IdiomaEspañolReporte._nombreUsuario;
                    Idioma.NumActivo = IdiomaEspañolReporte._numActivo;
                    Idioma.PlacaActivo = IdiomaEspañolReporte._placaActivo;
                    Idioma.ObservActivo = IdiomaEspañolReporte._observacionActivo;
                    Idioma.DescripActivo = IdiomaEspañolReporte._descripcionActivo;

                    break;
                case "EN":
                    Idioma.NombreTomaF = IdiomaInglesReporte._nombreToma;
                    Idioma.DescripcionTomaF = IdiomaInglesReporte._descripcionToma;
                    Idioma.FechaFinal = IdiomaInglesReporte._fechaFinal;
                    Idioma.FechaInicial = IdiomaInglesReporte._fechaIncial;
                    Idioma.Categoria = IdiomaInglesReporte._categoria;
                    Idioma.CantidadActivos = IdiomaInglesReporte._cantidadActivos;
                    Idioma.NombreUsuario = IdiomaInglesReporte._nombreUsuario;
                    Idioma.NumActivo = IdiomaInglesReporte._numActivo;
                    Idioma.PlacaActivo = IdiomaInglesReporte._placaActivo;
                    Idioma.DescripActivo = IdiomaInglesReporte._descripctivo;
                    Idioma.ObservActivo = IdiomaInglesReporte._observActivo;
                    break;
                default:
                    Idioma.NombreTomaF = IdiomaEspañolReporte._nombreToma;
                    Idioma.DescripcionTomaF = IdiomaEspañolReporte._decripcionToma;
                    Idioma.FechaFinal = IdiomaEspañolReporte._fechaFinal;
                    Idioma.FechaInicial = IdiomaEspañolReporte._fechaInicial;
                    Idioma.Categoria = IdiomaEspañolReporte._categoria;
                    Idioma.CantidadActivos = IdiomaEspañolReporte._cantidadActivos;
                    Idioma.NombreUsuario = IdiomaEspañolReporte._nombreUsuario;
                    Idioma.NumActivo = IdiomaEspañolReporte._numActivo;
                    Idioma.PlacaActivo = IdiomaEspañolReporte._placaActivo;
                    Idioma.ObservActivo = IdiomaEspañolReporte._observacionActivo;
                    Idioma.DescripActivo = IdiomaEspañolReporte._descripcionActivo;

                    break;
            }
            return Idioma;

        }
    }
}