using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.SincronizarActivos.Idioma
{
    public partial class IdiomaSincronizacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaSincronizarGeneral idioma = new IdiomaSincronizarGeneral();
            try
            {
                switch (Request.Form["idioma"])
                {
                    case "ES":
                        idioma.Titulo = IdiomaSincronizarEspanol._titulo;
                        idioma.NombreArch = IdiomaSincronizarEspanol._nombreArch;
                        idioma.TotalAct = IdiomaSincronizarEspanol._totalAct;
                        idioma.ActivosCorr = IdiomaSincronizarEspanol._activosCorr;
                        idioma.ActivosIncorr = IdiomaSincronizarEspanol._activosIncorr;
                        idioma.ActivPend = IdiomaSincronizarEspanol._activPend;
                        idioma.Tienda = IdiomaSincronizarEspanol._tienda;
                        idioma.NumAct = IdiomaSincronizarEspanol._numAct;
                        idioma.NumEtiq = IdiomaSincronizarEspanol._numEtiq;
                        idioma.Categ = IdiomaSincronizarEspanol._categ;
                        idioma.Marca = IdiomaSincronizarEspanol._marca;
                        idioma.Modelo = IdiomaSincronizarEspanol._modelo;
                        idioma.Ubicacion = IdiomaSincronizarEspanol._ubicacion;
                        idioma.Observacion = IdiomaSincronizarEspanol._observacion;
                        idioma.EstadoSinc = IdiomaSincronizarEspanol._estadoSinc;
                        idioma.Numero = IdiomaSincronizarEspanol._numero;
                        idioma.Fecha = IdiomaSincronizarEspanol._fecha;
                        idioma.Estado = IdiomaSincronizarEspanol._estado;
                        idioma.BtnSinc = IdiomaSincronizarEspanol._btnSinc;
                        idioma.IrTienda = IdiomaSincronizarEspanol._irTienda;
                        idioma.ActDisp = IdiomaSincronizarEspanol._actDisp;
                        idioma.Msjdescarga = IdiomaSincronizarEspanol._msjdescarga;
                        idioma.MsjIntenteloNuevo = IdiomaSincronizarEspanol._msjIntenteloNuevo;
                        idioma.Costo = IdiomaSincronizarEspanol._costo;
                        idioma.MsjRegistrado = IdiomaSincronizarEspanol._msjRegistrado;
                        idioma.MsjUbicacion = IdiomaSincronizarEspanol._msjUbicacion;
                        idioma.MsjCategoria = IdiomaSincronizarEspanol._msjCategoria;
                        idioma.MsjEstado = IdiomaSincronizarEspanol._msjEstado;
                        idioma.RegistroEx = IdiomaSincronizarEspanol._registroEx;
                        idioma.MsjMitad = IdiomaSincronizarEspanol._msjMitad;
                        idioma.MsjEliminado = IdiomaSincronizarEspanol._msjEliminado;
                        idioma.MsjErrorEjec = IdiomaSincronizarEspanol._msjErrorEjec;
                        idioma.MsjExitoEjec = IdiomaSincronizarEspanol._msjExitoEjec;
                        idioma.CargaArchivo = IdiomaSincronizarEspanol._cargaArchivo;
                        idioma.Atencion = IdiomaSincronizarEspanol._atencion;
                        idioma.Msj1 = IdiomaSincronizarEspanol._msj1;
                        idioma.Msj2 = IdiomaSincronizarEspanol._msj2;
                        idioma.TblNEtiqueta = IdiomaSincronizarEspanol._tblNEtiqueta;
                        idioma.TblDescLar = IdiomaSincronizarEspanol._tblDescLar;
                        idioma.TblCategoria = IdiomaSincronizarEspanol._tblCategoria;
                        idioma.TblEstado = IdiomaSincronizarEspanol._tblEstado;
                        idioma.TblUbicacion = IdiomaSincronizarEspanol._tblUbicacion;
                        idioma.TblMarca = IdiomaSincronizarEspanol._tblMarca;
                        idioma.TblModelo = IdiomaSincronizarEspanol._tblModelo;
                        idioma.TblnSerie = IdiomaSincronizarEspanol._tblnSerie;
                        idioma.TblCosto = IdiomaSincronizarEspanol._tblCosto;
                        idioma.TblNFactura = IdiomaSincronizarEspanol._tblNFactura;
                        idioma.TblFechaComp = IdiomaSincronizarEspanol._tblFechaComp;
                        idioma.TblEstadosSinc = IdiomaSincronizarEspanol._tblEstadosSinc;
                        Response.Write(JsonConvert.SerializeObject(idioma, Formatting.Indented));
                        break;
                    case "EN":
                        idioma.Titulo = IdiomaSincronizarIngles._titulo;
                        idioma.NombreArch = IdiomaSincronizarIngles._nombreArch;
                        idioma.TotalAct = IdiomaSincronizarIngles._totalAct;
                        idioma.ActivosCorr = IdiomaSincronizarIngles._activosCorr;
                        idioma.ActivosIncorr = IdiomaSincronizarIngles._activosIncorr;
                        idioma.ActivPend = IdiomaSincronizarIngles._activPend;
                        idioma.Tienda = IdiomaSincronizarIngles._tienda;
                        idioma.NumAct = IdiomaSincronizarIngles._numAct;
                        idioma.NumEtiq = IdiomaSincronizarIngles._numEtiq;
                        idioma.Categ = IdiomaSincronizarIngles._categ;
                        idioma.Marca = IdiomaSincronizarIngles._marca;
                        idioma.Modelo = IdiomaSincronizarIngles._modelo;
                        idioma.Ubicacion = IdiomaSincronizarIngles._ubicacion;
                        idioma.Observacion = IdiomaSincronizarIngles._observacion;
                        idioma.EstadoSinc = IdiomaSincronizarIngles._estadoSinc;
                        idioma.Numero = IdiomaSincronizarIngles._numero;
                        idioma.Fecha = IdiomaSincronizarIngles._fecha;
                        idioma.Estado = IdiomaSincronizarIngles._estado;
                        idioma.BtnSinc = IdiomaSincronizarIngles._btnSinc;
                        idioma.IrTienda = IdiomaSincronizarIngles._irTienda;
                        idioma.ActDisp = IdiomaSincronizarIngles._actDisp;
                        idioma.Msjdescarga = IdiomaSincronizarIngles._msjdescarga;
                        idioma.MsjIntenteloNuevo = IdiomaSincronizarIngles._msjIntenteloNuevo;
                        idioma.Costo = IdiomaSincronizarIngles._costo;
                        idioma.MsjRegistrado = IdiomaSincronizarIngles._msjRegistrado;
                        idioma.MsjUbicacion = IdiomaSincronizarIngles._msjUbicacion;
                        idioma.MsjCategoria = IdiomaSincronizarIngles._msjCategoria;
                        idioma.MsjEstado = IdiomaSincronizarIngles._msjEstado;
                        idioma.RegistroEx = IdiomaSincronizarIngles._registroEx;
                        idioma.MsjMitad = IdiomaSincronizarIngles._msjMitad;
                        idioma.MsjEliminado = IdiomaSincronizarIngles._msjEliminado;
                        idioma.MsjErrorEjec = IdiomaSincronizarIngles._msjErrorEjec;
                        idioma.MsjExitoEjec = IdiomaSincronizarIngles._msjExitoEjec;
                        idioma.CargaArchivo = IdiomaSincronizarIngles._cargaArchivo;
                        idioma.Atencion = IdiomaSincronizarIngles._atencion;
                        idioma.Msj1 = IdiomaSincronizarIngles._msj1;
                        idioma.Msj2 = IdiomaSincronizarIngles._msj2;
                        idioma.TblNEtiqueta = IdiomaSincronizarIngles._tblNEtiqueta;
                        idioma.TblDescLar = IdiomaSincronizarIngles._tblDescLar;
                        idioma.TblCategoria = IdiomaSincronizarIngles._tblCategoria;
                        idioma.TblEstado = IdiomaSincronizarIngles._tblEstado;
                        idioma.TblUbicacion = IdiomaSincronizarIngles._tblUbicacion;
                        idioma.TblMarca = IdiomaSincronizarIngles._tblMarca;
                        idioma.TblModelo = IdiomaSincronizarIngles._tblModelo;
                        idioma.TblnSerie = IdiomaSincronizarIngles._tblnSerie;
                        idioma.TblCosto = IdiomaSincronizarIngles._tblCosto;
                        idioma.TblNFactura = IdiomaSincronizarIngles._tblNFactura;
                        idioma.TblFechaComp = IdiomaSincronizarIngles._tblFechaComp;
                        idioma.TblEstadosSinc = IdiomaSincronizarIngles._tblEstadosSinc;
                        Response.Write(JsonConvert.SerializeObject(idioma, Formatting.Indented));
                        break;
                    default:
                        idioma.Titulo = IdiomaSincronizarEspanol._titulo;
                        idioma.NombreArch = IdiomaSincronizarEspanol._nombreArch;
                        idioma.TotalAct = IdiomaSincronizarEspanol._totalAct;
                        idioma.ActivosCorr = IdiomaSincronizarEspanol._activosCorr;
                        idioma.ActivosIncorr = IdiomaSincronizarEspanol._activosIncorr;
                        idioma.ActivPend = IdiomaSincronizarEspanol._activPend;
                        idioma.Tienda = IdiomaSincronizarEspanol._tienda;
                        idioma.NumAct = IdiomaSincronizarEspanol._numAct;
                        idioma.NumEtiq = IdiomaSincronizarEspanol._numEtiq;
                        idioma.Categ = IdiomaSincronizarEspanol._categ;
                        idioma.Marca = IdiomaSincronizarEspanol._marca;
                        idioma.Modelo = IdiomaSincronizarEspanol._modelo;
                        idioma.Ubicacion = IdiomaSincronizarEspanol._ubicacion;
                        idioma.Observacion = IdiomaSincronizarEspanol._observacion;
                        idioma.EstadoSinc = IdiomaSincronizarEspanol._estadoSinc;
                        idioma.Numero = IdiomaSincronizarEspanol._numero;
                        idioma.Fecha = IdiomaSincronizarEspanol._fecha;
                        idioma.Estado = IdiomaSincronizarEspanol._estado;
                        idioma.BtnSinc = IdiomaSincronizarEspanol._btnSinc;
                        idioma.IrTienda = IdiomaSincronizarEspanol._irTienda;
                        idioma.ActDisp = IdiomaSincronizarEspanol._actDisp;
                        idioma.Msjdescarga = IdiomaSincronizarEspanol._msjdescarga;
                        idioma.MsjIntenteloNuevo = IdiomaSincronizarEspanol._msjIntenteloNuevo;
                        idioma.Costo = IdiomaSincronizarEspanol._costo;
                        idioma.MsjRegistrado = IdiomaSincronizarEspanol._msjRegistrado;
                        idioma.MsjEstado = IdiomaSincronizarEspanol._msjEstado;
                        idioma.MsjUbicacion = IdiomaSincronizarEspanol._msjUbicacion;
                        idioma.MsjCategoria = IdiomaSincronizarEspanol._msjCategoria;
                        idioma.RegistroEx = IdiomaSincronizarEspanol._registroEx;
                        idioma.MsjMitad = IdiomaSincronizarEspanol._msjMitad;
                        idioma.MsjErrorEjec = IdiomaSincronizarEspanol._msjErrorEjec;
                        idioma.MsjEliminado = IdiomaSincronizarEspanol._msjEliminado;
                        idioma.MsjExitoEjec = IdiomaSincronizarEspanol._msjExitoEjec;
                        idioma.CargaArchivo = IdiomaSincronizarEspanol._cargaArchivo;
                        idioma.Atencion = IdiomaSincronizarEspanol._atencion;
                        idioma.Msj1 = IdiomaSincronizarEspanol._msj1;
                        idioma.Msj2 = IdiomaSincronizarEspanol._msj2;
                        idioma.TblNEtiqueta = IdiomaSincronizarEspanol._tblNEtiqueta;
                        idioma.TblDescLar = IdiomaSincronizarEspanol._tblDescLar;
                        idioma.TblCategoria = IdiomaSincronizarEspanol._tblCategoria;
                        idioma.TblEstado = IdiomaSincronizarEspanol._tblEstado;
                        idioma.TblUbicacion = IdiomaSincronizarEspanol._tblUbicacion;
                        idioma.TblMarca = IdiomaSincronizarEspanol._tblMarca;
                        idioma.TblModelo = IdiomaSincronizarEspanol._tblModelo;
                        idioma.TblnSerie = IdiomaSincronizarEspanol._tblnSerie;
                        idioma.TblCosto = IdiomaSincronizarEspanol._tblCosto;
                        idioma.TblNFactura = IdiomaSincronizarEspanol._tblNFactura;
                        idioma.TblFechaComp = IdiomaSincronizarEspanol._tblFechaComp;
                        idioma.TblEstadosSinc = IdiomaSincronizarEspanol._tblEstadosSinc;
                        Response.Write(JsonConvert.SerializeObject(idioma, Formatting.Indented));
                        break;
                }
            }catch(Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }

        }
    }
}