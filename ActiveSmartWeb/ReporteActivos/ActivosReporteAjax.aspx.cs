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
using System.Drawing;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;

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

            // Creamos un nuevo archivo de Excel
            using (var excelPackage = new ExcelPackage())
            {
                // Creamos una hoja de trabajo en el archivo
                var worksheet = excelPackage.Workbook.Worksheets.Add("Activos");

                // Escribimos los encabezados de las columnas
                worksheet.Cells[2, 1].Value = "Número de Activo";
                worksheet.Cells[2, 2].Value = "Número de Etiqueta";
                worksheet.Cells[2, 3].Value = "Descripción";
                worksheet.Cells[2, 4].Value = "Estado";
                worksheet.Cells[2, 5].Value = "Categoría";
                worksheet.Cells[2, 6].Value = "Ubicación";
                worksheet.Cells[2, 7].Value = "Fecha de Registro";
                worksheet.Cells[2, 8].Value = "Fecha de Actualización";

                // Escribimos los datos de cada activo en las filas siguientes
                for (int i = 0; i < ListaActivos.Count; i++)
                {
                    worksheet.Cells[i + 3, 1].Value = ListaActivos[i].NumActivo;
                    worksheet.Cells[i + 3, 2].Value = ListaActivos[i].NumPlaca;
                    worksheet.Cells[i + 3, 3].Value = ListaActivos[i].DescripcionActivo;
                    worksheet.Cells[i + 3, 4].Value = ListaActivos[i].NombreEstado;
                    worksheet.Cells[i + 3, 5].Value = ListaActivos[i].NombreCategoria;
                    worksheet.Cells[i + 3, 6].Value = ListaActivos[i].NombreUbicacionA;
                    worksheet.Cells[i + 3, 7].Value = ListaActivos[i].FechaRegistroMostrar;
                    worksheet.Cells[i + 3, 8].Value = ListaActivos[i].FechaActualizaMostrar;
                }

                // Ajustamos el ancho de todas las columnas según su contenido
                worksheet.Cells.AutoFitColumns();

                // Centramos el texto en todas las celdas
                var range = worksheet.Cells[2, 1, ListaActivos.Count + 2, 8];
                range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Agregar bordes a todas las celdas en la tabla
                var tableRange = worksheet.Cells[2, 1, ListaActivos.Count + 2, 8];
                tableRange.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                tableRange.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                tableRange.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                tableRange.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                // Creamos un nuevo color en formato RGB
                var colorDeFondo = System.Drawing.Color.FromArgb(231, 180, 31);

                // Establecemos el color de fondo de la segunda fila
                var segundaFila = worksheet.Cells[2, 1, 2, 8];
                segundaFila.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                segundaFila.Style.Fill.BackgroundColor.SetColor(colorDeFondo);

                int RowIndex = 1;
                int ColIndex = 1;

                // Ajustar el tamaño de la fila y la columna en función del tamaño de la imagen
                worksheet.Row(RowIndex).Height = 68;

                //Obtenemos la ubicacion de la imagen
                string imagePath = Server.MapPath("~/images/signus_id.png");

                //Creamos el elemento imagen
                System.Drawing.Image img = System.Drawing.Image.FromFile(imagePath);

                //Agregamos la imagen al excel
                ExcelPicture pic = worksheet.Drawings.AddPicture("Picture_Name", img);

                //Seteamos la posicion de la imagen
                pic.SetPosition(RowIndex - 1, 0, ColIndex - 1, 0);

                // Ajustar el tamaño de la imagen
                pic.SetSize(238, 69);

                // Combinar las celdas de la columna 1 y la columna 2 en la fila 1
                ExcelRange mergedCell = worksheet.Cells[1, 1, 1, 2];
                mergedCell.Merge = true;

                // Guardamos el archivo en un MemoryStream
                using (var memoryStream = new MemoryStream())
                {
                    excelPackage.SaveAs(memoryStream);

                    // Convertimos el archivo a base 64
                    var bytes = memoryStream.ToArray();
                    var base64 = Convert.ToBase64String(bytes);

                    return base64;
                }
            }
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