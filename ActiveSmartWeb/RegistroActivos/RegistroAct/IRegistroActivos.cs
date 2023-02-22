using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroActivos.RegistroAct
{
    public interface IRegistroActivos
    {
        List<ERegistroActivos> ConsultaRegistroActivo ();
        string InsertarActivoFijo(string numeroActivo, string placaActivo, string marca, string modelo,
                                       int idEstadoActivo, int idCategoriaActivo, int idUbicaionA, int idPerfilEmpresa, string numeroSerie,
                                       string descripcionCorta, string descripcionCategoria, string descripcionEstado, string numeroFactura,
                                       DateTime fechaCompra, decimal costoActivo);
        string ActualizaActivoFijo (int IdActivo, string numeroActivo, string placaActivo, string marca, string modelo,
                                       int idEstadoActivo, int idCategoriaActivo, int idUbicaionA, string numeroSerie, string descripcionCosto,
                                       string descripcionCateogoria, string descripcionEstado, string numeroFactura, DateTime fechaCompra,
                                       decimal costoActivo);
    }
}