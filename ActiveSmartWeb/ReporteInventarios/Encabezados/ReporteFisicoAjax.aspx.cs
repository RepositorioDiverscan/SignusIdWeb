using ActiveSmartWeb.ReporteInventariosPrueba.DetalleReporte;
using ActiveSmartWeb.ReporteInventariosPrueba.ReporteInventarios;
using ActiveSmartWeb.ReporteInventariosPrueba.IdiomaInventarios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using ActiveSmartWeb.Utilities;
using System.IO;
using OfficeOpenXml;
using ActiveSmartWeb.ReporteInventariosPrueba.DetalleReporteInventario;

namespace ActiveSmartWeb.ReporteInventariosPrueba.Encabezados
{
    public partial class ReporteFisicoAjax : System.Web.UI.Page
    {
        DReporteFisico _dReporteFisico;
        protected void Page_Load(object sender, EventArgs e)
        {
            _dReporteFisico = new DReporteFisico();

            try
            {
                switch (Request.Form["option"])
                {
                    //ME TRAE ID
                    case "ConsultaTomaFisica":
                        var fechaInicial = Convert.ToDateTime(Request.Form["FechaInicial"]);
                        var fechaFinal = Convert.ToDateTime(Request.Form["FechaFinal"]);
                        var idPerfilActive = Convert.ToInt32(Request.Form["idPerfilActive"]);
                        var TomasFisicasFijos = _dReporteFisico.ConsultarTomaFisica(idPerfilActive, fechaInicial, fechaFinal);
                        Session["Completo"] = TomasFisicasFijos;
                        Response.Write(JsonConvert.SerializeObject(TomasFisicasFijos, Formatting.Indented));
                        break;

                    case "ConsultaResultadoInventario":
                        var Id_TomaFisica = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var resultadoInventario = _dReporteFisico.ConsultaResultadoInventario(Id_TomaFisica);
                        Session["Completo2"] = resultadoInventario;
                        Response.Write(JsonConvert.SerializeObject(resultadoInventario, Formatting.Indented));
                        break;
                    //PDF
                    case "Exportar":
                        var idToma = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var nombreToma = Request.Form["Nombre"];
                        var descripcion = Request.Form["Descripcion"];
                        var fechainicio = Convert.ToDateTime(Request.Form["FechaInicial"]);
                        var fechafin = Convert.ToDateTime(Request.Form["FechaFinal"]);
                        var categoria = Request.Form["NombreCategoria"];
                        var cantidadActivos = Convert.ToInt32(Request.Form["CantidadActivos"]);
                        var nombreUsuario = Request.Form["NombreUsuario"];
                        var base64Excel = obtenerBase64Excel(idToma, nombreToma, descripcion, fechainicio,
                            fechafin, categoria, cantidadActivos, nombreUsuario);

                        Response.Write(base64Excel);
                        break;

                   case "ExportarExcel":

                        var idTomaExel = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var nombreTomaExcel = Request.Form["Nombre"];
                        var descripcionExcel = Request.Form["Descripcion"];
                        var fechainicioExcel = Convert.ToDateTime(Request.Form["FechaInicial"]);
                        var fechafinExcel = Convert.ToDateTime(Request.Form["FechaFinal"]);
                        var categoriaExcel = Request.Form["NombreCategoria"];
                        var cantidadActivosExcel = Convert.ToInt32(Request.Form["CantidadActivos"]);
                        var nombreUsuarioExcel = Request.Form["NombreUsuario"];
                        var id_activo = Convert.ToInt32(Request.Form["idActivo"]);
                        var numeroActivo = Request.Form["NumeroActivo"];
                        var placaActivo = Request.Form["placaActivo"];
                        var descripcionActivo = Request.Form["DescripcionActivo"];
                        var observacionActivo = Request.Form["Observacion"];
                        var resultadoInversion = Request.Form["ResultadoInventario"];

                        var listafiltroGrupo = (List<EReporteFisico>)Session["Completo"];

                        var listafiltroGrupo2 = (List<EDetalleResultadoInventario>)Session["Completo2"];

                        var exportarExcel = crearReporteExcel(listafiltroGrupo,listafiltroGrupo2);

                        Response.Write(exportarExcel);
                        break;
                }
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }

        }

