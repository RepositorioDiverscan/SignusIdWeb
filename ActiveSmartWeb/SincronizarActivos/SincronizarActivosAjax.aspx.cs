using ActiveSmartWeb.SincronizarActivos.Idioma;
using ActiveSmartWeb.SincronizarActivos.SincronizarAct;
using ActiveSmartWeb.Utilities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ExcelDataReader;
using OfficeOpenXml;
using Newtonsoft.Json;
using ActiveSmartWeb.CategoriaActivo.Categoria;
using ActiveSmartWeb.EstadoActivoFijo.EstadoActivo;
using ActiveSmartWeb.Ubicaciones.UbicacionA;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace ActiveSmartWeb.SincronizarActivos
{
    public partial class SincronizarActivosAjax : System.Web.UI.Page
    {
        DSincronizaActivos _dSincronizaActivos;
        NSincronizaActivos _nSincronizaActivos;

        private List<ESincronizaActivos> _activos
        {
            get
            {
                var data = Session["activos"] as List<ESincronizaActivos>;
                if (data == null)
                {
                    data = new List<ESincronizaActivos>();
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
            _dSincronizaActivos = new DSincronizaActivos();
            _nSincronizaActivos = new NSincronizaActivos(_dSincronizaActivos);
            try
            {
                switch (Request.Form["option"])
                {
                    case "InsertarActivoSincronizacion":
                        var numeroActivo = Request.Form["NumeroActivo"];
                        var numeroPlaca = Request.Form["PlacaActivo"];
                        var idEstadoActivo = Request.Form["EstadoActivo"];
                        var idCategoriaActivo = Request.Form["CategoriaActivo"];
                        var idUbicaionA = Request.Form["UbicacionA"];
                        var idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var marca = Request.Form["Marca"];
                        var modelo = Request.Form["Modelo"];
                        var descripcionCorta = Request.Form["DescripcionCorta"];
                        decimal costo;
                            if (Request.Form["CostoActivo"] != "")
                            {
                                costo = Convert.ToDecimal(Request.Form["CostoActivo"]);
                            }
                            else
                            {
                                costo = 0;
                            }
                            var costoActivo = costo;
                            var idArchivo = Convert.ToInt32(Request.Form["IdSincArchivo"]);

                            var resultadoinsertar = _nSincronizaActivos.InsertarActivoSincronizacion(numeroActivo, numeroPlaca, idEstadoActivo,
                                                        idCategoriaActivo, idUbicaionA, idPerfilEmpresa, marca, modelo, descripcionCorta,
                                                        costoActivo, idArchivo);
                            Response.Write(resultadoinsertar);
                        break;
                    case "InsertarArchivo":
                        var idPerfilEmpresaArch = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var estado = Convert.ToInt32(Request.Form["Estado"]);
                        var nombreArchivo = Request.Form["NombreArchivo"]; 

                        var resultadoi = _nSincronizaActivos.InsertarArchivo(idPerfilEmpresaArch, estado, nombreArchivo);
                        Response.Write(resultadoi);
                        break;
                    case "ConsultaArchivo":
                        var idPerfilEmpresaConArch = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var resultado = _nSincronizaActivos.ConsultaArchivo(idPerfilEmpresaConArch);
                        Response.Write(JsonConvert.SerializeObject(resultado, Formatting.Indented));
                        break;
                    case "ConsultaActivos":
                        var resultadoActiv = _nSincronizaActivos.ConsultaActivos();
                        Response.Write(JsonConvert.SerializeObject(resultadoActiv, Formatting.Indented));
                        break;
                    case "InsertarActivoFijo":
                          var idArchivos = Convert.ToInt32(Request.Form["IdArchivo"]);
                        var idPerfilEmpresaI = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var resultadoinsertarFijo = _nSincronizaActivos.InsertarActivoFijo(idArchivos, idPerfilEmpresaI);
                        Response.Write(resultadoinsertarFijo);
                        break;
                    case "BorrarArchivo":
                        var idArchivosB = Convert.ToInt32(Request.Form["IdArchivo"]);
                        var idEmpresaB = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);

                        var resultadoBorrarExcel = Eliminarexcel(idEmpresaB,idArchivosB);
                        var resultadoBorrar = _nSincronizaActivos.BorrarArchivo(idArchivosB);
                        Response.Write(resultadoBorrar);
                        break;
                    case "ActualizaEstadoSinc":
                        var idArchivoActual = Convert.ToInt32(Request.Form["IdArchivo"]);
                        var estadoSincr = Convert.ToString(Request.Form["EstadoSincronizacion"]);

                        var resultadoActualiza = _nSincronizaActivos.ActualizaArchivoEstado(idArchivoActual, estadoSincr);
                        Response.Write(resultadoActualiza);
                        break;
                    case "Exportar":
                        var idempresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]); 

                        var base64Excel = CrearExcelSincronizar(idempresa);
                        //var base64Excel = obtenerBase64Excel();
                        Response.Write(base64Excel);
                        break;
                    case "Importar":
                        var base64ToUpload = Request.Form["ExcelBase64"];
                        var dataFiles = readFile(base64ToUpload);

                        Response.Write(JsonConvert.SerializeObject(dataFiles, Formatting.Indented));
                        
                        break;
                    case "Crear":
                        var base64 = Request.Form["ExcelBase64"];
                        var idPerfil = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var Idarchivo = Convert.ToInt32(Request.Form["IdArchivo"]);

                        var datacreate = crearexcel(idPerfil, base64, Idarchivo);

                        Response.Write(JsonConvert.SerializeObject(datacreate, Formatting.Indented));

                        break;

                    case "Guardar":
                        var idPerfilG = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var IdarchivoG = Convert.ToInt32(Request.Form["IdArchivo"]);

                        var dataGuardar = Guardarexcel(idPerfilG,IdarchivoG);

                        Response.Write(dataGuardar);

                        break;

                    case "InsertarListaActivos":

                        var idPerfilEmpresa1 = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);

                        var Activos = Request.Form["ListaActivos"];

                        var result = JsonConvert.DeserializeObject<List<ESincronizaActivos>>(Activos);

                        result = _dSincronizaActivos.SincronizarActivos(idPerfilEmpresa1, result);

                        if (result.Count == 0)
                        {
                            Response.Write(0);
                        }
                        else
                        {
                            Response.Write(JsonConvert.SerializeObject(result, Formatting.Indented));
                        }
                        break;

                }
            }catch(Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
        }

        private IdiomaSincronizarGeneral obtenerIdiomaHeaders()
        {
            IdiomaSincronizarGeneral Idioma = new IdiomaSincronizarGeneral();
            switch (Request.Form["IdiomaSincronizaActivo"])
            {
                case "ES":
                    Idioma.NumAct = IdiomaSincronizarEspanol._numAct;
                    Idioma.NumEtiq = IdiomaSincronizarEspanol._numEtiq;
                    Idioma.Categ = IdiomaSincronizarEspanol._categ;
                    Idioma.Estado = IdiomaSincronizarEspanol._estado;
                    Idioma.Marca = IdiomaSincronizarEspanol._marca;
                    Idioma.Modelo = IdiomaSincronizarEspanol._modelo;
                    Idioma.Ubicacion = IdiomaSincronizarEspanol._ubicacion;
                    Idioma.Observacion = IdiomaSincronizarEspanol._observacion;
                    Idioma.EstadoSinc = IdiomaSincronizarEspanol._estadoSinc;
                    Idioma.Costo = IdiomaSincronizarEspanol._costo;
                    break;
                case "EN":
                    Idioma.NumAct = IdiomaSincronizarIngles._numAct;
                    Idioma.NumEtiq = IdiomaSincronizarIngles._numEtiq;
                    Idioma.Categ = IdiomaSincronizarIngles._categ;
                    Idioma.Estado = IdiomaSincronizarIngles._estado;
                    Idioma.Marca = IdiomaSincronizarIngles._marca;
                    Idioma.Modelo = IdiomaSincronizarIngles._modelo;
                    Idioma.Ubicacion = IdiomaSincronizarIngles._ubicacion;
                    Idioma.Observacion = IdiomaSincronizarIngles._observacion;
                    Idioma.EstadoSinc = IdiomaSincronizarIngles._estadoSinc;
                    Idioma.Costo = IdiomaSincronizarIngles._costo;

                    break;
                default:
                    Idioma.NumAct = IdiomaSincronizarEspanol._numAct;
                    Idioma.NumEtiq = IdiomaSincronizarEspanol._numEtiq;
                    Idioma.Categ = IdiomaSincronizarEspanol._categ;
                    Idioma.Estado = IdiomaSincronizarEspanol._estado;
                    Idioma.Marca = IdiomaSincronizarEspanol._marca;
                    Idioma.Modelo = IdiomaSincronizarEspanol._modelo;
                    Idioma.Ubicacion = IdiomaSincronizarEspanol._ubicacion;
                    Idioma.Observacion = IdiomaSincronizarEspanol._observacion;
                    Idioma.EstadoSinc = IdiomaSincronizarEspanol._estadoSinc;
                    Idioma.Costo = IdiomaSincronizarEspanol._costo;
                    break;
            }
            return Idioma;
        }
        private List<ESincronizaActivos> readFile(string base64)
        {
            List<ESincronizaActivos> dataFiles = new List<ESincronizaActivos>();

            var bytes = Convert.FromBase64String(base64);
            using (ExcelPackage excelPackage = new ExcelPackage(new MemoryStream(bytes)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];
                bool contineDatos = true;
                int row = 4;
                int cantidad = -1;

                while (contineDatos)
                {
                    if (excelWorksheet.Cells[row, 1].Value == null && excelWorksheet.Cells[row, 2].Value == null)
                        break;


                    var numeroEtiqueta = "";
                    if (excelWorksheet.Cells[row, 2].Value != null)
                        numeroEtiqueta = excelWorksheet.Cells[row, 2].Value.ToString();


                    var descripcion = "";
                    if (excelWorksheet.Cells[row, 3].Value != null)
                        descripcion = excelWorksheet.Cells[row, 3].Value.ToString();

                    var categoria = "";
                    if (excelWorksheet.Cells[row, 4].Value != null)
                        categoria = excelWorksheet.Cells[row, 4].Value.ToString();

                    var estado = "";
                    if (excelWorksheet.Cells[row, 5].Value != null)
                        estado = excelWorksheet.Cells[row, 5].Value.ToString();

                    var ubicacion = "";
                    if (excelWorksheet.Cells[row, 6].Value != null)
                        ubicacion = excelWorksheet.Cells[row, 6].Value.ToString();

                    var marca = "";
                    if (excelWorksheet.Cells[row, 7].Value != null)
                        marca = excelWorksheet.Cells[row, 7].Value.ToString();

                    var modelo = "";
                    if (excelWorksheet.Cells[row, 8].Value != null)
                        modelo = excelWorksheet.Cells[row, 8].Value.ToString();

                    var serie = "";
                    if (excelWorksheet.Cells[row, 9].Value != null)
                        serie = excelWorksheet.Cells[row, 9].Value.ToString();

                    var costo = "";
                    if (excelWorksheet.Cells[row, 10].Value != null)
                        costo = excelWorksheet.Cells[row, 10].Value.ToString();

                    var factura = "";
                    if (excelWorksheet.Cells[row, 11].Value != null)
                        factura = excelWorksheet.Cells[row, 11].Value.ToString();

                    DateTime fechaCompra=DateTime.Now;
                    if (excelWorksheet.Cells[row, 12].Value != null)
                    {
                        try
                        {
                            fechaCompra = excelWorksheet.Cells[row, 12].GetValue<DateTime>();
                            //fechaCompra = convertirFecha(fechaCompra);
                            //fechaCompra = fechaCompra + " 12:00:00 AM";


                        }
                        catch (Exception)
                        {

                            dataFiles.Add(new ESincronizaActivos(numeroEtiqueta, descripcion, categoria,
                        estado, ubicacion, marca, modelo, serie, costo, factura));
                        }
        


                    }
                                          


                    cantidad = cantidad + 1;
                    dataFiles.Add(new ESincronizaActivos(numeroEtiqueta, descripcion, categoria,
                        estado, ubicacion, marca, modelo, serie, costo, factura, fechaCompra));
                    
                    if (excelWorksheet.Cells[row, 1].Value == null && excelWorksheet.Cells[row, 2].Value == null)
                        contineDatos = false;
                    row++;
                }

            }

            return dataFiles;
        }

        //Pasamos la fecha de dd/mm/yyyy a mm/dd/yyyy
        //private string convertirFecha(string fecha)
        //{
        //    string[] partesFecha = fecha.Split('/');
        //    int dia = int.Parse(partesFecha[0]);
        //    int mes = int.Parse(partesFecha[1]);
        //    int anio = int.Parse(partesFecha[2]);

        //    // crear un objeto DateTime con la fecha en formato "dd/MM/yyyy"
        //    DateTime fechaOriginal = new DateTime(anio, mes, dia);

        //    // convertir la fecha a formato "MM/dd/yyyy"
        //    return fechaOriginal.ToString("MM/dd/yyyy");
            
        //}

        private string crearexcel(int IdEmpresa,string Base64, int IdArchivo)
        {

            try
            {
                //Convierte Base64 a Byte.
                byte[] imageBytes = Convert.FromBase64String(Base64);
                string directorio = "~/ArchivosSistema/Sincronizacion/" + IdEmpresa;
                //Validar si existe el directorio
                if (!System.IO.Directory.Exists(System.Web.HttpContext.Current.Server.MapPath(directorio)))
                {
                    System.IO.Directory.CreateDirectory(System.Web.HttpContext.Current.Server.MapPath(directorio));
                }
                //Guarda la imagen
                string filePath = System.Web.HttpContext.Current.Server.MapPath(directorio + "\\ArchivoExcel" + IdArchivo + ".xlsx");
                File.WriteAllBytes(filePath, imageBytes);

                return "Creado";
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";
            }

        }

        private string Guardarexcel(int IdEmpresa, int IdArchivo)
        {

            try
            {

                string directorio = "~/ArchivosSistema/Sincronizacion/" + IdEmpresa;

                string filePath = System.Web.HttpContext.Current.Server.MapPath(directorio + "\\ArchivoExcel" + IdArchivo + ".xlsx");

                string cadenaADevolver = Convert.ToBase64String(System.IO.File.ReadAllBytes(filePath));
                

                return "data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64," + cadenaADevolver;

            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";
            }

        }

        private string Eliminarexcel(int IdEmpresa, int IdArchivo)
        {

            try
            {

                string directorio = "~/ArchivosSistema/Sincronizacion/" + IdEmpresa;

                string fileName = System.Web.HttpContext.Current.Server.MapPath(directorio + "\\ArchivoExcel" + IdArchivo + ".xlsx");


                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }


                return "Se elimino";

            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";
            }

        }

        #region CodigoNuevoSincronizar

        private string CrearExcelSincronizar(int idempresa)
        {
            
            List<EUbicacionA> ubicaciones = _nSincronizaActivos.ConsultarUbicaciones(idempresa);

            List<EEstadoActivo> Estado = _nSincronizaActivos.ConsultaEstadoActivo();

            List<ECategoriaActivo> Categoria = _nSincronizaActivos.ConsultaCategoriaActivos();

            //var rutaBase = "E:\\Cristopher Salazar\\SignusIdWeb\\ActiveSmartWeb\\PlantillaExcelReporte\\ExcelcargaSIGNUSID.xlsx";
            var rutaBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PlantillaExcelReporte", "ExcelcargaSIGNUSID.xlsx");
            //var rutaDestino = "C:\\PlantillaExcel\\ExcelcargaSIGNUSID_1.xlsx";
            var rutaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PlantillaExcelReporte", "ExcelcargaSIGNUSID_1.xlsx");

            var fileInfoDestino = new FileInfo(rutaDestino);

            using (FileStream fs = File.OpenRead(rutaBase))
            using (ExcelPackage excelPackage = new ExcelPackage(fs))
            {

                var hojaActual = excelPackage.Workbook.Worksheets["Ubicaciones"];

                int count = 4;

                if (ubicaciones.Count > 0)
                {
                    foreach (EUbicacionA element in ubicaciones)
                    {
                        hojaActual.Cells[count, 2].Value = element.Nombre;

                        count = count + 1;
                    }
                }

                count = 4;

                var hojaActual2 = excelPackage.Workbook.Worksheets["Estados"];

                if (Estado.Count > 0)
                {
                    foreach (EEstadoActivo element in Estado)
                    {
                     
                        hojaActual2.Cells[count, 2].Value = element.NombreEstado;
                        hojaActual2.Cells[count, 3].Value = element.DescripcionEstado;                      

                        count = count + 1;
                    }
                }

                count = 4;

                var hojaActual3 = excelPackage.Workbook.Worksheets["Categorías"];

                if (Categoria.Count > 0)
                {
                    foreach (ECategoriaActivo element in Categoria)
                    {
                        hojaActual3.Cells[count, 2].Value = element.NombreCategoria;
                        hojaActual3.Cells[count, 3].Value = element.DescripcionCategoria;

                        count = count + 1;
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

        #endregion

    }

}