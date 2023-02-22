using ActiveSmartWeb.PerfilEmpresa.Idioma;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace ActiveSmartWeb.PerfilEmpresa.Ajax
{
    public partial class AjaxIdiomaPerfilEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaGeneralPerfilEmpresa eIdioma = new IdiomaGeneralPerfilEmpresa();

            try
            {
                switch (Request.Form["IE"])
                {
                    case "ES":

                        eIdioma.Titulo = IdiomaEspanolPerfilEmpresa.Titulo;
                        eIdioma.Bienvenida = IdiomaEspanolPerfilEmpresa.Bienvenida;
                        eIdioma.Email = IdiomaEspanolPerfilEmpresa.Email;
                        eIdioma.TipoUsuario = IdiomaEspanolPerfilEmpresa.TipoUsuario;
                        eIdioma.NumCuenta = IdiomaEspanolPerfilEmpresa.NumCuenta;
                        eIdioma.Permisos = IdiomaEspanolPerfilEmpresa.Permisos;
                        eIdioma.AdministrarPerfil = IdiomaEspanolPerfilEmpresa.AdministrarPerfil;
                        eIdioma.AdministrarUser = IdiomaEspanolPerfilEmpresa.AdministrarUser;
                        eIdioma.Notificaciones = IdiomaEspanolPerfilEmpresa.Notificaciones;
                        eIdioma.Opciones = IdiomaEspanolPerfilEmpresa.Opciones;
                        eIdioma.MisCompras = IdiomaEspanolPerfilEmpresa.MisCompras;
                        eIdioma.Incidentes = IdiomaEspanolPerfilEmpresa.Incidentes;
                        eIdioma.MetodosPago = IdiomaEspanolPerfilEmpresa.MetodosPago;
                        eIdioma.Seguridad = IdiomaEspanolPerfilEmpresa.Seguridad;
                        eIdioma.EditarImagen = IdiomaEspanolPerfilEmpresa.EditarImagen;
                        eIdioma.Nombre = IdiomaEspanolPerfilEmpresa.Nombre;
                        eIdioma.IdEmpresa = IdiomaEspanolPerfilEmpresa.IdEmpresa;
                        eIdioma.ContactoPrincipal = IdiomaEspanolPerfilEmpresa.ContactoPrincipal;
                        eIdioma.CorreoEmpresa = IdiomaEspanolPerfilEmpresa.CorreoEmpresa;
                        eIdioma.Pais = IdiomaEspanolPerfilEmpresa.Pais;
                        eIdioma.Direccion = IdiomaEspanolPerfilEmpresa.Direccion;
                        eIdioma.PlaceHDireccion = IdiomaEspanolPerfilEmpresa.PlaceHDireccion;
                        eIdioma.Telefono = IdiomaEspanolPerfilEmpresa.Telefono;
                        eIdioma.Industria = IdiomaEspanolPerfilEmpresa.Industria;
                        eIdioma.Plan = IdiomaEspanolPerfilEmpresa.Plan;
                        eIdioma.Actualiza = IdiomaEspanolPerfilEmpresa.Actualiza;
                        eIdioma.Tienda = IdiomaEspanolPerfilEmpresa.Tienda;
                        eIdioma.MsjTienda = IdiomaEspanolPerfilEmpresa.MsjTienda;
                        eIdioma.SelectIndustria = IdiomaEspanolPerfilEmpresa.SelectIndustria;
                        eIdioma.SelectPais = IdiomaEspanolPerfilEmpresa.SelectPais;
                        eIdioma.ActualizaError = IdiomaEspanolPerfilEmpresa.ActualizaError;
                        eIdioma.ActualizaOk = IdiomaEspanolPerfilEmpresa.ActualizaOk;
                        eIdioma.DatosIncompletos = IdiomaEspanolPerfilEmpresa.DatosIncompletos;
                        eIdioma.ModificarImagenError = IdiomaEspanolPerfilEmpresa.ModificarImagenError;
                        eIdioma.ModificarImagenOk = IdiomaEspanolPerfilEmpresa.ModificarImagenOk;
                        eIdioma.CorreoError = IdiomaEspanolPerfilEmpresa.CorreoError;
                        eIdioma.LlenarNombreEmpresa = IdiomaEspanolPerfilEmpresa.LlenarNombreEmpresa;
                        eIdioma.LlenarContactoPrincipal = IdiomaEspanolPerfilEmpresa.LlenarContactoPrincipal;
                        eIdioma.LlenarDireccion = IdiomaEspanolPerfilEmpresa.LlenarDireccion;
                        eIdioma.LlenarCorreoTxt = IdiomaEspanolPerfilEmpresa.LlenarCorreoTxt;
                        eIdioma.LlenarTelefono = IdiomaEspanolPerfilEmpresa.LlenarTelefono;
                        eIdioma.LlenarIndustria = IdiomaEspanolPerfilEmpresa.LlenarIndustria;
                        eIdioma.LlenarPais = IdiomaEspanolPerfilEmpresa.LlenarPais;
                        eIdioma.Atencion = IdiomaEspanolPerfilEmpresa.Atencion;
                        eIdioma.MsjInfo1 = IdiomaEspanolPerfilEmpresa.MsjInfo1;
                        eIdioma.MsjInfo2 = IdiomaEspanolPerfilEmpresa.MsjInfo2;
                        eIdioma.Moneda = IdiomaEspanolPerfilEmpresa.Moneda;
                        eIdioma.SelMoneda = IdiomaEspanolPerfilEmpresa.SelMoneda;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;

                    case "EN":
                        eIdioma.Titulo = IdiomaInglesPerfilEmpresa.Titulo;
                        eIdioma.Bienvenida = IdiomaInglesPerfilEmpresa.Bienvenida;
                        eIdioma.Email = IdiomaInglesPerfilEmpresa.Email;
                        eIdioma.TipoUsuario = IdiomaInglesPerfilEmpresa.TipoUsuario;
                        eIdioma.NumCuenta = IdiomaInglesPerfilEmpresa.NumCuenta;
                        eIdioma.Permisos = IdiomaInglesPerfilEmpresa.Permisos;
                        eIdioma.AdministrarPerfil = IdiomaInglesPerfilEmpresa.AdministrarPerfil;
                        eIdioma.AdministrarUser = IdiomaInglesPerfilEmpresa.AdministrarUser;
                        eIdioma.Notificaciones = IdiomaInglesPerfilEmpresa.Notificaciones;
                        eIdioma.Opciones = IdiomaInglesPerfilEmpresa.Opciones;
                        eIdioma.MisCompras = IdiomaInglesPerfilEmpresa.MisCompras;
                        eIdioma.Incidentes = IdiomaInglesPerfilEmpresa.Incidentes;
                        eIdioma.MetodosPago = IdiomaInglesPerfilEmpresa.MetodosPago;
                        eIdioma.Seguridad = IdiomaInglesPerfilEmpresa.Seguridad;
                        eIdioma.EditarImagen = IdiomaInglesPerfilEmpresa.EditarImagen;
                        eIdioma.Nombre = IdiomaInglesPerfilEmpresa.Nombre;
                        eIdioma.IdEmpresa = IdiomaInglesPerfilEmpresa.IdEmpresa;
                        eIdioma.ContactoPrincipal = IdiomaInglesPerfilEmpresa.ContactoPrincipal;
                        eIdioma.CorreoEmpresa = IdiomaInglesPerfilEmpresa.CorreoEmpresa;
                        eIdioma.Pais = IdiomaInglesPerfilEmpresa.Pais;
                        eIdioma.Direccion = IdiomaInglesPerfilEmpresa.Direccion;
                        eIdioma.PlaceHDireccion = IdiomaInglesPerfilEmpresa.PlaceHDireccion;
                        eIdioma.Telefono = IdiomaInglesPerfilEmpresa.Telefono;
                        eIdioma.Industria = IdiomaInglesPerfilEmpresa.Industria;
                        eIdioma.Plan = IdiomaInglesPerfilEmpresa.Plan;
                        eIdioma.Actualiza = IdiomaInglesPerfilEmpresa.Actualiza;
                        eIdioma.Tienda = IdiomaInglesPerfilEmpresa.Tienda;
                        eIdioma.MsjTienda = IdiomaInglesPerfilEmpresa.MsjTienda;
                        eIdioma.SelectIndustria = IdiomaInglesPerfilEmpresa.SelectIndustria;
                        eIdioma.SelectPais = IdiomaInglesPerfilEmpresa.SelectPais;
                        eIdioma.ActualizaError = IdiomaInglesPerfilEmpresa.ActualizaError;
                        eIdioma.ActualizaOk = IdiomaInglesPerfilEmpresa.ActualizaOk;
                        eIdioma.DatosIncompletos = IdiomaInglesPerfilEmpresa.DatosIncompletos;
                        eIdioma.ModificarImagenError = IdiomaInglesPerfilEmpresa.ModificarImagenError;
                        eIdioma.ModificarImagenOk = IdiomaInglesPerfilEmpresa.ModificarImagenOk;
                        eIdioma.CorreoError = IdiomaInglesPerfilEmpresa.CorreoError;
                        eIdioma.LlenarNombreEmpresa = IdiomaInglesPerfilEmpresa.LlenarNombreEmpresa;
                        eIdioma.LlenarContactoPrincipal = IdiomaInglesPerfilEmpresa.LlenarContactoPrincipal;
                        eIdioma.LlenarDireccion = IdiomaInglesPerfilEmpresa.LlenarDireccion;
                        eIdioma.LlenarCorreoTxt = IdiomaInglesPerfilEmpresa.LlenarCorreoTxt;
                        eIdioma.LlenarTelefono = IdiomaInglesPerfilEmpresa.LlenarTelefono;
                        eIdioma.LlenarIndustria = IdiomaInglesPerfilEmpresa.LlenarIndustria;
                        eIdioma.LlenarPais = IdiomaInglesPerfilEmpresa.LlenarPais;
                        eIdioma.Atencion = IdiomaInglesPerfilEmpresa.Atencion;
                        eIdioma.MsjInfo1 = IdiomaInglesPerfilEmpresa.MsjInfo1;
                        eIdioma.MsjInfo2 = IdiomaInglesPerfilEmpresa.MsjInfo2;
                        eIdioma.Moneda = IdiomaInglesPerfilEmpresa.Moneda;
                        eIdioma.SelMoneda = IdiomaInglesPerfilEmpresa.SelMoneda;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;


                    default:

                        eIdioma.Titulo = IdiomaEspanolPerfilEmpresa.Titulo;
                        eIdioma.Bienvenida = IdiomaEspanolPerfilEmpresa.Bienvenida;
                        eIdioma.Email = IdiomaEspanolPerfilEmpresa.Email;
                        eIdioma.TipoUsuario = IdiomaEspanolPerfilEmpresa.TipoUsuario;
                        eIdioma.NumCuenta = IdiomaEspanolPerfilEmpresa.NumCuenta;
                        eIdioma.Permisos = IdiomaEspanolPerfilEmpresa.Permisos;
                        eIdioma.AdministrarPerfil = IdiomaEspanolPerfilEmpresa.AdministrarPerfil;
                        eIdioma.AdministrarUser = IdiomaEspanolPerfilEmpresa.AdministrarUser;
                        eIdioma.Notificaciones = IdiomaEspanolPerfilEmpresa.Notificaciones;
                        eIdioma.Opciones = IdiomaEspanolPerfilEmpresa.Opciones;
                        eIdioma.MisCompras = IdiomaEspanolPerfilEmpresa.MisCompras;
                        eIdioma.Incidentes = IdiomaEspanolPerfilEmpresa.Incidentes;
                        eIdioma.MetodosPago = IdiomaEspanolPerfilEmpresa.MetodosPago;
                        eIdioma.Seguridad = IdiomaEspanolPerfilEmpresa.Seguridad;
                        eIdioma.EditarImagen = IdiomaEspanolPerfilEmpresa.EditarImagen;
                        eIdioma.Nombre = IdiomaEspanolPerfilEmpresa.Nombre;
                        eIdioma.IdEmpresa = IdiomaEspanolPerfilEmpresa.IdEmpresa;
                        eIdioma.ContactoPrincipal = IdiomaEspanolPerfilEmpresa.ContactoPrincipal;
                        eIdioma.CorreoEmpresa = IdiomaEspanolPerfilEmpresa.CorreoEmpresa;
                        eIdioma.Pais = IdiomaEspanolPerfilEmpresa.Pais;
                        eIdioma.Direccion = IdiomaEspanolPerfilEmpresa.Direccion;
                        eIdioma.PlaceHDireccion = IdiomaEspanolPerfilEmpresa.PlaceHDireccion;
                        eIdioma.Telefono = IdiomaEspanolPerfilEmpresa.Telefono;
                        eIdioma.Industria = IdiomaEspanolPerfilEmpresa.Industria;
                        eIdioma.Plan = IdiomaEspanolPerfilEmpresa.Plan;
                        eIdioma.Actualiza = IdiomaEspanolPerfilEmpresa.Actualiza;
                        eIdioma.Tienda = IdiomaEspanolPerfilEmpresa.Tienda;
                        eIdioma.MsjTienda = IdiomaEspanolPerfilEmpresa.MsjTienda;
                        eIdioma.SelectIndustria = IdiomaEspanolPerfilEmpresa.SelectIndustria;
                        eIdioma.SelectPais = IdiomaEspanolPerfilEmpresa.SelectPais;
                        eIdioma.ActualizaError = IdiomaEspanolPerfilEmpresa.ActualizaError;
                        eIdioma.ActualizaOk = IdiomaEspanolPerfilEmpresa.ActualizaOk;
                        eIdioma.DatosIncompletos = IdiomaEspanolPerfilEmpresa.DatosIncompletos;
                        eIdioma.ModificarImagenError = IdiomaEspanolPerfilEmpresa.ModificarImagenError;
                        eIdioma.ModificarImagenOk = IdiomaEspanolPerfilEmpresa.ModificarImagenOk;
                        eIdioma.CorreoError = IdiomaEspanolPerfilEmpresa.CorreoError;
                        eIdioma.LlenarNombreEmpresa = IdiomaEspanolPerfilEmpresa.LlenarNombreEmpresa;
                        eIdioma.LlenarContactoPrincipal = IdiomaEspanolPerfilEmpresa.LlenarContactoPrincipal;
                        eIdioma.LlenarDireccion = IdiomaEspanolPerfilEmpresa.LlenarDireccion;
                        eIdioma.LlenarCorreoTxt = IdiomaEspanolPerfilEmpresa.LlenarCorreoTxt;
                        eIdioma.LlenarTelefono = IdiomaEspanolPerfilEmpresa.LlenarTelefono;
                        eIdioma.LlenarIndustria = IdiomaEspanolPerfilEmpresa.LlenarIndustria;
                        eIdioma.LlenarPais = IdiomaEspanolPerfilEmpresa.LlenarPais;
                        eIdioma.Atencion = IdiomaEspanolPerfilEmpresa.Atencion;
                        eIdioma.MsjInfo1 = IdiomaEspanolPerfilEmpresa.MsjInfo1;
                        eIdioma.MsjInfo2 = IdiomaEspanolPerfilEmpresa.MsjInfo2;
                        eIdioma.Moneda = IdiomaEspanolPerfilEmpresa.Moneda;
                        eIdioma.SelMoneda = IdiomaEspanolPerfilEmpresa.SelMoneda;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));

                        break;
                }
            }
            catch
            {

            }

        }
    }
}