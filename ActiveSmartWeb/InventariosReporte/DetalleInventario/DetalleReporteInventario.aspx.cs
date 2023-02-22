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

        DDetalleToma dDetalleToma = new DDetalleToma();
        NDetalleToma nDetalleToma = new NDetalleToma(dDetalleToma);

        var activos =0;
        IdiomaGeneralReporte idioma = obtenerHeadersPorIdioma();
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(EDetalleToma));
        PropertyDescriptor[] propertiesSelected = new PropertyDescriptor[4];
        propertiesSelected[0] = properties.Find("NumeroActivo", false);
        propertiesSelected[1] = properties.Find("PlacaActivo", false);
        propertiesSelected[2] = properties.Find("ObservacionActivo", false);
        propertiesSelected[3] = properties.Find("DescripcionActivo", false);

        var propertySelected = new PropertyDescriptorCollection(propertiesSelected);
        var rutaVirtual = "~/temp/" + string.Format("ReporteInventario-" + idToma + ".xlsx");
        var fileName = Server.MapPath(rutaVirtual);
        List<string> headersTomaA = new List<string>() { idioma.NombreToma,idioma.Categoria, idioma.Ubicacion};
        List<string> headersTomaB = new List<string>() { nombreToma, categoria, ubicacion};
        List<string> headersActivos = new List<string>() { idioma.NumActivo, idioma.PlacaActivo,idioma.Descripcion, idioma.Observacion, idioma.DescripcionActivo};
          
            List<string> ListActivos = new List<string>();
            for (int i = 0; i <= ListaActivos.Count()-1; i++)
            {
                string[] Activo = { ListaActivos[i].NumeroActivo, ListaActivos[i].PlacaActivo, ListaActivos[i].DescripcionActivo, ListaActivos[i].ObservacionActivo };
                ListActivos.AddRange(Activo);
            }

            List<List<string>> headers = new List<List<string>>() { headersTomaA, headersTomaB, headersActivos };


            ExportData( fileName, propertySelected, headers, ListaActivos);


            //LO CONVIERTE EN BSE 64
            string cadenaADevolver = Convert.ToBase64String(System.IO.File.ReadAllBytes(fileName));
        if (File.Exists(fileName))
        {
            File.Delete(fileName); //ELIMINA 
        }
        return "data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64," + cadenaADevolver; //ENCABEZADO DE BSE 64 Y LE PASA LA DATA
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