        //metodo que obtener base de excel 
        private string obtenerBase64Excel(int idToma, string nombreToma, string descripcion, DateTime fechaInicio,
            DateTime fechaFin, string categoria, int cantidadActivos, string nombreUsuario)
        {
            if (idToma < 0)
                return "";

            EDetalleReporte dDetalleToma = new EDetalleReporte();
            // NDetalleToma nDetalleToma = new NDetalleToma(dDetalleToma);

            var activos = idToma;
            EIdiomaGeneral idioma = obtenerHeadersPorIdioma();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(EDetalleReporte));
            PropertyDescriptor[] propertiesSelected = new PropertyDescriptor[4];
            propertiesSelected[0] = properties.Find("NumeroActivo", false);
            propertiesSelected[1] = properties.Find("PlacaActivo", false);
            propertiesSelected[2] = properties.Find("ObservacionActivo", false);
            propertiesSelected[3] = properties.Find("DescripcionActivo", false);

            var propertySelected = new PropertyDescriptorCollection(propertiesSelected);
            var rutaVirtual = "~/temp/" + string.Format("ReporteInventario-" + idToma + ".xlsx");
            var fileName = Server.MapPath(rutaVirtual);
            List<string> headersTomaA = new List<string>() { idioma.NombreTomaF,idioma.DescripcionTomaF, idioma.FechaInicial,idioma.FechaFinal,
                idioma.Categoria,idioma.CantidadActivos, idioma.NombreUsuario};
            List<string> headersTomaB = new List<string>() { nombreToma, descripcion, Convert.ToString(fechaInicio), Convert.ToString(fechaFin),
            categoria, Convert.ToString(cantidadActivos), nombreUsuario};
            List<string> headersActivos = new List<string>() { idioma.NumActivo, idioma.PlacaActivo, idioma.ObservActivo, idioma.DescripActivo };
            List<List<string>> headers = new List<List<string>>() { headersTomaA, headersTomaB, headersActivos };
            // ExcelExporter.ExportData(activos,fileName,propertySelected,headers);
            //cual es el problema aca ?

            string cadenaADevolver = Convert.ToBase64String(System.IO.File.ReadAllBytes(fileName));
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            return "data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64," + cadenaADevolver;
        }
        private EIdiomaGeneral obtenerHeadersPorIdioma()
        {
            EIdiomaGeneral Idioma = new EIdiomaGeneral();
            switch (Request.Form["IdiomaTomaGeneral"])
            {
                case "ES":

                    Idioma.Titulo = EIdiomaES._titulo;
                    Idioma.Desde = EIdiomaES._desde;
                    Idioma.Hasta = EIdiomaES._hasta;
                    Idioma.NombreTomaF = EIdiomaES._nombreTomaF;
                    Idioma.DescripcionTomaF = EIdiomaES._descripcionTomaF;
                    Idioma.ErrorRangoF = EIdiomaES._errorRangoF;
                    Idioma.FechaFinal = EIdiomaES._fechaFinal;
                    Idioma.FechaInicial = EIdiomaES._fechaInicial;
                    Idioma.Categoria = EIdiomaES._categoria;
                    Idioma.ConsultaError = EIdiomaES._consultaError;
                    Idioma.NumActivo = EIdiomaES._numActivo;
                    Idioma.PlacaActivo = EIdiomaES._placaActivo;
                    Idioma.DescripActivo = EIdiomaES._descripActivo;
                    Idioma.ObservActivo = EIdiomaES._observActivo;
                    Idioma.CantidadActivos = EIdiomaES._cantidadActivos;
                    Idioma.NombreUsuario = EIdiomaES._nombreUsuario;
                   

                    Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                    break;

                case "EN":
                    Idioma.Titulo = EIdiomaEN._titulo;
                    Idioma.Desde = EIdiomaEN._desde;
                    Idioma.Hasta = EIdiomaEN._hasta;
                    Idioma.NombreTomaF = EIdiomaEN._nombreTomaF;
                    Idioma.DescripcionTomaF = EIdiomaEN._descripcionTomaF;
                    Idioma.ErrorRangoF = EIdiomaEN._errorRangoF;
                    Idioma.FechaInicial = EIdiomaEN._fechaInicial;
                    Idioma.FechaFinal = EIdiomaEN._fechaFinal;
                    Idioma.Categoria = EIdiomaEN._categoria;
                    Idioma.ConsultaError = EIdiomaEN._consultaError;
                    Idioma.NumActivo = EIdiomaEN._numActivo;
                    Idioma.PlacaActivo = EIdiomaEN._placaActivo;
                    Idioma.DescripActivo = EIdiomaEN._descripActivo;
                    Idioma.ObservActivo = EIdiomaEN._observActivo;
                    Idioma.CantidadActivos = EIdiomaEN._cantidadActivos;
                    Idioma.NombreUsuario = EIdiomaEN._nombreUsuario;
                   
                    Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                    break;

                default:

                    Idioma.Titulo = EIdiomaES._titulo;
                    Idioma.Desde = EIdiomaES._desde;
                    Idioma.Hasta = EIdiomaES._hasta;
                    Idioma.NombreTomaF = EIdiomaES._nombreTomaF;
                    Idioma.DescripcionTomaF = EIdiomaES._descripcionTomaF;
                    Idioma.ErrorRangoF = EIdiomaES._errorRangoF;
                    Idioma.FechaFinal = EIdiomaES._fechaFinal;
                    Idioma.FechaInicial = EIdiomaES._fechaInicial;
                    Idioma.Categoria = EIdiomaES._categoria;
                    Idioma.ConsultaError = EIdiomaES._consultaError;
                    Idioma.NumActivo = EIdiomaES._numActivo;
                    Idioma.PlacaActivo = EIdiomaES._placaActivo;
                    Idioma.DescripActivo = EIdiomaES._descripActivo;
                    Idioma.ObservActivo = EIdiomaES._observActivo;
                    Idioma.CantidadActivos = EIdiomaES._cantidadActivos;
                    Idioma.NombreUsuario = EIdiomaES._nombreUsuario;
                   

                    Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                    break;
            }
            return Idioma;

        }



