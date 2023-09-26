using ActiveSmartWeb.RegistroActivos.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ActiveSmartWeb.RegistroActivos
{
    public partial class IdiomaRegistroActivos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaRegistroGeneral Idioma = new IdiomaRegistroGeneral();
            try
            {
                switch (Request.Form["idiomaRegistroActivos"])
                {
                    case "ES":
                        Idioma.Titulo = IdiomaRegistroEspannol._titulo;
                        Idioma.NumActivo = IdiomaRegistroEspannol._numActivo;
                        Idioma.NumPlaca = IdiomaRegistroEspannol._numPlaca;
                        Idioma.Categoria = IdiomaRegistroEspannol._categoria;
                        Idioma.Estado = IdiomaRegistroEspannol._estado;
                        Idioma.Marca = IdiomaRegistroEspannol._marca;
                        Idioma.Ubicacion = IdiomaRegistroEspannol._ubicacion;
                        Idioma.Modelo = IdiomaRegistroEspannol._modelo;
                        Idioma.Observaciones = IdiomaRegistroEspannol._observaciones;
                        Idioma.SelectUbi = IdiomaRegistroEspannol._selectUbi;
                        Idioma.ValidEstado = IdiomaRegistroEspannol._validEstado;
                        Idioma.ValidCategoria = IdiomaRegistroEspannol._validCategoria;
                        Idioma.ValidNumActivo = IdiomaRegistroEspannol._validNumActivo;
                        Idioma.ActualizaError = IdiomaRegistroEspannol._actualizarError;
                        Idioma.AgregarError = IdiomaRegistroEspannol._agregarError;
                        Idioma.ActualizaCorrecto = IdiomaRegistroEspannol._actualizaCorrecto;
                        Idioma.AgregarCorrecto = IdiomaRegistroEspannol._agreggaCorrecto;
                        Idioma.TituloEditar = IdiomaRegistroEspannol._tituloEditar;
                        Idioma.NumeroSerie = IdiomaRegistroEspannol._numeroSeria;
                        Idioma.DescripcionCorta = IdiomaRegistroEspannol._descripcionCorta;
                        Idioma.DescripcionCategoria = IdiomaRegistroEspannol._descripcionCategoria;
                        Idioma.DescripcionEstado = IdiomaRegistroEspannol._descripcionEstado;
                        Idioma.NumeroFactura = IdiomaRegistroEspannol._numeroFactura;
                        Idioma.FechaCompra = IdiomaRegistroEspannol._fechaCompra;
                        Idioma.CostoActivo = IdiomaRegistroEspannol._costoActivo;
                        Idioma.ValidDescCorta = IdiomaRegistroEspannol._validDescCorta;
                        Idioma.ValidCostoActivo = IdiomaRegistroEspannol._validCostoActivo;
                        Idioma.ValidUbicacion = IdiomaRegistroEspannol._validUbicacion;
                        Idioma.ValidActNumAct = IdiomaRegistroEspannol._validActNumAct;
                        Idioma.NumParteActivo = IdiomaRegistroEspannol._numParteActivo;
                        Idioma.Depreciado = IdiomaRegistroEspannol._depreciado;
                        Idioma.Descripcion = IdiomaRegistroEspannol._descripcion;
                        Idioma.DiasvidaU = IdiomaRegistroEspannol._diasVidaU;
                        Idioma.CuentaContable = IdiomaRegistroEspannol._cuentaContable;
                        Idioma.CentroCostos = IdiomaRegistroEspannol._centroCostos;
                        Idioma.Empleado = IdiomaRegistroEspannol._empleado;
                        Idioma.UbicacionB = IdiomaRegistroEspannol._ubicacionB;
                        Idioma.UbicacionC = IdiomaRegistroEspannol._ubicacionC;
                        Idioma.UbicacionD = IdiomaRegistroEspannol._ubicacionD;
                        Idioma.FechaGarantia = IdiomaRegistroEspannol._fechaGarantia;
                        Idioma.TamañoMed = IdiomaRegistroEspannol._tamañoMed;
                        Idioma.MsjTienda = IdiomaRegistroEspannol._msjTienda;
                        Idioma.MsjBtnTienda = IdiomaRegistroEspannol._msjbtnTienda;
                        Idioma.Color = IdiomaRegistroEspannol._color;
                        Idioma.SelectFiltro = IdiomaRegistroEspannol._selecFiltro;
                        Idioma.Fotos = IdiomaRegistroEspannol._fotos;
                        Idioma.Costo = IdiomaRegistroEspannol._costo;
                        Idioma.Buscar = IdiomaRegistroEspannol._buscar;
                        Idioma.Foto1 = IdiomaRegistroEspannol._foto1;
                        Idioma.Foto2 = IdiomaRegistroEspannol._foto2;
                        Idioma.Foto3 = IdiomaRegistroEspannol._foto3;
                        Idioma.Foto4 = IdiomaRegistroEspannol._foto4;
                        Idioma.Foto5 = IdiomaRegistroEspannol._foto5;
                        Idioma.Selectmsj = IdiomaRegistroEspannol._selectmsj;
                        Idioma.Valnumfactura = IdiomaRegistroEspannol._valnumfactura;
                        Idioma.Valnumetiqueta = IdiomaRegistroEspannol._valnumetiqueta;
                        Idioma.Valmarca = IdiomaRegistroEspannol._valmarca;
                        Idioma.Valmodelo = IdiomaRegistroEspannol._valmodelo;
                        Idioma.Valnumserie = IdiomaRegistroEspannol._valnumserie;
                        Idioma.IngrErrNumActivo = IdiomaRegistroEspannol._ingrErrNumActivo;
                        Idioma.Atencion = IdiomaRegistroEspannol._atencion;
                        Idioma.Ms1 = IdiomaRegistroEspannol._ms1;
                        Idioma.Ms2 = IdiomaRegistroEspannol._ms2;
                        Idioma.Ms3 = IdiomaRegistroEspannol._ms3;
                        Idioma.NFEti = IdiomaRegistroEspannol._NFEti;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    case "EN":
                        Idioma.Titulo = IdiomaRegistroIngles._titulo;
                        Idioma.NumActivo = IdiomaRegistroIngles._numActivo;
                        Idioma.NumPlaca = IdiomaRegistroIngles._numPlaca;
                        Idioma.Categoria = IdiomaRegistroIngles._categoria;
                        Idioma.Estado = IdiomaRegistroIngles._estado;
                        Idioma.Marca = IdiomaRegistroIngles._marca;
                        Idioma.Ubicacion = IdiomaRegistroIngles._ubicacion;
                        Idioma.Modelo = IdiomaRegistroIngles._modelo;
                        Idioma.Observaciones = IdiomaRegistroIngles._observaciones;
                        Idioma.SelectUbi = IdiomaRegistroIngles._selectUbi;
                        Idioma.ValidEstado = IdiomaRegistroIngles._validEstado;
                        Idioma.ValidCategoria = IdiomaRegistroIngles._validCategoria;
                        Idioma.ValidNumActivo = IdiomaRegistroIngles._validNumActivo;
                        Idioma.ActualizaError = IdiomaRegistroIngles._actualizarError;
                        Idioma.AgregarError = IdiomaRegistroIngles._agregarError;
                        Idioma.AgregarCorrecto = IdiomaRegistroIngles._agregaCorrecto;
                        Idioma.ActualizaCorrecto = IdiomaRegistroIngles._actualizaCorrecto;
                        Idioma.TituloEditar = IdiomaRegistroIngles._tituloEditar;
                        Idioma.NumeroSerie = IdiomaRegistroIngles._numeroSeria;
                        Idioma.DescripcionCorta = IdiomaRegistroIngles._descripcionCorta;
                        Idioma.DescripcionCategoria = IdiomaRegistroIngles._descripcionCategoria;
                        Idioma.DescripcionEstado = IdiomaRegistroIngles._descripcionEstado;
                        Idioma.NumeroFactura = IdiomaRegistroIngles._numeroFactura;
                        Idioma.FechaCompra = IdiomaRegistroIngles._fechaCompra;
                        Idioma.CostoActivo = IdiomaRegistroIngles._costoActivo;
                        Idioma.ValidDescCorta = IdiomaRegistroIngles._validDescCorta;
                        Idioma.ValidCostoActivo = IdiomaRegistroIngles._validCostoActivo;
                        Idioma.ValidUbicacion = IdiomaRegistroIngles._validUbicacion;
                        Idioma.ValidActNumAct = IdiomaRegistroIngles._validActNumAct;
                        Idioma.NumParteActivo = IdiomaRegistroIngles._numParteActivo;
                        Idioma.Depreciado = IdiomaRegistroIngles._depreciado;
                        Idioma.Descripcion = IdiomaRegistroIngles._descripcion;
                        Idioma.DiasvidaU = IdiomaRegistroIngles._diasVidaU;
                        Idioma.CuentaContable = IdiomaRegistroIngles._cuentaContable;
                        Idioma.CentroCostos = IdiomaRegistroIngles._centroCostos;
                        Idioma.Empleado = IdiomaRegistroIngles._empleado;
                        Idioma.UbicacionB = IdiomaRegistroIngles._ubicacionB;
                        Idioma.UbicacionC = IdiomaRegistroIngles._ubicacionC;
                        Idioma.UbicacionD = IdiomaRegistroIngles._ubicacionD;
                        Idioma.FechaGarantia = IdiomaRegistroIngles._fechaGarantia;
                        Idioma.TamañoMed = IdiomaRegistroIngles._tamañoMed;
                        Idioma.MsjBtnTienda = IdiomaRegistroIngles._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaRegistroIngles._msjTienda;
                        Idioma.Color = IdiomaRegistroIngles._color;
                        Idioma.SelectFiltro = IdiomaRegistroIngles._selecFiltro;
                        Idioma.Fotos = IdiomaRegistroIngles._fotos;
                        Idioma.Costo = IdiomaRegistroIngles._costo;
                        Idioma.Buscar =IdiomaRegistroIngles._buscar;
                        Idioma.Foto1 = IdiomaRegistroIngles._foto1;
                        Idioma.Foto2 = IdiomaRegistroIngles._foto2;
                        Idioma.Foto3 = IdiomaRegistroIngles._foto3;
                        Idioma.Foto4 = IdiomaRegistroIngles._foto4;
                        Idioma.Foto5 = IdiomaRegistroIngles._foto5;
                        Idioma.Selectmsj = IdiomaRegistroIngles._selectmsj;
                        Idioma.Valnumfactura = IdiomaRegistroIngles._valnumfactura;
                        Idioma.Valnumetiqueta = IdiomaRegistroIngles._valnumetiqueta;
                        Idioma.Valmarca = IdiomaRegistroIngles._valmarca;
                        Idioma.Valmodelo = IdiomaRegistroIngles._valmodelo;
                        Idioma.Valnumserie = IdiomaRegistroIngles._valnumserie;
                        Idioma.IngrErrNumActivo = IdiomaRegistroIngles._ingrErrNumActivo;
                        Idioma.Atencion = IdiomaRegistroIngles._atencion;
                        Idioma.Ms1 = IdiomaRegistroIngles._ms1;
                        Idioma.Ms2 = IdiomaRegistroIngles._ms2;
                        Idioma.Ms3 = IdiomaRegistroIngles._ms3;

                        Idioma.NFEti = IdiomaRegistroIngles._NFEti;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:
                        Idioma.Titulo = IdiomaRegistroEspannol._titulo;
                        Idioma.NumActivo = IdiomaRegistroEspannol._numActivo;
                        Idioma.NumPlaca = IdiomaRegistroEspannol._numPlaca;
                        Idioma.Categoria = IdiomaRegistroEspannol._categoria;
                        Idioma.Estado = IdiomaRegistroEspannol._estado;
                        Idioma.Marca = IdiomaRegistroEspannol._marca;
                        Idioma.Ubicacion = IdiomaRegistroEspannol._ubicacion;
                        Idioma.Modelo = IdiomaRegistroEspannol._modelo;
                        Idioma.Observaciones = IdiomaRegistroEspannol._observaciones;
                        Idioma.SelectUbi = IdiomaRegistroEspannol._selectUbi;
                        Idioma.ValidEstado = IdiomaRegistroEspannol._validEstado;
                        Idioma.ValidCategoria = IdiomaRegistroEspannol._validCategoria;
                        Idioma.ValidNumActivo = IdiomaRegistroEspannol._validNumActivo;
                        Idioma.ActualizaError = IdiomaRegistroEspannol._actualizarError;
                        Idioma.AgregarError = IdiomaRegistroEspannol._agregarError;
                        Idioma.ActualizaCorrecto = IdiomaRegistroEspannol._actualizaCorrecto;
                        Idioma.AgregarCorrecto = IdiomaRegistroEspannol._agreggaCorrecto;
                        Idioma.TituloEditar = IdiomaRegistroEspannol._tituloEditar;
                        Idioma.NumeroSerie = IdiomaRegistroEspannol._numeroSeria;
                        Idioma.DescripcionCorta = IdiomaRegistroEspannol._descripcionCorta;
                        Idioma.DescripcionCategoria = IdiomaRegistroEspannol._descripcionCategoria;
                        Idioma.DescripcionEstado = IdiomaRegistroEspannol._descripcionEstado;
                        Idioma.NumeroFactura = IdiomaRegistroEspannol._numeroFactura;
                        Idioma.FechaCompra = IdiomaRegistroEspannol._fechaCompra;
                        Idioma.CostoActivo = IdiomaRegistroEspannol._costoActivo;
                        Idioma.ValidDescCorta = IdiomaRegistroEspannol._validDescCorta;
                        Idioma.ValidCostoActivo = IdiomaRegistroEspannol._validCostoActivo;
                        Idioma.ValidUbicacion = IdiomaRegistroEspannol._validUbicacion;
                        Idioma.ValidActNumAct = IdiomaRegistroEspannol._validActNumAct;
                        Idioma.NumParteActivo = IdiomaRegistroEspannol._numParteActivo;
                        Idioma.Depreciado = IdiomaRegistroEspannol._depreciado;
                        Idioma.Descripcion = IdiomaRegistroEspannol._descripcion;
                        Idioma.DiasvidaU = IdiomaRegistroEspannol._diasVidaU;
                        Idioma.CuentaContable = IdiomaRegistroEspannol._cuentaContable;
                        Idioma.CentroCostos = IdiomaRegistroEspannol._centroCostos;
                        Idioma.Empleado = IdiomaRegistroEspannol._empleado;
                        Idioma.UbicacionB = IdiomaRegistroEspannol._ubicacionB;
                        Idioma.UbicacionC = IdiomaRegistroEspannol._ubicacionC;
                        Idioma.UbicacionD = IdiomaRegistroEspannol._ubicacionD;
                        Idioma.FechaGarantia = IdiomaRegistroEspannol._fechaGarantia;
                        Idioma.TamañoMed = IdiomaRegistroEspannol._tamañoMed;
                        Idioma.MsjTienda = IdiomaRegistroEspannol._msjTienda;
                        Idioma.MsjBtnTienda = IdiomaRegistroEspannol._msjbtnTienda;
                        Idioma.Color = IdiomaRegistroEspannol._color;
                        Idioma.SelectFiltro = IdiomaRegistroEspannol._selecFiltro;
                        Idioma.Fotos = IdiomaRegistroEspannol._fotos;
                        Idioma.Costo = IdiomaRegistroEspannol._costo;
                        Idioma.Buscar = IdiomaRegistroEspannol._buscar;
                        Idioma.Foto1 = IdiomaRegistroEspannol._foto1;
                        Idioma.Foto2 = IdiomaRegistroEspannol._foto2;
                        Idioma.Foto3 = IdiomaRegistroEspannol._foto3;
                        Idioma.Foto4 = IdiomaRegistroEspannol._foto4;
                        Idioma.Foto5 = IdiomaRegistroEspannol._foto5;
                        Idioma.Selectmsj = IdiomaRegistroEspannol._selectmsj;
                        Idioma.Valnumfactura = IdiomaRegistroEspannol._valnumfactura;
                        Idioma.Valnumetiqueta = IdiomaRegistroEspannol._valnumetiqueta;
                        Idioma.Valmarca = IdiomaRegistroEspannol._valmarca;
                        Idioma.Valmodelo = IdiomaRegistroEspannol._valmodelo;
                        Idioma.Valnumserie = IdiomaRegistroEspannol._valnumserie;
                        Idioma.IngrErrNumActivo = IdiomaRegistroEspannol._ingrErrNumActivo;
                        Idioma.Atencion = IdiomaRegistroEspannol._atencion;
                        Idioma.Ms1 = IdiomaRegistroEspannol._ms1;
                        Idioma.Ms2 = IdiomaRegistroEspannol._ms2;
                        Idioma.Ms3 = IdiomaRegistroEspannol._ms3;

                        Idioma.NFEti = IdiomaRegistroEspannol._NFEti;
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