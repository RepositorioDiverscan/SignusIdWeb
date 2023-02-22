using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.IdiomaAdicionales
{
    public class EIdiomaAdicionalesGeneral
    {

        private string _titulo;
        private string _tituloPlan;
        private string _tituloConfigure;
        private string _tituloInformacion;
        private string _numerotarjeta;
        private string _numerotarjetaph;
        private string _fechavencimiento;
        private string _nombretitular;
        private string _nombretitularph;
        private string _pais;
        private string _paisph;
        private string _estado;
        private string _estadoph;
        private string _ciudad;
        private string _ciudadph;
        private string _direccion;
        private string _direccionph;
        private string _tituloResumen;
        private string _precio;
        private string _tituloAdicionales;
        private string _totalpagar;
        private string _btnpagar;
        private string _tituloFrecuencipago;
        private string _metodoanual;
        private string _metodomensual;
        private string _terminoscondiciones;


        public EIdiomaAdicionalesGeneral() { }

        public EIdiomaAdicionalesGeneral(string titulo, string tituloplan, string tituloconfigure, string tituloinformacion, string numerotarjeta, string numerotarjetaph, string fechavencimiento, string nombretitular, string nombretitularph, string pais, string paisph, string estado, string estadoph, string ciudad, string ciudadph, string direccion, string direccionph, string tituloresumen, string precio, string tituloadicionales ,string totalpagar, string btnpagar, string titulofrecuenciapago, string metodoanual, string metodomensual, string terminoscondiciones)
        {

            _titulo = titulo;
            _tituloPlan = tituloplan;
            _tituloConfigure = tituloconfigure;
            _tituloInformacion = tituloinformacion;
            _numerotarjeta = numerotarjeta;
            _numerotarjeta = numerotarjetaph;
            _fechavencimiento = fechavencimiento;
            _nombretitular = nombretitular;
            _nombretitularph = nombretitularph;
            _pais = pais;
            _paisph = paisph;
            _estado = estado;
            _estadoph = estadoph;
            _ciudad = ciudad;
            _ciudadph = ciudadph;
            _direccion = direccion;
            _direccionph = direccionph;
            _tituloResumen = tituloresumen;
            _precio = precio;
            _tituloAdicionales = tituloadicionales;
            _totalpagar = totalpagar;
            _btnpagar = btnpagar;
            _tituloFrecuencipago = titulofrecuenciapago;
            _metodoanual = metodoanual;
            _metodomensual = metodomensual;
            _terminoscondiciones = terminoscondiciones;

        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string TituloPlan { get => _tituloPlan; set => _tituloPlan = value; }
        public string TituloConfigure { get => _tituloConfigure; set => _tituloConfigure = value; }
        public string TituloInformacion { get => _tituloInformacion; set => _tituloInformacion = value; }
        public string NumeroTarjeta { get => _numerotarjeta; set => _numerotarjeta = value; }
        public string NumeroTarjetaPH { get => _numerotarjetaph; set => _numerotarjetaph = value; }
        public string FechaVencimiento { get => _fechavencimiento; set => _fechavencimiento = value; }
        public string NombreTitular { get => _nombretitular; set => _nombretitular = value; }
        public string NombreTitularPH  { get => _nombretitularph; set => _nombretitularph = value; }
        public string Pais { get => _pais; set => _pais = value; }
        public string PaisPH { get => _paisph; set => _paisph = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string EstadoPH { get => _estadoph; set => _estadoph = value; }
        public string Ciudad { get => _ciudad; set => _ciudad = value; }
        public string CiudadPH { get => _ciudadph; set => _ciudadph = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string DireccionPH { get => _direccionph; set => _direccionph = value; }
        public string TituloResumen { get => _tituloResumen; set => _tituloResumen = value; }
        public string Precio { get => _precio; set => _precio = value; }
        public string TituloAdicionales { get => _tituloAdicionales; set => _tituloAdicionales = value; }
        public string TotalPagar { get => _totalpagar; set => _totalpagar = value; }
        public string BtnPagar { get => _btnpagar; set => _btnpagar = value; }
        public string TituloFrecuenciaPago { get => _tituloFrecuencipago; set => _tituloFrecuencipago = value; }
        public string MetodoAnual { get => _metodoanual; set => _metodoanual = value; }
        public string MetodoMensual { get => _metodomensual; set => _metodomensual = value; }
        public string TerminosCondiciones { get => _terminoscondiciones; set => _terminoscondiciones = value; }


    }
}