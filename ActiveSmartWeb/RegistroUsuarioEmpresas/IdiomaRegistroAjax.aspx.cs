using ActiveSmartWeb.RegistroUsuarioEmpresas.Entidades;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas
{
    public partial class IdiomaRegistroAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaRegistroGeneral eIdioma = new EIdiomaRegistroGeneral();

            try
            {
                switch (Request.Form["idioma"])
                {
                    case "ES":

                        eIdioma.LabelInfoEmpresa = EIdiomaRegistroEspanol._labelInfoEmpresa;
                        eIdioma.LabelRegistroPerfil = EIdiomaRegistroEspanol._labelRegistroPerfil;
                        eIdioma.LabelNombreEmpresa = EIdiomaRegistroEspanol._labelNombreEmpresa;
                        eIdioma.LabelTelefonoEmpresa = EIdiomaRegistroEspanol._labelTelefonoEmpresa;
                        eIdioma.LabelCorreoEmpresa = EIdiomaRegistroEspanol._labelCorreoEmpresa;
                        eIdioma.LabelNombrePerfil = EIdiomaRegistroEspanol._labelNombrePerfil;
                        eIdioma.LabelApellidosPerfil = EIdiomaRegistroEspanol._labelApellidosPerfil;
                        eIdioma.LabelCorreoPerfil = EIdiomaRegistroEspanol._labelCorreoPerfil;
                        eIdioma.LabelContrasena = EIdiomaRegistroEspanol._labelContrasena;
                        eIdioma.LabelContrasena1 = EIdiomaRegistroEspanol._labelContrasena1;
                        eIdioma.BtnSiguiente = EIdiomaRegistroEspanol._btnSiguiente;
                        eIdioma.ErrNombreEmp = EIdiomaRegistroEspanol._errNombreEmp;
                        eIdioma.ErrTelEmp = EIdiomaRegistroEspanol._errTelEmp;
                        eIdioma.ErrNombreUs = EIdiomaRegistroEspanol._errNombreUs;
                        eIdioma.ErrApellidoUs = EIdiomaRegistroEspanol._errApellidoUs;
                        eIdioma.ErrCorreoUs = EIdiomaRegistroEspanol._errCorreoUs;
                        eIdioma.ErrContrasena = EIdiomaRegistroEspanol._errContrasena;
                        eIdioma.ErrIdEmpresa = EIdiomaRegistroEspanol._errIdEmpresa;
                        eIdioma.ErrIdIndustria = EIdiomaRegistroEspanol._errIdIndustria;
                        eIdioma.ErrIdEmpresaTam = EIdiomaRegistroEspanol._errIdEmpresaTam;
                        eIdioma.ErrIdEmpresaPais = EIdiomaRegistroEspanol._errIdEmpresaPais;
                        eIdioma.ErrIdEmpresaDir = EIdiomaRegistroEspanol._errIdEmpresaDir;
                        eIdioma.ErrPosUsuario = EIdiomaRegistroEspanol._errPosUsuario;
                        eIdioma.ErrConIgual = EIdiomaRegistroEspanol._errConIgual;
                        eIdioma.ErrTerminos = EIdiomaRegistroEspanol._errTerminos;
                        eIdioma.Atencion = EIdiomaRegistroEspanol._atencion;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;

                    case "EN":

                        eIdioma.LabelInfoEmpresa = EIdiomaRegistroIngles._labelInfoEmpresa;
                        eIdioma.LabelRegistroPerfil = EIdiomaRegistroIngles._labelRegistroPerfil;
                        eIdioma.LabelNombreEmpresa = EIdiomaRegistroIngles._labelNombreEmpresa;
                        eIdioma.LabelTelefonoEmpresa = EIdiomaRegistroIngles._labelTelefonoEmpresa;
                        eIdioma.LabelCorreoEmpresa = EIdiomaRegistroIngles._labelCorreoEmpresa;
                        eIdioma.LabelNombrePerfil = EIdiomaRegistroIngles._labelNombrePerfil;
                        eIdioma.LabelApellidosPerfil = EIdiomaRegistroIngles._labelApellidosPerfil;
                        eIdioma.LabelCorreoPerfil = EIdiomaRegistroIngles._labelCorreoPerfil;
                        eIdioma.LabelContrasena = EIdiomaRegistroIngles._labelContrasena;
                        eIdioma.LabelContrasena1 = EIdiomaRegistroIngles._labelContrasena1;
                        eIdioma.BtnSiguiente = EIdiomaRegistroIngles._btnSiguiente;
                        eIdioma.ErrNombreEmp = EIdiomaRegistroIngles._errNombreEmp;
                        eIdioma.ErrTelEmp = EIdiomaRegistroIngles._errTelEmp;
                        eIdioma.ErrNombreUs = EIdiomaRegistroIngles._errNombreUs;
                        eIdioma.ErrApellidoUs = EIdiomaRegistroIngles._errApellidoUs;
                        eIdioma.ErrCorreoUs = EIdiomaRegistroIngles._errCorreoUs;
                        eIdioma.ErrContrasena = EIdiomaRegistroIngles._errContrasena;
                        eIdioma.ErrIdEmpresa = EIdiomaRegistroIngles._errIdEmpresa;
                        eIdioma.ErrIdIndustria = EIdiomaRegistroIngles._errIdIndustria;
                        eIdioma.ErrIdEmpresaTam = EIdiomaRegistroIngles._errIdEmpresaTam;
                        eIdioma.ErrIdEmpresaPais = EIdiomaRegistroIngles._errIdEmpresaPais;
                        eIdioma.ErrIdEmpresaDir = EIdiomaRegistroIngles._errIdEmpresaDir;
                        eIdioma.ErrPosUsuario = EIdiomaRegistroIngles._errPosUsuario;
                        eIdioma.ErrConIgual = EIdiomaRegistroIngles._errConIgual;
                        eIdioma.Atencion = EIdiomaRegistroIngles._atencion;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;


                        default:

                        eIdioma.LabelInfoEmpresa = EIdiomaRegistroEspanol._labelInfoEmpresa;
                        eIdioma.LabelRegistroPerfil = EIdiomaRegistroEspanol._labelRegistroPerfil;
                        eIdioma.LabelNombreEmpresa = EIdiomaRegistroEspanol._labelNombreEmpresa;
                        eIdioma.LabelTelefonoEmpresa = EIdiomaRegistroEspanol._labelTelefonoEmpresa;
                        eIdioma.LabelCorreoEmpresa = EIdiomaRegistroEspanol._labelCorreoEmpresa;
                        eIdioma.LabelNombrePerfil = EIdiomaRegistroEspanol._labelNombrePerfil;
                        eIdioma.LabelApellidosPerfil = EIdiomaRegistroEspanol._labelApellidosPerfil;
                        eIdioma.LabelCorreoPerfil = EIdiomaRegistroEspanol._labelCorreoPerfil;
                        eIdioma.LabelContrasena = EIdiomaRegistroEspanol._labelContrasena;
                        eIdioma.LabelContrasena1 = EIdiomaRegistroEspanol._labelContrasena1;
                        eIdioma.BtnSiguiente = EIdiomaRegistroEspanol._btnSiguiente;
                        eIdioma.ErrNombreEmp = EIdiomaRegistroEspanol._errNombreEmp;
                        eIdioma.ErrTelEmp = EIdiomaRegistroEspanol._errTelEmp;
                        eIdioma.ErrNombreUs = EIdiomaRegistroEspanol._errNombreUs;
                        eIdioma.ErrApellidoUs = EIdiomaRegistroEspanol._errApellidoUs;
                        eIdioma.ErrCorreoUs = EIdiomaRegistroEspanol._errCorreoUs;
                        eIdioma.ErrContrasena = EIdiomaRegistroEspanol._errContrasena;
                        eIdioma.ErrIdEmpresa = EIdiomaRegistroEspanol._errIdEmpresa;
                        eIdioma.ErrIdIndustria = EIdiomaRegistroEspanol._errIdIndustria;
                        eIdioma.ErrIdEmpresaTam = EIdiomaRegistroEspanol._errIdEmpresaTam;
                        eIdioma.ErrIdEmpresaPais = EIdiomaRegistroEspanol._errIdEmpresaPais;
                        eIdioma.ErrIdEmpresaDir = EIdiomaRegistroEspanol._errIdEmpresaDir;
                        eIdioma.ErrPosUsuario = EIdiomaRegistroEspanol._errPosUsuario;
                        eIdioma.ErrConIgual = EIdiomaRegistroEspanol._errConIgual;
                        eIdioma.ErrTerminos = EIdiomaRegistroEspanol._errTerminos;
                        eIdioma.Atencion = EIdiomaRegistroEspanol._atencion;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));

                        break;
                }

            }catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
            

        }
    }
}