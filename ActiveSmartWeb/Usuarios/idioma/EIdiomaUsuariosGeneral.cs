using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Usuarios.idioma
{
    public class EIdiomaUsuariosGeneral
    {

        private string _titulo;
        private string _titulo1tablaUsuarios;
        private string _titulo2tablaUsuarios;
        private string _titulo3tablaUsuarios;
        private string _titulo4tablaUsuarios;
        private string _titulo5tablaUsuarios;
        private string _titulo6tablaUsuarios;
        private string _textoLeyenda;
        private string _botonIrTienda;
        private string _creaUsuario;
        private string _rolUsuario;
        private string _atencion;
        private string _msj1;
        private string _msj2;

        public EIdiomaUsuariosGeneral() { }

        public EIdiomaUsuariosGeneral(string titulo, string titulo1tablausuarios, string titulo2tablausuarios, string titulo3tablausuarios, string titulo4tablausuarios, string titulo5tablausuarios, string titulo6tablausuarios, string textoleyenda, string botontienda, string creaUsuario, string rolUsuario, string atencion, string msj1, string msj2)
        {

            _titulo = titulo;
            _titulo1tablaUsuarios = titulo1tablausuarios;
            _titulo2tablaUsuarios = titulo2tablausuarios;
            _titulo3tablaUsuarios = titulo3tablausuarios;
            _titulo4tablaUsuarios = titulo4tablausuarios;
            _titulo5tablaUsuarios = titulo5tablausuarios;
            _titulo6tablaUsuarios = titulo6tablausuarios;
            _textoLeyenda = textoleyenda;
            _botonIrTienda = botontienda;
            CreaUsuario = creaUsuario;
            RolUsuario = rolUsuario;
            Atencion = atencion;
            Msj1 = msj1;
            Msj2 = msj2;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Titulo1TablaUsuarios { get => _titulo1tablaUsuarios; set => _titulo1tablaUsuarios = value; }
        public string Titulo2TablaUsuarios { get => _titulo2tablaUsuarios; set => _titulo2tablaUsuarios = value; }
        public string Titulo3TablaUsuarios { get => _titulo3tablaUsuarios; set => _titulo3tablaUsuarios = value; }
        public string Titulo4TablaUsuarios { get => _titulo4tablaUsuarios; set => _titulo4tablaUsuarios = value; }
        public string Titulo5TablaUsuarios { get => _titulo5tablaUsuarios; set => _titulo5tablaUsuarios = value; }
        public string Titulo6TablaUsuarios { get => _titulo6tablaUsuarios; set => _titulo6tablaUsuarios = value; }
        public string TextoLeyenda { get => _textoLeyenda; set => _textoLeyenda = value; }
        public string BotonIrTienda { get => _botonIrTienda; set => _botonIrTienda = value; }
        public string CreaUsuario { get => _creaUsuario; set => _creaUsuario = value; }
        public string RolUsuario { get => _rolUsuario; set => _rolUsuario = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
    }
}