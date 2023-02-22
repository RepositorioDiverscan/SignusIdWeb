using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.MisCompras.IdiomaMisCompras
{
    public class EIdiomaMiscomprasGeneral
    {

        private string _titulo;
        private string _titulo1tablainfo;
        private string _titulo2tablainfo;
        private string _BotonRenovar;
        private string _TituloAdicionales;
        private string _titulo1tablaAdicionales;
        private string _titulo2tablaAdicionales;
        private string _titulo3tablaAdicionales;
        private string _textoLeyenda;
        private string _botonIrTienda;
        private string _msj1;
        private string _msj2;

        public EIdiomaMiscomprasGeneral() { }

        public EIdiomaMiscomprasGeneral(string titulo, string titulo1tablainfo, string titulo2tablainfo, string botonrenovar, string tituloadicionales, string titulo1tablaadicionales, string titulo3tablaadicionales, string titulo2tablaadicionales, string textoleyenda, string botontienda, string msj1, string msj2)
        {

            _titulo = titulo;
            _titulo1tablainfo = titulo1tablainfo;
            _titulo2tablainfo = titulo2tablainfo;
            _BotonRenovar = botonrenovar;
            _TituloAdicionales = tituloadicionales;
            _titulo1tablaAdicionales = titulo1tablaadicionales;
            _titulo2tablaAdicionales = titulo2tablaadicionales;
            _titulo3tablaAdicionales = titulo3tablaadicionales;
            _textoLeyenda = textoleyenda;
            _botonIrTienda = botontienda;
            _msj1 = msj1;
            _msj2 = msj2;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Titulo1TablaInfo { get => _titulo1tablainfo; set => _titulo1tablainfo = value; }
        public string Titulo2TablaInfo { get => _titulo2tablainfo; set => _titulo2tablainfo = value; }
        public string BotonRenovar { get => _BotonRenovar; set => _BotonRenovar = value; }
        public string TituloAdicionales { get => _TituloAdicionales; set => _TituloAdicionales = value; }
        public string Titulo1TablaAdicionales { get => _titulo1tablaAdicionales; set => _titulo1tablaAdicionales = value; }
        public string Titulo2TablaAdicionales { get => _titulo2tablaAdicionales; set => _titulo2tablaAdicionales = value; }
        public string Titulo3TablaAdicionales { get => _titulo3tablaAdicionales; set => _titulo3tablaAdicionales = value; }
        public string TextoLeyenda { get => _textoLeyenda; set => _textoLeyenda = value; }
        public string BotonIrTienda { get => _botonIrTienda; set => _botonIrTienda = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
    }
}