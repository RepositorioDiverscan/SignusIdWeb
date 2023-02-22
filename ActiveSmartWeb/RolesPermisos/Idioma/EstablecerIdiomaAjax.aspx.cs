using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.RolesPermisos.Idioma
{
    public partial class EstablecerIdioma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaGeneral Idioma = new EIdiomaGeneral();
            try
            {
                switch (Request.Form["IdiomaRoles"])
                {
                    case "ES":

                        Idioma.Titulo = EIdiomaES._titulo;
                        Idioma.Correo = EIdiomaES._correo;
                        Idioma.Nombre = EIdiomaES._nombre;
                        Idioma.Apellido = EIdiomaES._apellido;
                        Idioma.NoExiste = EIdiomaES._noExiste;
                        Idioma.CrearUsuario = EIdiomaES._crearUsuario;
                        Idioma.CreacionActivos = EIdiomaES._creacionActivos;
                        Idioma.ActualizarActivos = EIdiomaES._actualizarActivos;
                        Idioma.TomasFisicas = EIdiomaES._tomasFisicas;
                        Idioma.Reportes = EIdiomaES._reportes;
                        Idioma.CreacionUbicaciones = EIdiomaES._creacionUbicaciones;
                        Idioma.RolesPermisos = EIdiomaES._rolesPermisos;
                        Idioma.MjsCreacionUsuario = EIdiomaES._mjsCreacionUsuario;
                        Idioma.BtnGuardarCambios = EIdiomaES._btnGuardarCambios;
                        Idioma.SincronizarActivos = EIdiomaES._sincronizarActivos;
                        Idioma.CreacionActivosAPP = EIdiomaES._creacionActivosAPP;
                        Idioma.ActualizarActivosAPP = EIdiomaES._actualizarActivosAPP;
                        Idioma.TomasFisicasAPP = EIdiomaES._tomasFisicasAPP;
                        Idioma.PerfilAPP = EIdiomaES._perfilAPP;
                        Idioma.ResultadoTomaAPP = EIdiomaES._resultadoTomaAPP;
                        Idioma.ExcedioUsuarios = EIdiomaES._excedioUsuarios;
                        Idioma.PermisosAsignados = EIdiomaES._permisosAsignados;
                        Idioma.ErrorPermisos = EIdiomaES._errorPermisos;
                        Idioma.ErrorCorreo = EIdiomaES._errorCorreo;
                        Idioma.ErrorNombre = EIdiomaES._errorNombre;
                        Idioma.ErrorApellido = EIdiomaES._errorApellido;
                        Idioma.ErorConsulta = EIdiomaES._erorConsulta;
                        Idioma.CreadoConExito = EIdiomaES._creadoConExito;
                        Idioma.YaExiste = EIdiomaES._yaExiste;
                        Idioma.ActivosNoPistoleados = EIdiomaES._activosNoPistoleados;



                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;

                    case "EN":
                        Idioma.Titulo = EIdiomaEN._titulo;
                        Idioma.Correo = EIdiomaEN._correo;
                        Idioma.Nombre = EIdiomaEN._nombre;
                        Idioma.Apellido = EIdiomaEN._apellido;
                        Idioma.NoExiste = EIdiomaEN._noExiste;
                        Idioma.CrearUsuario = EIdiomaEN._crearUsuario;
                        Idioma.CreacionActivos = EIdiomaEN._creacionActivos;
                        Idioma.ActualizarActivos = EIdiomaEN._actualizarActivos;
                        Idioma.TomasFisicas = EIdiomaEN._tomasFisicas;
                        Idioma.Reportes = EIdiomaEN._reportes;
                        Idioma.CreacionUbicaciones = EIdiomaEN._creacionUbicaciones;
                        Idioma.RolesPermisos = EIdiomaEN._rolesPermisos;
                        Idioma.MjsCreacionUsuario = EIdiomaEN._mjsCreacionUsuario;
                        Idioma.BtnGuardarCambios = EIdiomaEN._btnGuardarCambios;
                        Idioma.SincronizarActivos = EIdiomaEN._sincronizarActivos;
                        Idioma.CreacionActivosAPP = EIdiomaEN._creacionActivosAPP;
                        Idioma.ActualizarActivosAPP = EIdiomaEN._actualizarActivosAPP;
                        Idioma.TomasFisicasAPP = EIdiomaEN._tomasFisicasAPP;
                        Idioma.PerfilAPP = EIdiomaEN._perfilAPP;
                        Idioma.ResultadoTomaAPP = EIdiomaEN._resultadoTomaAPP;
                        Idioma.ExcedioUsuarios = EIdiomaEN._excedioUsuarios;
                        Idioma.ErrorPermisos = EIdiomaEN._errorPermisos;
                        Idioma.PermisosAsignados = EIdiomaEN._permisosAsignados;
                        Idioma.ErrorNombre = EIdiomaEN._errorCorreo;
                        Idioma.ErrorCorreo = EIdiomaEN._errorCorreo;
                        Idioma.ErrorApellido = EIdiomaEN._errorApellido;
                        Idioma.ErorConsulta = EIdiomaEN._erorConsulta;
                        Idioma.CreadoConExito = EIdiomaEN._creadoConExito;
                        Idioma.YaExiste = EIdiomaEN._yaExiste;
                        Idioma.ActivosNoPistoleados = EIdiomaEN._activosNoPistoleados;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;

                    default:

                        Idioma.Titulo = EIdiomaES._titulo;
                        Idioma.Correo = EIdiomaES._correo;
                        Idioma.Nombre = EIdiomaES._nombre;
                        Idioma.Apellido = EIdiomaES._apellido;
                        Idioma.NoExiste = EIdiomaES._noExiste;
                        Idioma.CrearUsuario = EIdiomaES._crearUsuario;
                        Idioma.CreacionActivos = EIdiomaES._creacionActivos;
                        Idioma.ActualizarActivos = EIdiomaES._actualizarActivos;
                        Idioma.TomasFisicas = EIdiomaES._tomasFisicas;
                        Idioma.Reportes = EIdiomaES._reportes;
                        Idioma.CreacionUbicaciones = EIdiomaES._creacionUbicaciones;
                        Idioma.RolesPermisos = EIdiomaES._rolesPermisos;
                        Idioma.MjsCreacionUsuario = EIdiomaES._mjsCreacionUsuario;
                        Idioma.BtnGuardarCambios = EIdiomaES._btnGuardarCambios;
                        Idioma.SincronizarActivos = EIdiomaES._sincronizarActivos;
                        Idioma.CreacionActivosAPP = EIdiomaES._creacionActivosAPP;
                        Idioma.ActualizarActivosAPP = EIdiomaES._actualizarActivosAPP;
                        Idioma.TomasFisicasAPP = EIdiomaES._tomasFisicasAPP;
                        Idioma.PerfilAPP = EIdiomaES._perfilAPP;
                        Idioma.ResultadoTomaAPP = EIdiomaES._resultadoTomaAPP;
                        Idioma.ExcedioUsuarios = EIdiomaES._excedioUsuarios;
                        Idioma.PermisosAsignados = EIdiomaES._permisosAsignados;
                        Idioma.ErrorPermisos = EIdiomaES._errorPermisos; 
                        Idioma.ErrorCorreo = EIdiomaES._errorCorreo;
                        Idioma.ErrorNombre = EIdiomaES._errorNombre;
                        Idioma.ErrorApellido = EIdiomaES._errorApellido;
                        Idioma.ErorConsulta = EIdiomaES._erorConsulta;
                        Idioma.CreadoConExito = EIdiomaES._creadoConExito;
                        Idioma.YaExiste = EIdiomaES._yaExiste;
                        Idioma.ActivosNoPistoleados = EIdiomaES._activosNoPistoleados;


                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;

                }
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
        }


    }
    
}