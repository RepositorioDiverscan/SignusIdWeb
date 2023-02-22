using ActiveSmartWeb.AjaxPrincipalMaster.Entidades;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.AjaxPrincipalMaster
{
    public partial class AjaxGeneralMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaMasterGeneral eIdioma = new EIdiomaMasterGeneral();
            try
            {
                switch (Request.Form["idiomaMenuGeneral"])
                {
                    case "ES":
                        eIdioma.CerrarSesion = EIdiomaMasterEspanol._cerrarSesion;
                        eIdioma.Espanol = EIdiomaMasterEspanol._espanol;
                        eIdioma.Ingles = EIdiomaMasterEspanol._ingles;
                        eIdioma.Inicio = EIdiomaMasterEspanol._inicio;
                        eIdioma.Nosotros = EIdiomaMasterEspanol._nosotros;
                        eIdioma.Contacto = EIdiomaMasterEspanol._contacto;
                        eIdioma.DescApp = EIdiomaMasterEspanol._descApp;
                        eIdioma.Inversores = EIdiomaMasterEspanol._inversores;
                        eIdioma.Comunidad = EIdiomaMasterEspanol._comunidad;
                        eIdioma.Referencia = EIdiomaMasterEspanol._referencia;
                        eIdioma.Acerca = EIdiomaMasterEspanol._acerca;
                        eIdioma.Tienda = EIdiomaMasterEspanol._tienda;
                        eIdioma.TermCondic = EIdiomaMasterEspanol._termCondic;
                        eIdioma.SobSoluc = EIdiomaMasterEspanol._sobSoluc;
                        eIdioma.Basic = EIdiomaMasterEspanol._basic;
                        eIdioma.Pro = EIdiomaMasterEspanol._pro;
                        eIdioma.Iniciar = EIdiomaMasterEspanol._iniciar;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;
                    case "EN":
                        eIdioma.CerrarSesion = EIdiomaMasterIngles._cerrarSesion;
                        eIdioma.Espanol = EIdiomaMasterIngles._espanol;
                        eIdioma.Ingles = EIdiomaMasterIngles._ingles;
                        eIdioma.Inicio = EIdiomaMasterIngles._inicio;
                        eIdioma.Nosotros = EIdiomaMasterIngles._nosotros;
                        eIdioma.Contacto = EIdiomaMasterIngles._contacto;
                        eIdioma.DescApp = EIdiomaMasterIngles._descApp;
                        eIdioma.Inversores = EIdiomaMasterIngles._inversores;
                        eIdioma.Comunidad = EIdiomaMasterIngles._comunidad;
                        eIdioma.Referencia = EIdiomaMasterIngles._referencia;
                        eIdioma.Acerca = EIdiomaMasterIngles._acerca;
                        eIdioma.Tienda = EIdiomaMasterIngles._tienda;
                        eIdioma.TermCondic = EIdiomaMasterIngles._termCondic;
                        eIdioma.SobSoluc = EIdiomaMasterIngles._sobSoluc;
                        eIdioma.Basic = EIdiomaMasterIngles._basic;
                        eIdioma.Pro = EIdiomaMasterIngles._pro;
                        eIdioma.Iniciar = EIdiomaMasterIngles._iniciar;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;
                    default:
                        eIdioma.CerrarSesion = EIdiomaMasterEspanol._cerrarSesion;
                        eIdioma.Espanol = EIdiomaMasterEspanol._espanol;
                        eIdioma.Ingles = EIdiomaMasterEspanol._ingles;
                        eIdioma.Inicio = EIdiomaMasterEspanol._inicio;
                        eIdioma.Nosotros = EIdiomaMasterEspanol._nosotros;
                        eIdioma.Contacto = EIdiomaMasterEspanol._contacto;
                        eIdioma.DescApp = EIdiomaMasterEspanol._descApp;
                        eIdioma.Inversores = EIdiomaMasterEspanol._inversores;
                        eIdioma.Comunidad = EIdiomaMasterEspanol._comunidad;
                        eIdioma.Referencia = EIdiomaMasterEspanol._referencia;
                        eIdioma.Acerca = EIdiomaMasterEspanol._acerca;
                        eIdioma.Tienda = EIdiomaMasterEspanol._tienda;
                        eIdioma.TermCondic = EIdiomaMasterEspanol._termCondic;
                        eIdioma.SobSoluc = EIdiomaMasterEspanol._sobSoluc;
                        eIdioma.Basic = EIdiomaMasterEspanol._basic;
                        eIdioma.Pro = EIdiomaMasterEspanol._pro;
                        eIdioma.Iniciar = EIdiomaMasterEspanol._iniciar;
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