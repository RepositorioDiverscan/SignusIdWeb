using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas
{
    public class EIdiomaCodigoGeneral
    {
        private string _bienvenido;
        private string _parrafoCodigo1;
        private string _parrafoCodigo2;
        private string _codigoVerificacion;
        private string _ingreseCodigo;
        private string _generarCodigo;
        private string _aceptar;


        public EIdiomaCodigoGeneral() { }
        public EIdiomaCodigoGeneral(string bienvenido, string parrafoCodigo, string codigoVerificacion, string ingreseCodigo, string generarCodigo, string aceptar, string parrafoCodigo2)
        {
            Bienvenido = bienvenido;
            ParrafoCodigo1 = parrafoCodigo;
            CodigoVerificacion = codigoVerificacion;
            IngreseCodigo = ingreseCodigo;
            GenerarCodigo = generarCodigo;
            Aceptar = aceptar;
            ParrafoCodigo2 = parrafoCodigo2;
        }

        public string Bienvenido { get => _bienvenido; set => _bienvenido = value; }
        public string ParrafoCodigo1 { get => _parrafoCodigo1; set => _parrafoCodigo1 = value; }
        public string ParrafoCodigo2 { get => _parrafoCodigo2; set => _parrafoCodigo2 = value; }
        public string CodigoVerificacion { get => _codigoVerificacion; set => _codigoVerificacion = value; }
        public string IngreseCodigo { get => _ingreseCodigo; set => _ingreseCodigo = value; }
        public string GenerarCodigo { get => _generarCodigo; set => _generarCodigo = value; }
        public string Aceptar { get => _aceptar; set => _aceptar = value; }
    }
}