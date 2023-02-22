using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteInventariosPrueba.Encabezados
{
    public class EReporteFisico
    {
        private int _idTomaFisica;
        private string _nombre;
        private string _descripcion;
        private DateTime _fechaInicial;
        private DateTime _fechaFinal;
        private int _categoria;
        private string _nombreCategoria;
        private int _cantidadActivos;
        private string _nombreUsuario;

        public EReporteFisico()
        {
        }

        public EReporteFisico(int idTomaFisica, string nombre, string descripcion, DateTime fechaInicial, DateTime fechaFinal, int categoria, string nombreCategoria, int cantidadActivos, string nombreUsuario)
        {
            _idTomaFisica = idTomaFisica;
            _nombre = nombre;
            _descripcion = descripcion;
            _fechaInicial = fechaInicial;
            _fechaFinal = fechaFinal;
            _categoria = categoria;
            _nombreCategoria = nombreCategoria;
            _cantidadActivos = cantidadActivos;
            _nombreUsuario = nombreUsuario;
        }

        public int IdTomaFisica { get => _idTomaFisica; set => _idTomaFisica = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public DateTime FechaInicial { get => _fechaInicial; set => _fechaInicial = value; }
        public DateTime FechaFinal { get => _fechaFinal; set => _fechaFinal = value; }
        public int Categoria { get => _categoria; set => _categoria = value; }
        public string NombreCategoria { get => _nombreCategoria; set => _nombreCategoria = value; }
        public int CantidadActivos { get => _cantidadActivos; set => _cantidadActivos = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
    }
}