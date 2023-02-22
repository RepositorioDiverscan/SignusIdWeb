using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.NotificacionesPerfil.Idioma
{
    public class IdiomaGeneralNotificaciones
    {
        private string _titulo;
        private string _categoriaTabla;
        private string _numActivo;
        private string _mensaje;
        private string _estado;
        private string _msjTienda ;
        private string _msjbtnTienda ;
        private string _msj1;
        private string _msj2;

        public IdiomaGeneralNotificaciones()
        {
        }

        public IdiomaGeneralNotificaciones(string titulo, string categoriaTabla, string numActivo, string mensaje, string estado, string msjTienda, string msjbtnTienda)
        {
            _titulo = titulo;
            _categoriaTabla = categoriaTabla;
            _numActivo = numActivo;
            _mensaje = mensaje;
            _estado = estado;
            _msjTienda = msjTienda;
            _msjbtnTienda = msjbtnTienda;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string CategoriaTabla { get => _categoriaTabla; set => _categoriaTabla = value; }
        public string NumActivo { get => _numActivo; set => _numActivo = value; }
        public string Mensaje { get => _mensaje; set => _mensaje = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string MsjTienda { get => _msjTienda; set => _msjTienda = value; }
        public string MsjbtnTienda { get => _msjbtnTienda; set => _msjbtnTienda = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
    }
}