using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteActivos.ReporteActivos
{
    [Serializable]
    public class EReporteActivos
    {
        private int _idActivo;
        private string _numActivo;
        private string _numPlaca;
        private string _descripcionActivo;
        private int    _idEstado;
        private string _nombreEstado;
        private int    _idCategoria;
        private string _nombreCategoria;
        private int    _idUbicacionA;
        private string _nombreUbicacionA;
        private DateTime _fechaActualizacon;
        private DateTime _fechaRegistro;
        public EReporteActivos() { }
        public EReporteActivos(int idActivo, string numActivo, string numPlaca, string descripcion, int idEstado,
            int idCategoria, int idUbicacionA, string nombreEstado, string nombreCategoria,
            string nombreUbicacion, DateTime fechaRegistro, DateTime fechaActualizacion)
        {
            _idActivo = idActivo;
            _numActivo = numActivo;
            _numPlaca = numPlaca;
            _descripcionActivo = descripcion;
            _idEstado = idEstado;
            _idCategoria = idCategoria;
            _idUbicacionA = idUbicacionA;
            _nombreEstado = nombreEstado;
            _nombreCategoria = nombreCategoria;
            _nombreUbicacionA = nombreUbicacion;
            _fechaActualizacon = fechaActualizacion;
            _fechaRegistro = fechaRegistro;

        }
   
        public string NumActivo { get => _numActivo; set => _numActivo = value; }
        public string NumPlaca { get => _numPlaca; set => _numPlaca = value; }
        public string DescripcionActivo { get => _descripcionActivo; set => _descripcionActivo = value; }
        public int IdEstado { get => _idEstado; set => _idEstado = value; }
        public string NombreEstado { get => _nombreEstado; set => _nombreEstado = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string NombreCategoria { get => _nombreCategoria; set => _nombreCategoria = value; }
        public int IdUbicacionA { get => _idUbicacionA; set => _idUbicacionA = value; }
        public string NombreUbicacionA { get => _nombreUbicacionA; set => _nombreUbicacionA = value; }
        public DateTime FechaActualizacon { get => _fechaActualizacon; set => _fechaActualizacon = value; }
        public DateTime FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public int IdActivo { get => _idActivo; set => _idActivo = value; }

        public string FechaActualizaMostrar { get { return FechaActualizacon.ToShortDateString(); } }
        public string FechaRegistroMostrar { get { return FechaRegistro.ToShortDateString(); } }

    }
}