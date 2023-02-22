using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.PerfilEmpresa.Idioma
{
    public class IdiomaGeneralPerfilEmpresa
    {
        private string _titulo;
        private string _Bienvenida;
        private string _Email;
        private string _TipoUsuario;
        private string _NumCuenta;
        private string _Permisos;
        private string _AdministrarPerfil;
        private string _AdministrarUser;
        private string _Notificaciones;
        private string _Opciones;
        private string _MisCompras;
        private string _Incidentes;
        private string _MetodosPago ;
        private string _Seguridad ;
        private string _EditarImagen;
        private string _Nombre ;
        private string _IdEmpresa ;
        private string _ContactoPrincipal ;
        private string _CorreoEmpresa;
        private string _Pais ;
        private string _Direccion ;
        private string _PlaceHDireccion;
        private string _Telefono ;
        private string _Industria ;
        private string _Plan ;
        private string _Actualiza ;
        private string _Tienda ;
        private string _MsjTienda ;
        private string _SelectIndustria;
        private string _SelectPais;
        private string _ActualizaOk;
        private string _ActualizaError;
        private string _DatosIncompletos;
        private string _ModificarImagenOk;
        private string _ModificarImagenError;
        private string _CorreoError;
        private string _llenarNombreEmpresa;
        private string _llenarContactoPrincipal;
        private string _llenarDireccion;
        private string _llenarCorreoTxt;
        private string _llenarTelefono;
        private string _llenarIndustria;
        private string _llenarPais;
        private string _atencion;
        private string _msjInfo1;
        private string _msjInfo2;
        private string _moneda;
        private string _selMoneda;
        public IdiomaGeneralPerfilEmpresa()
        {
        }

        public IdiomaGeneralPerfilEmpresa(string titulo, string bienvenida, string email, string tipoUsuario, string numCuenta, string permisos, string administrarPerfil, string administrarUser, string notificaciones, string opciones, string misCompras, string incidentes, string metodosPago, string seguridad, string editarImagen, string nombre, string idEmpresa, string contactoPrincipal, string correoEmpresa, string pais, string direccion, string placeHDireccion, string telefono, string industria, string plan, string actualiza, string tienda, string msjTienda, string selectIndustria, string selectPais, string actualizaOk, string actualizaError, string datosIncompletos, string modificarImagenOk, string modificarImagenError, string correoError, string llenarNombreEmpresa, string llenarContactoPrincipal, string llenarDireccion, string llenarCorreoTxt, string llenarTelefono, string llenarIndustria, string llenarPais, string atencion, string msjInfo1, string msjInfo2, string moneda, string selMoneda)
        {
            Titulo = titulo;
            Bienvenida = bienvenida;
            Email = email;
            TipoUsuario = tipoUsuario;
            NumCuenta = numCuenta;
            Permisos = permisos;
            AdministrarPerfil = administrarPerfil;
            AdministrarUser = administrarUser;
            Notificaciones = notificaciones;
            Opciones = opciones;
            MisCompras = misCompras;
            Incidentes = incidentes;
            MetodosPago = metodosPago;
            Seguridad = seguridad;
            EditarImagen = editarImagen;
            Nombre = nombre;
            IdEmpresa = idEmpresa;
            ContactoPrincipal = contactoPrincipal;
            CorreoEmpresa = correoEmpresa;
            Pais = pais;
            Direccion = direccion;
            PlaceHDireccion = placeHDireccion;
            Telefono = telefono;
            Industria = industria;
            Plan = plan;
            Actualiza = actualiza;
            Tienda = tienda;
            MsjTienda = msjTienda;
            SelectIndustria = selectIndustria;
            SelectPais = selectPais;
            ActualizaOk = actualizaOk;
            ActualizaError = actualizaError;
            DatosIncompletos = datosIncompletos;
            ModificarImagenOk = modificarImagenOk;
            ModificarImagenError = modificarImagenError;
            CorreoError = correoError;
            LlenarNombreEmpresa = llenarNombreEmpresa;
            LlenarContactoPrincipal = llenarContactoPrincipal;
            LlenarDireccion = llenarDireccion;
            LlenarCorreoTxt = llenarCorreoTxt;
            LlenarTelefono = llenarTelefono;
            LlenarIndustria = llenarIndustria;
            LlenarPais = llenarPais;
            Atencion = atencion;
            MsjInfo1 = msjInfo1;
            MsjInfo2 = msjInfo2;
            Moneda = moneda;
            SelMoneda = selMoneda;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Bienvenida { get => _Bienvenida; set => _Bienvenida = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string TipoUsuario { get => _TipoUsuario; set => _TipoUsuario = value; }
        public string NumCuenta { get => _NumCuenta; set => _NumCuenta = value; }
        public string Permisos { get => _Permisos; set => _Permisos = value; }
        public string AdministrarPerfil { get => _AdministrarPerfil; set => _AdministrarPerfil = value; }
        public string AdministrarUser { get => _AdministrarUser; set => _AdministrarUser = value; }
        public string Notificaciones { get => _Notificaciones; set => _Notificaciones = value; }
        public string Opciones { get => _Opciones; set => _Opciones = value; }
        public string MisCompras { get => _MisCompras; set => _MisCompras = value; }
        public string Incidentes { get => _Incidentes; set => _Incidentes = value; }
        public string MetodosPago { get => _MetodosPago; set => _MetodosPago = value; }
        public string Seguridad { get => _Seguridad; set => _Seguridad = value; }
        public string EditarImagen { get => _EditarImagen; set => _EditarImagen = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string IdEmpresa { get => _IdEmpresa; set => _IdEmpresa = value; }
        public string ContactoPrincipal { get => _ContactoPrincipal; set => _ContactoPrincipal = value; }
        public string CorreoEmpresa { get => _CorreoEmpresa; set => _CorreoEmpresa = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string PlaceHDireccion { get => _PlaceHDireccion; set => _PlaceHDireccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Industria { get => _Industria; set => _Industria = value; }
        public string Plan { get => _Plan; set => _Plan = value; }
        public string Actualiza { get => _Actualiza; set => _Actualiza = value; }
        public string Tienda { get => _Tienda; set => _Tienda = value; }
        public string MsjTienda { get => _MsjTienda; set => _MsjTienda = value; }
        public string SelectIndustria { get => _SelectIndustria; set => _SelectIndustria = value; }
        public string SelectPais { get => _SelectPais; set => _SelectPais = value; }
        public string ActualizaOk { get => _ActualizaOk; set => _ActualizaOk = value; }
        public string ActualizaError { get => _ActualizaError; set => _ActualizaError = value; }
        public string DatosIncompletos { get => _DatosIncompletos; set => _DatosIncompletos = value; }
        public string ModificarImagenOk { get => _ModificarImagenOk; set => _ModificarImagenOk = value; }
        public string ModificarImagenError { get => _ModificarImagenError; set => _ModificarImagenError = value; }
        public string CorreoError { get => _CorreoError; set => _CorreoError = value; }
        public string LlenarNombreEmpresa { get => _llenarNombreEmpresa; set => _llenarNombreEmpresa = value; }
        public string LlenarContactoPrincipal { get => _llenarContactoPrincipal; set => _llenarContactoPrincipal = value; }
        public string LlenarDireccion { get => _llenarDireccion; set => _llenarDireccion = value; }
        public string LlenarCorreoTxt { get => _llenarCorreoTxt; set => _llenarCorreoTxt = value; }
        public string LlenarTelefono { get => _llenarTelefono; set => _llenarTelefono = value; }
        public string LlenarIndustria { get => _llenarIndustria; set => _llenarIndustria = value; }
        public string LlenarPais { get => _llenarPais; set => _llenarPais = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
        public string MsjInfo1 { get => _msjInfo1; set => _msjInfo1 = value; }
        public string MsjInfo2 { get => _msjInfo2; set => _msjInfo2 = value; }
        public string Moneda { get => _moneda; set => _moneda = value; }
        public string SelMoneda { get => _selMoneda; set => _selMoneda = value; }
    }
}