        private string crearReporteExcel(List<EReporteFisico> reporteFisico, List<EDetalleResultadoInventario> detalleReporte)
        {



            var rutaBase = "C:\\PlantillaExcel\\PlantillaReporteInventario.xlsx";
            var rutaDestino = "C:\\PlantillaExcel\\PlantillaReporteInventario_1.xlsx";



            var fileInfoDestino = new FileInfo(rutaDestino);




            using (FileStream fs = File.OpenRead(rutaBase))
            using (ExcelPackage excelPackage = new ExcelPackage(fs))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;
                ExcelWorksheet excelWorksheet = excelWorkBook.Worksheets.First();
                int count = 2;
                int count2 = 2;
                if (reporteFisico.Count > 0 & detalleReporte.Count > 0)
                {
                    foreach (EReporteFisico element in reporteFisico)
                    {
                        excelWorksheet.Cells[count, 1].Value = element.Nombre;
                        excelWorksheet.Cells[count, 2].Value = element.Descripcion;
                        excelWorksheet.Cells[count, 3].Value = element.FechaInicial;
                        excelWorksheet.Cells[count, 4].Value = element.FechaFinal;
                        excelWorksheet.Cells[count, 5].Value = element.NombreCategoria;
                        excelWorksheet.Cells[count, 6].Value = element.CantidadActivos;
                        excelWorksheet.Cells[count, 7].Value = element.NombreUsuario;
                      
                        count = count + 1;
                    }
                    foreach (EDetalleResultadoInventario element in detalleReporte)
                    {
                        excelWorksheet.Cells[count2, 8].Value = element.NumeroActivo;
                        excelWorksheet.Cells[count2, 9].Value = element.PlacaActivo;
                        excelWorksheet.Cells[count2, 10].Value = element.DescripcionActivo;
                        excelWorksheet.Cells[count2, 11].Value = element.ObservacionActivoToma;
                        excelWorksheet.Cells[count2, 12].Value = element.ResultadoInventario;
                       
                        count2 = count2 + 1;
                    }
                }



                excelPackage.SaveAs(fileInfoDestino);
            }
            string cadenaADevolver = "data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64," + Convert.ToBase64String(System.IO.File.ReadAllBytes(rutaDestino));
            if (File.Exists(rutaDestino))
            {
                File.Delete(rutaDestino);
            }
            return cadenaADevolver;
        }
    }




}