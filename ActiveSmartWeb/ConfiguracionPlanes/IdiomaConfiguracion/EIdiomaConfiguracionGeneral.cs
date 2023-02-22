using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ConfiguracionPlanes.IdiomaConfiguracion
{
    public class EIdiomaConfiguracionGeneral
    {

        private string _titulo;
        private string _tituloPlanDisponible;
        private string _textoLeyenda;
        private string _botonIrTienda;
        private string _tablaCampo1;
        private string _tablaCampo2;
        private string _tablaCampo3;
        private string _tablaCampo4;
        private string _campoSelect;

        public EIdiomaConfiguracionGeneral() { }

        public EIdiomaConfiguracionGeneral(string titulo, string tituloPlanDisponible, string textoLeyenda, string botonTienda, string tablaCampo1, string tablaCampo2, string tablaCampo3, string tablaCampo4, string CampoSelect) {

            _titulo = titulo;
            _tituloPlanDisponible = tituloPlanDisponible;
            _textoLeyenda = textoLeyenda;
            _botonIrTienda = botonTienda;
            _tablaCampo1 = tablaCampo1;
            _tablaCampo2 = tablaCampo2;
            _tablaCampo3 = tablaCampo3;
            _tablaCampo4 = tablaCampo4;
            _campoSelect = CampoSelect;

        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string TituloPlanDisponible { get => _tituloPlanDisponible; set => _tituloPlanDisponible = value; }
        public string TextoLeyenda { get => _textoLeyenda; set => _textoLeyenda = value; }
        public string BotonIrTienda { get => _botonIrTienda; set => _botonIrTienda = value; }
        public string TablaCampo1 { get => _tablaCampo1; set => _tablaCampo1 = value; }
        public string TablaCampo2 { get => _tablaCampo2; set => _tablaCampo2 = value; }
        public string TablaCampo3 { get => _tablaCampo3; set => _tablaCampo3 = value; }
        public string TablaCampo4 { get => _tablaCampo4; set => _tablaCampo4 = value; }
        public string CampoSelect { get => _campoSelect; set => _campoSelect = value; }

    }
}