using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ActualizacionActivos.Idioma
{
    public class IdiomaActualizGeneral
    {
        private string _titulo;
        private string _selectAct;
        private string _numActivo;
        private string _placaActivo;
        private string _descripcion;
        private string _idPerfilEmpresa;
        private string _idEstadoActivo;
        private string _idCategoria;
        private string _idUbicacionA;
        private string _marca;
        private string _modelo;
        private string _serie;
        private string _observacion;
        private string _fechaBaja;
        private string _numerotag;
        private string _fechaRegistro;
        private string _selectFiltro;
        private string _selectmsj;
        private string _ingrErrDescripcion;
        private string _ingrErrNumActivo;
        private string _ingrErrNumPlaca;
        public IdiomaActualizGeneral()
        {

        }
        public IdiomaActualizGeneral(string titulo, string selectAct, string numActivo, string placaActivo, string descripcion,
            string idPerfilEmpresa, string idEstado, string idcategoria, string idubicacion, string marca, string modelo,
            string serie, string observacion, string fechabaja, string numerotag, string fecharegistro, string selectfiltro,
            string selectmsj, string ingrErrNumPlaca, string ingrErrNumActivo, string ingrErrDescripcion)
        {
            _titulo = titulo;
            _selectAct = selectAct;
            _numActivo = numActivo;
            _placaActivo = placaActivo;
            _descripcion = descripcion;
            _idPerfilEmpresa = idPerfilEmpresa;
            _idEstadoActivo = idEstado;
            _idCategoria = idcategoria;
            _idUbicacionA = idubicacion;
            _marca = marca;
            _modelo = modelo;
            _serie = serie;
            _observacion = observacion;
            _fechaBaja = fechabaja;
            _numerotag = numerotag;
            _fechaRegistro = fecharegistro;
            _selectFiltro = selectfiltro;
            _selectmsj = selectmsj;
            _ingrErrDescripcion = ingrErrDescripcion;
            _ingrErrNumActivo = ingrErrNumActivo;
            _ingrErrNumPlaca = ingrErrNumPlaca;

        }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string SelectAct { get => _selectAct; set => _selectAct = value; }
        public string NumActivo { get => _numActivo; set => _numActivo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string IdPerfilEmpresa { get => _idPerfilEmpresa; set => _idPerfilEmpresa = value; }
        public string IdEstadoActivo { get => _idEstadoActivo; set => _idEstadoActivo = value; }
        public string IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string IdUbicacionA { get => _idUbicacionA; set => _idUbicacionA = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Serie { get => _serie; set => _serie = value; }
        public string Observacion { get => _observacion; set => _observacion = value; }
        public string FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public string Numerotag { get => _numerotag; set => _numerotag = value; }
        public string FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public string PlacaActivo { get => _placaActivo; set => _placaActivo = value; }
        public string SelectFiltro { get => _selectFiltro; set => _selectFiltro = value; }
        public string Selectmsj { get => _selectmsj; set => _selectmsj = value; }
        public string IngrErrDescripcion { get => _ingrErrDescripcion; set => _ingrErrDescripcion = value; }
        public string IngrErrNumActivo { get => _ingrErrNumActivo; set => _ingrErrNumActivo = value; }
        public string IngrErrNumPlaca { get => _ingrErrNumPlaca; set => _ingrErrNumPlaca = value; }
    }
}