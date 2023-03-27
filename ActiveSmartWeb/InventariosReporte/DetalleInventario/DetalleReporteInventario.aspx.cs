using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.InventariosReporte.IdiomaReporte;
using System.ComponentModel;
using ActiveSmartWeb.TomaFisica.DetalleToma;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;

namespace ActiveSmartWeb.InventariosReporte.DetalleInventario
{
    public partial class DetalleReporteInventario : System.Web.UI.Page
    {
        DDetalleInventario _dDetalleToma;
        NDetalleInventario _nDetalleToma;
        protected void Page_Load(object sender, EventArgs e)
        {
            _dDetalleToma = new DDetalleInventario();
            _nDetalleToma = new NDetalleInventario(_dDetalleToma);
            try
            {
                switch (Request.Form["option"])
                {
                    case "ConsultaActivoporID":
                        var IdTomaFisica = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var consultaActivo = _nDetalleToma.ConsultaActivoporID(IdTomaFisica);
                        Response.Write(JsonConvert.SerializeObject(consultaActivo, Formatting.Indented));
                        break;
                    case "ObtenerActivosTomaFisica":
                        var IdTomaFisicaSel = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var IdAccion = Convert.ToInt32(Request.Form["IdAccion"]);
                        var consultaActivoSel = _nDetalleToma.ObtenerActivosTomaFisica(IdTomaFisicaSel, IdAccion);
                        Response.Write(JsonConvert.SerializeObject(consultaActivoSel, Formatting.Indented));
                        break;
                    //Carga los activos encontrados y no encontrados de la toma
                    case "ObtenerActivosTodosToma":
                        var IdTomaT = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var IdCat = Convert.ToInt32(Request.Form["IdCategoria"]);
                        var IdUbi = Convert.ToInt32(Request.Form["IdUbicacion"]);
                        var consultaActivoT = _nDetalleToma.ObtenerActivosTodosToma(IdTomaT, IdCat, IdUbi);
                        Response.Write(JsonConvert.SerializeObject(consultaActivoT, Formatting.Indented));
                        break;
                    //Carga los activos no encontrados
                    case "ObtenerActivosNoEncontradosToma":
                        var IdTomaNE = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var consultaActivoNE = _nDetalleToma.ObtenerActivosNoEncontradosToma(IdTomaNE);
                        Response.Write(JsonConvert.SerializeObject(consultaActivoNE, Formatting.Indented));
                        break;
                    //Carga los activos encontrados
                    case "ObtenerActivosEncontradosToma":
                        var IdTomaE = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var consultaActivoE = _nDetalleToma.ObtenerActivosEncontradosToma(IdTomaE);
                        Response.Write(JsonConvert.SerializeObject(consultaActivoE, Formatting.Indented));
                        break;
                    case "ActualizarObservacionToma":
                        var IdActivo = Convert.ToInt32(Request.Form["IdActivo"]);
                        var IdTomaF = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var IdPerfilActive = Convert.ToInt32(Request.Form["IdPerfilActive"]);
                        var Observacion = Convert.ToString(Request.Form["Observacion"]);
                        var resp = _nDetalleToma.ActualizarObservacionToma(IdTomaF, IdActivo, IdPerfilActive, Observacion);
                        Response.Write(JsonConvert.SerializeObject(resp, Formatting.Indented));
                        break;
                    case "ActualizarDetalleToma":
                        var IdActiv = Convert.ToInt32(Request.Form["IdActivo"]);
                        var IdTF = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var IdPerfilA = Convert.ToInt32(Request.Form["IdPerfilActive"]);
                        var res = _nDetalleToma.ActualizarDetalleToma(IdTF, IdActiv, IdPerfilA);
                        Response.Write(JsonConvert.SerializeObject(res, Formatting.Indented));
                        break;
                    case "Exportar":
                        var idToma = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var nombreToma = Request.Form["Nombre"];
                        var ubicacion = Request.Form["Ubicacion"];
                        var categoria = Request.Form["NombreCategoria"];
                        var activosJson = Request.Form["Lista"];
                        List<EDetalleInventario> ListaActivos = JsonConvert.DeserializeObject<List<EDetalleInventario>>(activosJson);
                        var base64Excel = obtenerBase64Excel(idToma, nombreToma, ubicacion, categoria, ListaActivos);
                        Response.Write(base64Excel);
                        break;
                }
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
        }
    private string obtenerBase64Excel(int idToma, string nombreToma, string ubicacion, string categoria,
        List<EDetalleInventario> ListaActivos)
    {
        if (idToma < 0)
            return "";
        
        // Creamos un nuevo archivo de Excel
        using (var excelPackage = new ExcelPackage())
        {
            // Creamos una hoja de trabajo en el archivo
            var worksheet = excelPackage.Workbook.Worksheets.Add("Activos");

            // Escribimos los encabezados de las columnas
            worksheet.Cells[2, 1].Value = "Número de Activo";
            worksheet.Cells[2, 2].Value = "Placa";
            worksheet.Cells[2, 3].Value = "Descripción";
            worksheet.Cells[2, 4].Value = "Observación de la Toma de Activos";
            worksheet.Cells[2, 5].Value = "Resultado de Inventario";

                // Escribimos los datos de cada activo en las filas siguientes
            for (int i = 0; i < ListaActivos.Count; i++)
            {
                worksheet.Cells[i + 3, 1].Value = ListaActivos[i].NumeroActivo;
                worksheet.Cells[i + 3, 2].Value = ListaActivos[i].PlacaActivo;
                worksheet.Cells[i + 3, 3].Value = ListaActivos[i].DescripcionActivo;
                if(ListaActivos[i].ObservacionActivo == "")
                {
                    worksheet.Cells[i + 3, 4].Value = "Sin observación";
                } 
                else
                {
                    worksheet.Cells[i + 3, 4].Value = ListaActivos[i].ObservacionActivo;
                }
                
                if(ListaActivos[i].Estado == 1)
                {
                    worksheet.Cells[i + 3, 5].Value = "Encontrado";
                }
                else
                {
                    worksheet.Cells[i + 3, 5].Value = "Faltante";
                }
                 

            }

            // Ajustamos el ancho de todas las columnas según su contenido
            worksheet.Cells.AutoFitColumns();

            // Centramos el texto en todas las celdas
            var range = worksheet.Cells[2, 1, ListaActivos.Count + 2, 5];
            range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

            // Agregar bordes a todas las celdas en la tabla
            var tableRange = worksheet.Cells[2, 1, ListaActivos.Count + 2, 5];
            tableRange.Style.Border.Top.Style = ExcelBorderStyle.Thin;
            tableRange.Style.Border.Left.Style = ExcelBorderStyle.Thin;
            tableRange.Style.Border.Right.Style = ExcelBorderStyle.Thin;
            tableRange.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

            // Creamos un nuevo color en formato RGB
            var colorDeFondo = System.Drawing.Color.FromArgb(231, 180, 31);

            // Establecemos el color de fondo de la segunda fila
            var segundaFila = worksheet.Cells[2, 1, 2, 5];
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

            // Combinar las celdas de la columna 1 a la columna 3 en la fila 1
            ExcelRange mergedCell = worksheet.Cells[1, 1, 1, 3];
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
        public static void ExportData( string pfilePath, PropertyDescriptorCollection properties, List<List<string>> headers, List<EDetalleInventario> Activos)
        {
           
            if (String.IsNullOrEmpty(pfilePath))
                throw new ArgumentException("pfilePath is null or empty", "pfilePath");

            if (File.Exists(pfilePath))
            {
                File.Delete(pfilePath);
            }

            var newFile = new FileInfo(pfilePath);
            using (ExcelPackage excelPackage = new ExcelPackage(newFile))
            {
                excelPackage.Workbook.Worksheets.Add("Hoja 1");
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];

                int index = 0;
                foreach (var header in headers)
                {
                    index++;
                    for (int x = 0; x < header.Count; x++)
                    {
                        excelWorksheet.Cells[index, x + 1].Value = header[x];
                    }

                }
                foreach (var activo in Activos)
                {
                    index++;
                    excelWorksheet.Cells[index, 1].Value = activo.NumeroActivo;
                    excelWorksheet.Cells[index, 2].Value = activo.PlacaActivo;
                    excelWorksheet.Cells[index, 3].Value = activo.DescripcionActivo;
                    excelWorksheet.Cells[index, 4].Value = activo.ObservacionActivo;
                    if (activo.Estado==1)
                    {
                        excelWorksheet.Cells[index, 5].Value = "Encontrado";
                    }
                    else
                    {
                        excelWorksheet.Cells[index, 5].Value = "Faltante";
                    }

                }

                excelWorksheet.Cells["A1:Z10000"].AutoFitColumns();
                excelPackage.Save();
            }
        }

        private IdiomaGeneralReporte obtenerHeadersPorIdioma()
    {
        IdiomaGeneralReporte Idioma = new IdiomaGeneralReporte();
        switch (Request.Form["IdiomaTomaGeneral"])
        {
            case "ES":
                Idioma.NombreToma = IdiomaEspañolReporte._nombreToma;
                Idioma.Categoria = IdiomaEspañolReporte._categoria;
                Idioma.Ubicacion = IdiomaEspañolReporte._ubicacion;
                Idioma.NumActivo = IdiomaEspañolReporte._numActivo;
                Idioma.PlacaActivo = IdiomaEspañolReporte._placaActivo;
                Idioma.Observacion = IdiomaEspañolReporte._observacion;
                Idioma.Descripcion = IdiomaEspañolReporte._descripcion;
                Idioma.DescripcionActivo = IdiomaEspañolReporte._descripcionActivo;

                break;
            case "EN":
                    Idioma.NombreToma = IdiomaInglesReporte._nombreToma;
                    Idioma.Categoria = IdiomaInglesReporte._categoria;
                    Idioma.Ubicacion = IdiomaInglesReporte._ubicacion;
                    Idioma.NumActivo = IdiomaInglesReporte._numActivo;
                    Idioma.PlacaActivo = IdiomaInglesReporte._placaActivo;
                    Idioma.Observacion = IdiomaInglesReporte._observacion;
                    Idioma.Descripcion = IdiomaInglesReporte._descripcion;
                    Idioma.DescripcionActivo = IdiomaInglesReporte._descripcionActivo;
                break;
            default:
                    Idioma.NombreToma = IdiomaEspañolReporte._nombreToma;
                    Idioma.Categoria = IdiomaEspañolReporte._categoria;
                    Idioma.Ubicacion = IdiomaEspañolReporte._ubicacion;
                    Idioma.NumActivo = IdiomaEspañolReporte._numActivo;
                    Idioma.PlacaActivo = IdiomaEspañolReporte._placaActivo;
                    Idioma.Observacion = IdiomaEspañolReporte._observacion;
                    Idioma.Descripcion = IdiomaEspañolReporte._descripcion;
                    Idioma.DescripcionActivo = IdiomaEspañolReporte._descripcionActivo;
                    break;
        }
        return Idioma;

    }
}
}