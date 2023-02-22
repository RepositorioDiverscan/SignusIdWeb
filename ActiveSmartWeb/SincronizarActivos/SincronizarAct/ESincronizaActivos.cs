using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.SincronizarActivos.SincronizarAct
{
    [Serializable]

    public class ESincronizaActivos
    {
        private string _numActivo;
        private string _numEtiqueta;
        private string _categoria;
        private string _estado;
        private string _marca;
        private string _modelo;
        private string _ubicacion;
        private string _descripcion;
        private int _cantidad;
        private string _costo;
        private int _idArchivo;
        private int _estadoArchivo;
        private DateTime _fechaRegistro;
        private int _idcategoria;
        private int _idestado;
        private int _idPerfilEmpresa;
        private int _idubicacion;
        private decimal _costoActivo;
        private string _estadoSincronizacionArc;
        private string _nombre;
        private DateTime _fechaCompra;
        private string _factura;
        private string _serie;
        public ESincronizaActivos() { }
        public ESincronizaActivos(int idArchivo, DateTime fecharegistro, int estadore, string estadoSincr) {
            _idArchivo = idArchivo;
            _fechaRegistro = fecharegistro;
            _estadoArchivo = estadore;
            _estadoSincronizacionArc = estadoSincr;
        }

        

            public ESincronizaActivos( string numActivo, string numEtiqueta,
            string categoria, string estado, string marca, string modelo, string ubicacion, 
            string descripcion,int cantidad, string costo)
        {
            _numActivo = numActivo;
            _numEtiqueta = numEtiqueta;
            _categoria = categoria;
            _estado = estado;
            _marca = marca;
            _modelo = modelo;
            _ubicacion = ubicacion;
            _descripcion = descripcion;
            _cantidad = cantidad;
            _costo = costo;
        }



        public ESincronizaActivos(string numActivo, string numEtiqueta, string descripcion,
             int estado, int categoria, int ubicacion, int idPerfilE, string marca, string modelo, 
            decimal costo)
        {
            _numActivo = numActivo;
            _numEtiqueta = numEtiqueta;
            _descripcion = descripcion;
            _idestado = estado;
            _idcategoria = categoria;
            _idubicacion = ubicacion;
            _idPerfilEmpresa = idPerfilE;
            _marca = marca;
            _modelo = modelo;
            _costoActivo = costo;
        }

        public ESincronizaActivos(string numEtiqueta, string descripcion, string categoria, string estado, string ubicacion, string marca, string modelo, string serie, string costo, string factura, DateTime fechaCompra)
        {
            NumEtiqueta = numEtiqueta;
            Descripcion = descripcion;
            Categoria = categoria;
            Estado = estado;
            Ubicacion = ubicacion;
            Marca = marca;
            Modelo = modelo;
            Serie = serie;
            Costo = costo;
            Factura = factura;
            FechaCompra = fechaCompra;
        }


        public string NumActivo { get => _numActivo; set => _numActivo = value; }
        public string NumEtiqueta { get => _numEtiqueta; set => _numEtiqueta = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public string Costo { get => _costo; set => _costo = value; }
        public int IdArchivo { get => _idArchivo; set => _idArchivo = value; }
        public int EstadoArchivo { get => _estadoArchivo; set => _estadoArchivo = value; }
        public DateTime FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
      
        public decimal CostoActivo { get => _costoActivo; set => _costoActivo = value; }
        public int Idcategoria { get => _idcategoria; set => _idcategoria = value; }
        public int Idestado { get => _idestado; set => _idestado = value; }
        public int IdPerfilEmpresa { get => _idPerfilEmpresa; set => _idPerfilEmpresa = value; }
        public int Idubicacion { get => _idubicacion; set => _idubicacion = value; }
        public string EstadoSincronizacionArc { get => _estadoSincronizacionArc; set => _estadoSincronizacionArc = value; }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        public string Factura { get => _factura; set => _factura = value; }
        public string Serie { get => _serie; set => _serie = value; }
    }
}