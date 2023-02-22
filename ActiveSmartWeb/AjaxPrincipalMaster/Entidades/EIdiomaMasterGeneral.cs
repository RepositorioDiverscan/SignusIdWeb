using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.AjaxPrincipalMaster.Entidades
{
    public class EIdiomaMasterGeneral
    {
        private string _cerrarSesion;
        private string _espanol;
        private string _ingles;
        private string _inicio;
        private string _nosotros;
        private string _contacto;
        private string _descApp;
        private string _inversores;
        private string _comunidad;
        private string _referencia;
        private string _acerca;
        private string _tienda;
        private string _termCondic;
        private string _sobSoluc;
        private string _basic;
        private string _pro;
        private string iniciar;
        public EIdiomaMasterGeneral()
        {
        }
        public EIdiomaMasterGeneral(string cerrarSesion, string espanol, string ingles, string inicio, string nosotros, string contacto,
            string descApp, string inversores, string comunidad, string referencia, string acerca, string tienda, string termCondic, string sobSoluc, string basic, string pro, string iniciar)
        {
            _cerrarSesion = cerrarSesion;
            _espanol = espanol;
            _ingles = ingles;
            _inicio = inicio;
            _nosotros = nosotros;
            _contacto = contacto;
            _descApp = descApp;
            _inversores = inversores;
            _comunidad = comunidad;
            _referencia = referencia;
            _acerca = acerca;
            _tienda = tienda;
            _termCondic = termCondic;
            _sobSoluc = sobSoluc;
            _basic = basic;
            _pro = pro;
            Iniciar = iniciar;
        }


        public string CerrarSesion { get => _cerrarSesion; set => _cerrarSesion = value; }
        public string Espanol { get => _espanol; set => _espanol = value; }
        public string Ingles { get => _ingles; set => _ingles = value; }
        public string Inicio { get => _inicio; set => _inicio = value; }
        public string Nosotros { get => _nosotros; set => _nosotros = value; }
        public string Contacto { get => _contacto; set => _contacto = value; }
        public string DescApp { get => _descApp; set => _descApp = value; }
        public string Inversores { get => _inversores; set => _inversores = value; }
        public string Comunidad { get => _comunidad; set => _comunidad = value; }
        public string Referencia { get => _referencia; set => _referencia = value; }
        public string Acerca { get => _acerca; set => _acerca = value; }
        public string Tienda { get => _tienda; set => _tienda = value; }
        public string TermCondic { get => _termCondic; set => _termCondic = value; }
        public string SobSoluc { get => _sobSoluc; set => _sobSoluc = value; }
        public string Basic { get => _basic; set => _basic = value; }
        public string Pro { get => _pro; set => _pro = value; }
        public string Iniciar { get => iniciar; set => iniciar = value; }
    }
}