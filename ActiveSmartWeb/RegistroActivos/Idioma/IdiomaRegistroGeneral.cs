using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroActivos.Idioma
{
    public class IdiomaRegistroGeneral
    {
        private string _titulo;
        private string _marca;
        private string _modelo;
        private string _observaciones;
        private string _categoria;
        private string _estado;
        private string _ubicacion;
        private string _numActivo;
        private string _numPlaca;
        private string _selectUbi;
        private string _validEstado;
        private string _validCategoria;
        private string _validNumActivo;
        private string _actualizaError;
        private string _agregarError;
        private string _agregarCorrecto;
        private string _actualizaCorrecto;
        private string _tituloEditar;
        private string _numeroSerie;
        private string _descripcionCorta;
        private string _descripcionCategoria;
        private string _descripcionEstado;
        private string _numeroFactura;
        private string _fechaCompra;
        private string _costoActivo;
        private string _validDescCorta;
        private string _validCostoActivo;
        private string _validUbicacion;
        private string _validActNumAct;
        private string _numParteActivo;
        private string _depreciado;
        private string _descripcion;
        private string _diasvidaU;
        private string _cuentaContable;
        private string _centroCostos;
        private string _empleado;
        private string _ubicacionB;
        private string _ubicacionC;
        private string _ubicacionD;
        private string _fechaGarantia;
        private string _tamañoMed;
        private string _color;
        private string _msjTienda;
        private string _msjBtnTienda;
        private string _selectFiltro;
        private string _selectmsj;
        private string _buscar;
        private string _costo;
        private string _fotos;
        private string _foto1;
        private string _foto2;
        private string _foto3;
        private string _foto4;
        private string _foto5;
        private string _valnumfactura;
        private string _valnumetiqueta;
        private string _valmarca;
        private string _valmodelo;
        private string _valnumserie;
        private string _ingrErrNumActivo;
        private string _atencion;
        private string _ms1;
        private string _ms2;
        private string _ms3;
        private string _NFEti;

        public IdiomaRegistroGeneral()
        {
        }

        public IdiomaRegistroGeneral(string titulo, string marca, string modelo, string observaciones, string categoria, string estado, string ubicacion, string numActivo, string numPlaca, string selectUbi, string validEstado, string validCategoria, string validNumActivo, string actualizaError, string agregarError, string agregarCorrecto, string actualizaCorrecto, string tituloEditar, string numeroSerie, string descripcionCorta, string descripcionCategoria, string descripcionEstado, string numeroFactura, string fechaCompra, string costoActivo, string validDescCorta, string validCostoActivo, string validUbicacion, string validActNumAct, string numParteActivo, string depreciado, string descripcion, string diasvidaU, string cuentaContable, string centroCostos, string empleado, string ubicacionB, string ubicacionC, string ubicacionD, string fechaGarantia, string tamañoMed, string color, string msjTienda, string msjBtnTienda, string selectFiltro, string buscar, string costo, string fotos, string foto1, string foto2, string foto3, string foto4, string foto5, string selectmsj = null, string valnumfactura = null, string valnumetiqueta = null, string valmarca = null, string valmodelo = null, string valnumserie = null, string ingrErrNumActivo = null, string atencion = null, string ms1 = null, string ms2 = null, string nFEti = null, string ms3 = null)
        {
            Titulo = titulo;
            Marca = marca;
            Modelo = modelo;
            Observaciones = observaciones;
            Categoria = categoria;
            Estado = estado;
            Ubicacion = ubicacion;
            NumActivo = numActivo;
            NumPlaca = numPlaca;
            SelectUbi = selectUbi;
            ValidEstado = validEstado;
            ValidCategoria = validCategoria;
            ValidNumActivo = validNumActivo;
            ActualizaError = actualizaError;
            AgregarError = agregarError;
            AgregarCorrecto = agregarCorrecto;
            ActualizaCorrecto = actualizaCorrecto;
            TituloEditar = tituloEditar;
            NumeroSerie = numeroSerie;
            DescripcionCorta = descripcionCorta;
            DescripcionCategoria = descripcionCategoria;
            DescripcionEstado = descripcionEstado;
            NumeroFactura = numeroFactura;
            FechaCompra = fechaCompra;
            CostoActivo = costoActivo;
            ValidDescCorta = validDescCorta;
            ValidCostoActivo = validCostoActivo;
            ValidUbicacion = validUbicacion;
            ValidActNumAct = validActNumAct;
            NumParteActivo = numParteActivo;
            Depreciado = depreciado;
            Descripcion = descripcion;
            DiasvidaU = diasvidaU;
            CuentaContable = cuentaContable;
            CentroCostos = centroCostos;
            Empleado = empleado;
            UbicacionB = ubicacionB;
            UbicacionC = ubicacionC;
            UbicacionD = ubicacionD;
            FechaGarantia = fechaGarantia;
            TamañoMed = tamañoMed;
            Color = color;
            MsjTienda = msjTienda;
            MsjBtnTienda = msjBtnTienda;
            SelectFiltro = selectFiltro;
            Buscar = buscar;
            Costo = costo;
            Fotos = fotos;
            Foto1 = foto1;
            Foto2 = foto2;
            Foto3 = foto3;
            Foto4 = foto4;
            Foto5 = foto5;
            Selectmsj = selectmsj;
            Valnumfactura = valnumfactura;
            Valnumetiqueta = valnumetiqueta;
            Valmarca = valmarca;
            Valmodelo = valmodelo;
            Valnumserie = valnumserie;
            IngrErrNumActivo = ingrErrNumActivo;
            Atencion = atencion;
            Ms1 = ms1;
            Ms2 = ms2;
            Ms3 = ms3;
            NFEti = nFEti;
        }


        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }
        public string NumActivo { get => _numActivo; set => _numActivo = value; }
        public string NumPlaca { get => _numPlaca; set => _numPlaca = value; }
        public string SelectUbi { get => _selectUbi; set => _selectUbi = value; }
        public string ValidEstado { get => _validEstado; set => _validEstado = value; }
        public string ValidCategoria { get => _validCategoria; set => _validCategoria = value; }
        public string ValidNumActivo { get => _validNumActivo; set => _validNumActivo = value; }
        public string ActualizaError { get => _actualizaError; set => _actualizaError = value; }
        public string AgregarError { get => _agregarError; set => _agregarError = value; }
        public string AgregarCorrecto { get => _agregarCorrecto; set => _agregarCorrecto = value; }
        public string ActualizaCorrecto { get => _actualizaCorrecto; set => _actualizaCorrecto = value; }
        public string TituloEditar { get => _tituloEditar; set => _tituloEditar = value; }
        public string NumeroSerie { get => _numeroSerie; set => _numeroSerie = value; }
        public string DescripcionCorta { get => _descripcionCorta; set => _descripcionCorta = value; }
        public string DescripcionCategoria { get => _descripcionCategoria; set => _descripcionCategoria = value; }
        public string DescripcionEstado { get => _descripcionEstado; set => _descripcionEstado = value; }
        public string NumeroFactura { get => _numeroFactura; set => _numeroFactura = value; }
        public string FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        public string CostoActivo { get => _costoActivo; set => _costoActivo = value; }
        public string ValidDescCorta { get => _validDescCorta; set => _validDescCorta = value; }
        public string ValidCostoActivo { get => _validCostoActivo; set => _validCostoActivo = value; }
        public string ValidUbicacion { get => _validUbicacion; set => _validUbicacion = value; }
        public string ValidActNumAct { get => _validActNumAct; set => _validActNumAct = value; }
        public string NumParteActivo { get => _numParteActivo; set => _numParteActivo = value; }
        public string Depreciado { get => _depreciado; set => _depreciado = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string DiasvidaU { get => _diasvidaU; set => _diasvidaU = value; }
        public string CuentaContable { get => _cuentaContable; set => _cuentaContable = value; }
        public string CentroCostos { get => _centroCostos; set => _centroCostos = value; }
        public string Empleado { get => _empleado; set => _empleado = value; }
        public string UbicacionB { get => _ubicacionB; set => _ubicacionB = value; }
        public string UbicacionC { get => _ubicacionC; set => _ubicacionC = value; }
        public string UbicacionD { get => _ubicacionD; set => _ubicacionD = value; }
        public string FechaGarantia { get => _fechaGarantia; set => _fechaGarantia = value; }
        public string TamañoMed { get => _tamañoMed; set => _tamañoMed = value; }
        public string Color { get => _color; set => _color = value; }
        public string MsjTienda { get => _msjTienda; set => _msjTienda = value; }
        public string MsjBtnTienda { get => _msjBtnTienda; set => _msjBtnTienda = value; }
        public string SelectFiltro { get => _selectFiltro; set => _selectFiltro = value; }
        public string Buscar { get => _buscar; set => _buscar = value; }
        public string Costo { get => _costo; set => _costo = value; }
        public string Fotos { get => _fotos; set => _fotos = value; }
        public string Foto1 { get => _foto1; set => _foto1 = value; }
        public string Foto2 { get => _foto2; set => _foto2 = value; }
        public string Foto3 { get => _foto3; set => _foto3 = value; }
        public string Foto4 { get => _foto4; set => _foto4 = value; }
        public string Foto5 { get => _foto5; set => _foto5 = value; }
        public string Selectmsj { get => _selectmsj; set => _selectmsj = value; }
        public string Valnumfactura { get => _valnumfactura; set => _valnumfactura = value; }
        public string Valnumetiqueta { get => _valnumetiqueta; set => _valnumetiqueta = value; }
        public string Valmarca { get => _valmarca; set => _valmarca = value; }
        public string Valmodelo { get => _valmodelo; set => _valmodelo = value; }
        public string Valnumserie { get => _valnumserie; set => _valnumserie = value; }
        public string IngrErrNumActivo { get => _ingrErrNumActivo; set => _ingrErrNumActivo = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
        public string Ms1 { get => _ms1; set => _ms1 = value; }
        public string Ms2 { get => _ms2; set => _ms2 = value; }
        public string Ms3 { get => _ms3; set => _ms3 = value; }
        public string NFEti { get => _NFEti; set => _NFEti = value; }
    }
    }