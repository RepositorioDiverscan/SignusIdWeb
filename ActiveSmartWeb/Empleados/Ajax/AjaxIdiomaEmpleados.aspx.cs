using ActiveSmartWeb.Empleados.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Empleados.Ajax
{
    public partial class AjaxEmpleadosIdioma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaGeneralEmpleados eIdioma = new EIdiomaGeneralEmpleados();

            try
            {
                switch (Request.Form["IE"])
                {
                    case "ES":

                        eIdioma.Titulo = EIdiomaEspañolEmpleados.Titulo;
                        eIdioma.Tituloagregar = EIdiomaEspañolEmpleados.Tituloagregar;
                        eIdioma.Nombre = EIdiomaEspañolEmpleados.Nombre;
                        eIdioma.Identificacion = EIdiomaEspañolEmpleados.Identificacion;
                        eIdioma.Puesto = EIdiomaEspañolEmpleados.Puesto;
                        eIdioma.Apellidos = EIdiomaEspañolEmpleados.Apellidos;
                        eIdioma.Correo = EIdiomaEspañolEmpleados.Correo;
                        eIdioma.Telefono = EIdiomaEspañolEmpleados.Telefono;
                        eIdioma.FiltraT = EIdiomaEspañolEmpleados.FiltraT;
                        eIdioma.FiltraA = EIdiomaEspañolEmpleados.FiltraA;
                        eIdioma.FiltraI = EIdiomaEspañolEmpleados.FiltraI;
                        eIdioma.NombreTabla = EIdiomaEspañolEmpleados.NombreTabla;
                        eIdioma.ApellidoTabla = EIdiomaEspañolEmpleados.ApellidoTabla;
                        eIdioma.CorreoTabla = EIdiomaEspañolEmpleados.CorreoTabla;
                        eIdioma.TelefonoTabla = EIdiomaEspañolEmpleados.TelefonoTabla;
                        eIdioma.PuestoTabla = EIdiomaEspañolEmpleados.PuestoTabla;
                        eIdioma.EstadoTabla = EIdiomaEspañolEmpleados.EstadoTabla;
                        eIdioma.Descubra = EIdiomaEspañolEmpleados.Descubra;
                        eIdioma.Tienda = EIdiomaEspañolEmpleados.Tienda;
                        eIdioma.Select = EIdiomaEspañolEmpleados.Select;
                        eIdioma.SelectA = EIdiomaEspañolEmpleados.SelectA;
                        eIdioma.SelectI = EIdiomaEspañolEmpleados.SelectI;
                        eIdioma.InsertarCorrecto = EIdiomaEspañolEmpleados.InsertarCorrecto;
                        eIdioma.ActualizaCorrecto = EIdiomaEspañolEmpleados.ActualizaCorrecto;
                        eIdioma.ActualizaError = EIdiomaEspañolEmpleados.ActualizaError;
                        eIdioma.InsertaError = EIdiomaEspañolEmpleados.InsertaError;
                        eIdioma.BuscarError = EIdiomaEspañolEmpleados.BuscarError;
                        eIdioma.BuscarNoEncontrado = EIdiomaEspañolEmpleados.BuscarNoEncontrado;
                        eIdioma.Paginaanterior = EIdiomaEspañolEmpleados.Paginaanterior;
                        eIdioma.Paginasiguiente = EIdiomaEspañolEmpleados.Paginasiguiente;
                        eIdioma.ErrorCorreo = EIdiomaEspañolEmpleados.ErrorCorreo;
                        eIdioma.ErrorTelefono = EIdiomaEspañolEmpleados.ErrorTelefono;
                        eIdioma.ErrorCorreoUs = EIdiomaEspañolEmpleados.ErrorCorreoUs;
                        eIdioma.LlenarNombre = EIdiomaEspañolEmpleados.LlenarNombre;
                        eIdioma.LlenarApellidos = EIdiomaEspañolEmpleados.LlenarApellidos;
                        eIdioma.LlenarIdentificacion = EIdiomaEspañolEmpleados.LlenarIdentificacion;
                        eIdioma.LlenarPuesto = EIdiomaEspañolEmpleados.LlenarPuesto;
                        eIdioma.LlenarTelefono = EIdiomaEspañolEmpleados.LlenarTelefono;
                        eIdioma.Atencion = EIdiomaEspañolEmpleados.Atencion;
                        eIdioma.Msj1 = EIdiomaEspañolEmpleados.Msj1;
                        eIdioma.Msj2 = EIdiomaEspañolEmpleados.Msj2;
                        eIdioma.MsjConf1 = EIdiomaEspañolEmpleados.MsjConf1;
                        eIdioma.MsjConf2 = EIdiomaEspañolEmpleados.MsjConf2;
                        eIdioma.CofSi = EIdiomaEspañolEmpleados.CofSi;
                        eIdioma.ConfNo = EIdiomaEspañolEmpleados.ConfNo;
                        eIdioma.AdminNo = EIdiomaEspañolEmpleados.AdminNo;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;

                    case "EN":

                        eIdioma.Titulo =        EIdiomaInglesEmpleados.Titulo;
                        eIdioma.Tituloagregar = EIdiomaInglesEmpleados.Tituloagregar;
                        eIdioma.Nombre =        EIdiomaInglesEmpleados.Nombre;
                        eIdioma.Identificacion =EIdiomaInglesEmpleados.Identificacion;
                        eIdioma.Puesto =        EIdiomaInglesEmpleados.Puesto;
                        eIdioma.Apellidos =     EIdiomaInglesEmpleados.Apellidos;
                        eIdioma.Correo =        EIdiomaInglesEmpleados.Correo;
                        eIdioma.Telefono =      EIdiomaInglesEmpleados.Telefono;
                        eIdioma.FiltraT =       EIdiomaInglesEmpleados.FiltraT;
                        eIdioma.FiltraA =       EIdiomaInglesEmpleados.FiltraA;
                        eIdioma.FiltraI =       EIdiomaInglesEmpleados.FiltraI;
                        eIdioma.NombreTabla =   EIdiomaInglesEmpleados.NombreTabla;
                        eIdioma.ApellidoTabla = EIdiomaInglesEmpleados.ApellidoTabla;
                        eIdioma.CorreoTabla =   EIdiomaInglesEmpleados.CorreoTabla;
                        eIdioma.TelefonoTabla = EIdiomaInglesEmpleados.TelefonoTabla;
                        eIdioma.PuestoTabla =   EIdiomaInglesEmpleados.PuestoTabla;
                        eIdioma.EstadoTabla =   EIdiomaInglesEmpleados.EstadoTabla;
                        eIdioma.Descubra =      EIdiomaInglesEmpleados.Descubra;
                        eIdioma.Tienda =        EIdiomaInglesEmpleados.Tienda;
                        eIdioma.Select = EIdiomaInglesEmpleados.Select;
                        eIdioma.SelectA = EIdiomaInglesEmpleados.SelectA;
                        eIdioma.SelectI = EIdiomaInglesEmpleados.SelectI;
                        eIdioma.InsertarCorrecto = EIdiomaInglesEmpleados.InsertarCorrecto;
                        eIdioma.ActualizaCorrecto = EIdiomaInglesEmpleados.ActualizaCorrecto;
                        eIdioma.ActualizaError = EIdiomaInglesEmpleados.ActualizaError;
                        eIdioma.InsertaError = EIdiomaInglesEmpleados.InsertaError;
                        eIdioma.BuscarError = EIdiomaInglesEmpleados.BuscarError;
                        eIdioma.BuscarNoEncontrado = EIdiomaInglesEmpleados.BuscarNoEncontrado;
                        eIdioma.Paginaanterior = EIdiomaInglesEmpleados.Paginaanterior;
                        eIdioma.Paginasiguiente = EIdiomaInglesEmpleados.Paginasiguiente;
                        eIdioma.ErrorCorreo = EIdiomaInglesEmpleados.ErrorCorreo;
                        eIdioma.ErrorTelefono = EIdiomaInglesEmpleados.ErrorTelefono;
                        eIdioma.ErrorCorreoUs = EIdiomaInglesEmpleados.ErrorCorreoUs;
                        eIdioma.LlenarNombre = EIdiomaInglesEmpleados.LlenarNombre;
                        eIdioma.LlenarApellidos = EIdiomaInglesEmpleados.LlenarApellidos;
                        eIdioma.LlenarIdentificacion = EIdiomaInglesEmpleados.LlenarIdentificacion;
                        eIdioma.LlenarPuesto = EIdiomaInglesEmpleados.LlenarPuesto;
                        eIdioma.LlenarTelefono = EIdiomaInglesEmpleados.LlenarTelefono;
                        eIdioma.Atencion = EIdiomaInglesEmpleados.Atencion;
                        eIdioma.Msj1 = EIdiomaInglesEmpleados.Msj1;
                        eIdioma.Msj2 = EIdiomaInglesEmpleados.Msj2;
                        eIdioma.MsjConf1 = EIdiomaInglesEmpleados.MsjConf1;
                        eIdioma.MsjConf2 = EIdiomaInglesEmpleados.MsjConf2;
                        eIdioma.CofSi = EIdiomaInglesEmpleados.CofSi;
                        eIdioma.ConfNo = EIdiomaInglesEmpleados.ConfNo;
                        eIdioma.AdminNo = EIdiomaInglesEmpleados.AdminNo;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;


                    default:

                        eIdioma.Titulo = EIdiomaEspañolEmpleados.Titulo;
                        eIdioma.Tituloagregar = EIdiomaEspañolEmpleados.Tituloagregar;
                        eIdioma.Nombre = EIdiomaEspañolEmpleados.Nombre;
                        eIdioma.Identificacion = EIdiomaEspañolEmpleados.Identificacion;
                        eIdioma.Puesto = EIdiomaEspañolEmpleados.Puesto;
                        eIdioma.Apellidos = EIdiomaEspañolEmpleados.Apellidos;
                        eIdioma.Correo = EIdiomaEspañolEmpleados.Correo;
                        eIdioma.Telefono = EIdiomaEspañolEmpleados.Telefono;
                        eIdioma.FiltraT = EIdiomaEspañolEmpleados.FiltraT;
                        eIdioma.FiltraA = EIdiomaEspañolEmpleados.FiltraA;
                        eIdioma.FiltraI = EIdiomaEspañolEmpleados.FiltraI;
                        eIdioma.NombreTabla = EIdiomaEspañolEmpleados.NombreTabla;
                        eIdioma.ApellidoTabla = EIdiomaEspañolEmpleados.ApellidoTabla;
                        eIdioma.CorreoTabla = EIdiomaEspañolEmpleados.CorreoTabla;
                        eIdioma.TelefonoTabla = EIdiomaEspañolEmpleados.TelefonoTabla;
                        eIdioma.PuestoTabla = EIdiomaEspañolEmpleados.PuestoTabla;
                        eIdioma.EstadoTabla = EIdiomaEspañolEmpleados.EstadoTabla;
                        eIdioma.Descubra = EIdiomaEspañolEmpleados.Descubra;
                        eIdioma.Tienda = EIdiomaEspañolEmpleados.Tienda;
                        eIdioma.Select = EIdiomaEspañolEmpleados.Select;
                        eIdioma.SelectA = EIdiomaEspañolEmpleados.SelectA;
                        eIdioma.SelectI = EIdiomaEspañolEmpleados.SelectI;
                        eIdioma.InsertarCorrecto = EIdiomaEspañolEmpleados.InsertarCorrecto;
                        eIdioma.ActualizaCorrecto = EIdiomaEspañolEmpleados.ActualizaCorrecto;
                        eIdioma.ActualizaError = EIdiomaEspañolEmpleados.ActualizaError;
                        eIdioma.InsertaError = EIdiomaEspañolEmpleados.InsertaError;
                        eIdioma.BuscarError = EIdiomaEspañolEmpleados.BuscarError;
                        eIdioma.BuscarNoEncontrado = EIdiomaEspañolEmpleados.BuscarNoEncontrado;
                        eIdioma.Paginaanterior = EIdiomaEspañolEmpleados.Paginaanterior;
                        eIdioma.Paginasiguiente = EIdiomaEspañolEmpleados.Paginasiguiente;
                        eIdioma.ErrorCorreo = EIdiomaEspañolEmpleados.ErrorCorreo;
                        eIdioma.ErrorTelefono = EIdiomaEspañolEmpleados.ErrorTelefono;
                        eIdioma.ErrorCorreoUs = EIdiomaEspañolEmpleados.ErrorCorreoUs;
                        eIdioma.LlenarNombre = EIdiomaEspañolEmpleados.LlenarNombre;
                        eIdioma.LlenarApellidos = EIdiomaEspañolEmpleados.LlenarApellidos;
                        eIdioma.LlenarIdentificacion = EIdiomaEspañolEmpleados.LlenarIdentificacion;
                        eIdioma.LlenarPuesto = EIdiomaEspañolEmpleados.LlenarPuesto;
                        eIdioma.LlenarTelefono = EIdiomaEspañolEmpleados.LlenarTelefono;
                        eIdioma.Atencion = EIdiomaEspañolEmpleados.Atencion;
                        eIdioma.Msj1 = EIdiomaEspañolEmpleados.Msj1;
                        eIdioma.Msj2 = EIdiomaEspañolEmpleados.Msj2;
                        eIdioma.MsjConf1 = EIdiomaEspañolEmpleados.MsjConf1;
                        eIdioma.MsjConf2 = EIdiomaEspañolEmpleados.MsjConf2;
                        eIdioma.CofSi = EIdiomaEspañolEmpleados.CofSi;
                        eIdioma.ConfNo = EIdiomaEspañolEmpleados.ConfNo;
                        eIdioma.AdminNo = EIdiomaEspañolEmpleados.AdminNo;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));

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