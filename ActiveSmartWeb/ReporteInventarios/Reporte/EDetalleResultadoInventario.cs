using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteInventariosPrueba.DetalleReporteInventario
{
    public class EDetalleResultadoInventario
    {

        private int _id_activo;
        private string _numeroActivo;
        private string _placaActivo;
        private string _descripcionActivo;
        private string _observacionActivoToma;
        private string _resultadoInventario;
        public EDetalleResultadoInventario()
        {

        }

        public EDetalleResultadoInventario(int id_activo, string numeroActivo, string placaActivo, string descripcionActivo, string observacionActivoToma, string resultadoInventario)
        {
            _id_activo = id_activo;
            _numeroActivo = numeroActivo;
            _placaActivo = placaActivo;
            _descripcionActivo = descripcionActivo;
            _observacionActivoToma = observacionActivoToma;
            _resultadoInventario = resultadoInventario;
        }

        public int Id_activo { get => _id_activo; set => _id_activo = value; }
        public string NumeroActivo { get => _numeroActivo; set => _numeroActivo = value; }
        public string PlacaActivo { get => _placaActivo; set => _placaActivo = value; }
        public string DescripcionActivo { get => _descripcionActivo; set => _descripcionActivo = value; }
        public string ObservacionActivoToma { get => _observacionActivoToma; set => _observacionActivoToma = value; }
        public string ResultadoInventario { get => _resultadoInventario; set => _resultadoInventario = value; }
    }
}