using ActiveSmartWeb.Login.Entidades;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Login
{
    public partial class IdiomaLoginAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaLoginGeneral eIdioma = new EIdiomaLoginGeneral();
            try
            {
                switch (Request.Form["idiomaLogin"])
                {
                    case "ES":
                        eIdioma.Titulo = EIdiomaLoginEspanol._titulo;
                        eIdioma.Mail = EIdiomaLoginEspanol._mail;
                        eIdioma.Contrasenna = EIdiomaLoginEspanol._contrasenna;
                        eIdioma.BtnInicio = EIdiomaLoginEspanol._btnInicio;
                        eIdioma.BtnRestContra = EIdiomaLoginEspanol._btnRestContra;
                        eIdioma.NuevoUsuario = EIdiomaLoginEspanol._nuevoUsuario;
                        eIdioma.CtroRecursos = EIdiomaLoginEspanol._ctroRecursos;
                        eIdioma.BtnPruebFree = EIdiomaLoginEspanol._btnPruebFree;
                        eIdioma.BtnVeDemo = EIdiomaLoginEspanol._btnVeDemo;
                        eIdioma.CuidArch = EIdiomaLoginEspanol._cuidArch;
                        eIdioma.Suscrib = EIdiomaLoginEspanol._suscrib;
                        eIdioma.TitActFij = EIdiomaLoginEspanol._titActFij;
                        eIdioma.Aprov = EIdiomaLoginEspanol._aprov;
                        eIdioma.Msj1 = EIdiomaLoginEspanol._msj1;
                        eIdioma.Registre = EIdiomaLoginEspanol._registre;
                        eIdioma.Controle = EIdiomaLoginEspanol._controle;
                        eIdioma.Automatice = EIdiomaLoginEspanol._automatice;
                        eIdioma.MsjSuminist = EIdiomaLoginEspanol._msjSuminist;
                        eIdioma.Sabermas = EIdiomaLoginEspanol._sabermas;
                        eIdioma.Titulo2 = EIdiomaLoginEspanol._titulo2;
                        eIdioma.Distribucion = EIdiomaLoginEspanol._distribucion;
                        eIdioma.MsjDistribucion = EIdiomaLoginEspanol._msjDistribucion;
                        eIdioma.Produccion = EIdiomaLoginEspanol._produccion;
                        eIdioma.MsjProduccion = EIdiomaLoginEspanol._msjProduccion;
                        eIdioma.Servicios = EIdiomaLoginEspanol._servicios;
                        eIdioma.MsjServicios = EIdiomaLoginEspanol._msjServicios;
                        eIdioma.Salud = EIdiomaLoginEspanol._salud;
                        eIdioma.MsjSalud = EIdiomaLoginEspanol._msjSalud;
                        eIdioma.Educacion = EIdiomaLoginEspanol._educacion;
                        eIdioma.MsjEducacion = EIdiomaLoginEspanol._msjEducacion;
                        eIdioma.Financiero = EIdiomaLoginEspanol._financiero;
                        eIdioma.MsjFinanciero = EIdiomaLoginEspanol._msjFinanciero;
                        eIdioma.Agricola = EIdiomaLoginEspanol._agricola;
                        eIdioma.MsjAgricola = EIdiomaLoginEspanol._msjAgricola;
                        eIdioma.Turismo = EIdiomaLoginEspanol._turismo;
                        eIdioma.MsjTurismo = EIdiomaLoginEspanol._msjTurismo;
                        eIdioma.MsjVersBasic = EIdiomaLoginEspanol._msjVersBasic;
                        eIdioma.MsjVersPro = EIdiomaLoginEspanol._msjVersPro;
                        eIdioma.Masinfo = EIdiomaLoginEspanol._masinfo;
                        eIdioma.Testimonio = EIdiomaLoginEspanol._testimonio;
                        eIdioma.Certif = EIdiomaLoginEspanol._certif;
                        eIdioma.OlvCon = EIdiomaLoginEspanol._olvCon;
                        eIdioma.Sucribete = EIdiomaLoginEspanol._sucribete;
                        eIdioma.Usuario = EIdiomaLoginEspanol._usuario;
                        eIdioma.UnIntento = EIdiomaLoginEspanol._unIntento;
                        eIdioma.SegIntento = EIdiomaLoginEspanol._segIntento;
                        eIdioma.TerIntento = EIdiomaLoginEspanol._terIntento;
                        eIdioma.CuaIntento = EIdiomaLoginEspanol._cuaIntento;
                        eIdioma.UsNoExiste = EIdiomaLoginEspanol._usNoExiste;
                        eIdioma.Atencion = EIdiomaLoginEspanol._atencion;
                        eIdioma.IngCorr = EIdiomaLoginEspanol._ingCorr;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;
                    case "EN":
                        eIdioma.Titulo = EIdiomaLoginIngles._titulo;
                        eIdioma.Mail = EIdiomaLoginIngles._mail;
                        eIdioma.Contrasenna = EIdiomaLoginIngles._contrasenna;
                        eIdioma.BtnInicio = EIdiomaLoginIngles._btnInicio;
                        eIdioma.BtnRestContra = EIdiomaLoginIngles._btnRestContra;
                        eIdioma.NuevoUsuario = EIdiomaLoginIngles._nuevoUsuario;
                        eIdioma.CtroRecursos = EIdiomaLoginIngles._ctroRecursos;
                        eIdioma.BtnPruebFree = EIdiomaLoginIngles._btnPruebFree;
                        eIdioma.BtnVeDemo = EIdiomaLoginIngles._btnVeDemo;
                        eIdioma.CuidArch = EIdiomaLoginIngles._cuidArch;
                        eIdioma.Suscrib = EIdiomaLoginIngles._suscrib;
                        eIdioma.TitActFij = EIdiomaLoginIngles._titActFij;
                        eIdioma.Aprov = EIdiomaLoginIngles._aprov;
                        eIdioma.Msj1 = EIdiomaLoginIngles._msj1;
                        eIdioma.Registre = EIdiomaLoginIngles._registre;
                        eIdioma.Controle = EIdiomaLoginIngles._controle;
                        eIdioma.Automatice = EIdiomaLoginIngles._automatice;
                        eIdioma.MsjSuminist = EIdiomaLoginIngles._msjSuminist;
                        eIdioma.Sabermas = EIdiomaLoginIngles._sabermas;
                        eIdioma.Titulo2 = EIdiomaLoginIngles._titulo2;
                        eIdioma.Distribucion = EIdiomaLoginIngles._distribucion;
                        eIdioma.MsjDistribucion = EIdiomaLoginIngles._msjDistribucion;
                        eIdioma.Produccion = EIdiomaLoginIngles._produccion;
                        eIdioma.MsjProduccion = EIdiomaLoginIngles._msjProduccion;
                        eIdioma.Servicios = EIdiomaLoginIngles._servicios;
                        eIdioma.MsjServicios = EIdiomaLoginIngles._msjServicios;
                        eIdioma.Salud = EIdiomaLoginIngles._salud;
                        eIdioma.MsjSalud = EIdiomaLoginIngles._msjSalud;
                        eIdioma.Educacion = EIdiomaLoginIngles._educacion;
                        eIdioma.MsjEducacion = EIdiomaLoginIngles._msjEducacion;
                        eIdioma.Financiero = EIdiomaLoginIngles._financiero;
                        eIdioma.MsjFinanciero = EIdiomaLoginIngles._msjFinanciero;
                        eIdioma.Agricola = EIdiomaLoginIngles._agricola;
                        eIdioma.MsjAgricola = EIdiomaLoginIngles._msjAgricola;
                        eIdioma.Turismo = EIdiomaLoginIngles._turismo;
                        eIdioma.MsjTurismo = EIdiomaLoginIngles._msjTurismo;
                        eIdioma.MsjVersBasic = EIdiomaLoginIngles._msjVersBasic;
                        eIdioma.MsjVersPro = EIdiomaLoginIngles._msjVersPro;
                        eIdioma.Masinfo = EIdiomaLoginIngles._masinfo;
                        eIdioma.Testimonio = EIdiomaLoginIngles._testimonio;
                        eIdioma.Certif = EIdiomaLoginIngles._certif;
                        eIdioma.OlvCon = EIdiomaLoginIngles._olvCon;
                        eIdioma.Sucribete = EIdiomaLoginIngles._sucribete;
                        eIdioma.Usuario = EIdiomaLoginIngles._usuario;
                        eIdioma.UnIntento = EIdiomaLoginIngles._unIntento;
                        eIdioma.SegIntento = EIdiomaLoginIngles._segIntento;
                        eIdioma.TerIntento = EIdiomaLoginIngles._terIntento;
                        eIdioma.CuaIntento = EIdiomaLoginIngles._cuaIntento;
                        eIdioma.UsNoExiste = EIdiomaLoginIngles._usNoExiste;
                        eIdioma.Atencion = EIdiomaLoginIngles._atencion;
                        eIdioma.IngCorr = EIdiomaLoginIngles._ingCorr;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;
                    default:
                        eIdioma.Titulo = EIdiomaLoginEspanol._titulo;
                        eIdioma.Mail = EIdiomaLoginEspanol._mail;
                        eIdioma.Contrasenna = EIdiomaLoginEspanol._contrasenna;
                        eIdioma.BtnInicio = EIdiomaLoginEspanol._btnInicio;
                        eIdioma.BtnRestContra = EIdiomaLoginEspanol._btnRestContra;
                        eIdioma.NuevoUsuario = EIdiomaLoginEspanol._nuevoUsuario;
                        eIdioma.CtroRecursos = EIdiomaLoginEspanol._ctroRecursos;
                        eIdioma.BtnPruebFree = EIdiomaLoginEspanol._btnPruebFree;
                        eIdioma.BtnVeDemo = EIdiomaLoginEspanol._btnVeDemo;
                        eIdioma.CuidArch = EIdiomaLoginEspanol._cuidArch;
                        eIdioma.Suscrib = EIdiomaLoginEspanol._suscrib;
                        eIdioma.TitActFij = EIdiomaLoginEspanol._titActFij;
                        eIdioma.Aprov = EIdiomaLoginEspanol._aprov;
                        eIdioma.Msj1 = EIdiomaLoginEspanol._msj1;
                        eIdioma.Registre = EIdiomaLoginEspanol._registre;
                        eIdioma.Controle = EIdiomaLoginEspanol._controle;
                        eIdioma.Automatice = EIdiomaLoginEspanol._automatice;
                        eIdioma.MsjSuminist = EIdiomaLoginEspanol._msjSuminist;
                        eIdioma.Sabermas = EIdiomaLoginEspanol._sabermas;
                        eIdioma.Titulo2 = EIdiomaLoginEspanol._titulo2;
                        eIdioma.Distribucion = EIdiomaLoginEspanol._distribucion;
                        eIdioma.MsjDistribucion = EIdiomaLoginEspanol._msjDistribucion;
                        eIdioma.Produccion = EIdiomaLoginEspanol._produccion;
                        eIdioma.MsjProduccion = EIdiomaLoginEspanol._msjProduccion;
                        eIdioma.Servicios = EIdiomaLoginEspanol._servicios;
                        eIdioma.MsjServicios = EIdiomaLoginEspanol._msjServicios;
                        eIdioma.Salud = EIdiomaLoginEspanol._salud;
                        eIdioma.MsjSalud = EIdiomaLoginEspanol._msjSalud;
                        eIdioma.Educacion = EIdiomaLoginEspanol._educacion;
                        eIdioma.MsjEducacion = EIdiomaLoginEspanol._msjEducacion;
                        eIdioma.Financiero = EIdiomaLoginEspanol._financiero;
                        eIdioma.MsjFinanciero = EIdiomaLoginEspanol._msjFinanciero;
                        eIdioma.Agricola = EIdiomaLoginEspanol._agricola;
                        eIdioma.MsjAgricola = EIdiomaLoginEspanol._msjAgricola;
                        eIdioma.Turismo = EIdiomaLoginEspanol._turismo;
                        eIdioma.MsjTurismo = EIdiomaLoginEspanol._msjTurismo;
                        eIdioma.MsjVersBasic = EIdiomaLoginEspanol._msjVersBasic;
                        eIdioma.MsjVersPro = EIdiomaLoginEspanol._msjVersPro;
                        eIdioma.Masinfo = EIdiomaLoginEspanol._masinfo;
                        eIdioma.Testimonio = EIdiomaLoginEspanol._testimonio;
                        eIdioma.Certif = EIdiomaLoginEspanol._certif;
                        eIdioma.OlvCon = EIdiomaLoginEspanol._olvCon;
                        eIdioma.Sucribete = EIdiomaLoginEspanol._sucribete;
                        eIdioma.Usuario = EIdiomaLoginEspanol._usuario;
                        eIdioma.UnIntento = EIdiomaLoginEspanol._unIntento;
                        eIdioma.SegIntento = EIdiomaLoginEspanol._segIntento;
                        eIdioma.TerIntento = EIdiomaLoginEspanol._terIntento;
                        eIdioma.CuaIntento = EIdiomaLoginEspanol._cuaIntento;
                        eIdioma.Atencion = EIdiomaLoginEspanol._atencion;
                        eIdioma.UsNoExiste = EIdiomaLoginEspanol._usNoExiste;
                        eIdioma.IngCorr = EIdiomaLoginEspanol._ingCorr;
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