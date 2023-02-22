using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.RegistroUsuarioEmpresas.IdiomaAdicionales;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas
{
    public partial class IdiomaAdicionalesAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EIdiomaAdicionalesGeneral eIdioma = new EIdiomaAdicionalesGeneral();

            try
            {

                switch (Request.Form["idioma"])
                {

                    //Opcion del switch para cargar el idioma en español.
                    case "ES":

                        eIdioma.Titulo = EIdiomaAdicionalesEspañol.Titulo;
                        eIdioma.TituloPlan = EIdiomaAdicionalesEspañol.TituloPlan;
                        eIdioma.TituloConfigure = EIdiomaAdicionalesEspañol.TituloConfigure;
                        eIdioma.TituloInformacion = EIdiomaAdicionalesEspañol.TituloInformacion;
                        eIdioma.NumeroTarjeta = EIdiomaAdicionalesEspañol.NumeroTarjeta;
                        eIdioma.NumeroTarjetaPH = EIdiomaAdicionalesEspañol.NumeroTarjetaPH;
                        eIdioma.FechaVencimiento = EIdiomaAdicionalesEspañol.FechaVencimiento;
                        eIdioma.NombreTitular = EIdiomaAdicionalesEspañol.NombreTitular;
                        eIdioma.NombreTitularPH = EIdiomaAdicionalesEspañol.NombreTitularPH;
                        eIdioma.Pais = EIdiomaAdicionalesEspañol.Pais;
                        eIdioma.PaisPH = EIdiomaAdicionalesEspañol.PaisPH;
                        eIdioma.Estado = EIdiomaAdicionalesEspañol.Estado;
                        eIdioma.EstadoPH = EIdiomaAdicionalesEspañol.EstadoPH;
                        eIdioma.Ciudad = EIdiomaAdicionalesEspañol.Ciudad;
                        eIdioma.CiudadPH = EIdiomaAdicionalesEspañol.CiudadPH;
                        eIdioma.Direccion = EIdiomaAdicionalesEspañol.Direccion;
                        eIdioma.DireccionPH = EIdiomaAdicionalesEspañol.DireccionPH;
                        eIdioma.TituloResumen = EIdiomaAdicionalesEspañol.TituloResumen;
                        eIdioma.Precio = EIdiomaAdicionalesEspañol.Precio;
                        eIdioma.TituloAdicionales = EIdiomaAdicionalesEspañol.TituloAdicionales;
                        eIdioma.TotalPagar = EIdiomaAdicionalesEspañol.TotalPagar;
                        eIdioma.BtnPagar = EIdiomaAdicionalesEspañol.BtnPagar;
                        eIdioma.TituloFrecuenciaPago = EIdiomaAdicionalesEspañol.TituloFrecuenciaPago;
                        eIdioma.MetodoAnual = EIdiomaAdicionalesEspañol.MetodoAnual;
                        eIdioma.MetodoMensual = EIdiomaAdicionalesEspañol.MetodoMensual;
                        eIdioma.TerminosCondiciones = EIdiomaAdicionalesEspañol.TerminosCondiciones;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));

                        break;

                    //Opcion del switch para cargar el idioma en ingles.
                    case "EN":

                        eIdioma.Titulo = EIdiomaAdicionalesIngles.Titulo;
                        eIdioma.TituloPlan = EIdiomaAdicionalesIngles.TituloPlan;
                        eIdioma.TituloConfigure = EIdiomaAdicionalesIngles.TituloConfigure;
                        eIdioma.TituloInformacion = EIdiomaAdicionalesIngles.TituloInformacion;
                        eIdioma.NumeroTarjeta = EIdiomaAdicionalesIngles.NumeroTarjeta;
                        eIdioma.NumeroTarjetaPH = EIdiomaAdicionalesIngles.NumeroTarjetaPH;
                        eIdioma.FechaVencimiento = EIdiomaAdicionalesIngles.FechaVencimiento;
                        eIdioma.NombreTitular = EIdiomaAdicionalesIngles.NombreTitular;
                        eIdioma.NombreTitularPH = EIdiomaAdicionalesIngles.NombreTitularPH;
                        eIdioma.Pais = EIdiomaAdicionalesIngles.Pais;
                        eIdioma.PaisPH = EIdiomaAdicionalesIngles.PaisPH;
                        eIdioma.Estado = EIdiomaAdicionalesIngles.Estado;
                        eIdioma.EstadoPH = EIdiomaAdicionalesIngles.EstadoPH;
                        eIdioma.Ciudad = EIdiomaAdicionalesIngles.Ciudad;
                        eIdioma.CiudadPH = EIdiomaAdicionalesIngles.CiudadPH;
                        eIdioma.Direccion = EIdiomaAdicionalesIngles.Direccion;
                        eIdioma.DireccionPH = EIdiomaAdicionalesIngles.DireccionPH;
                        eIdioma.TituloResumen = EIdiomaAdicionalesIngles.TituloResumen;
                        eIdioma.Precio = EIdiomaAdicionalesIngles.Precio;
                        eIdioma.TituloAdicionales = EIdiomaAdicionalesIngles.TituloAdicionales;
                        eIdioma.TotalPagar = EIdiomaAdicionalesIngles.TotalPagar;
                        eIdioma.BtnPagar = EIdiomaAdicionalesIngles.BtnPagar;
                        eIdioma.TituloFrecuenciaPago = EIdiomaAdicionalesIngles.TituloFrecuenciaPago;
                        eIdioma.MetodoAnual = EIdiomaAdicionalesIngles.MetodoAnual;
                        eIdioma.MetodoMensual = EIdiomaAdicionalesIngles.MetodoMensual;
                        eIdioma.TerminosCondiciones = EIdiomaAdicionalesIngles.TerminosCondiciones;


                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;

                    default:

                        eIdioma.Titulo = EIdiomaAdicionalesEspañol.Titulo;
                        eIdioma.TituloPlan = EIdiomaAdicionalesEspañol.TituloPlan;
                        eIdioma.TituloConfigure = EIdiomaAdicionalesEspañol.TituloConfigure;
                        eIdioma.TituloInformacion = EIdiomaAdicionalesEspañol.TituloInformacion;
                        eIdioma.NumeroTarjeta = EIdiomaAdicionalesEspañol.NumeroTarjeta;
                        eIdioma.NumeroTarjetaPH = EIdiomaAdicionalesEspañol.NumeroTarjetaPH;
                        eIdioma.FechaVencimiento = EIdiomaAdicionalesEspañol.FechaVencimiento;
                        eIdioma.NombreTitular = EIdiomaAdicionalesEspañol.NombreTitular;
                        eIdioma.NombreTitularPH = EIdiomaAdicionalesEspañol.NombreTitularPH;
                        eIdioma.Pais = EIdiomaAdicionalesEspañol.Pais;
                        eIdioma.PaisPH = EIdiomaAdicionalesEspañol.PaisPH;
                        eIdioma.Estado = EIdiomaAdicionalesEspañol.Estado;
                        eIdioma.EstadoPH = EIdiomaAdicionalesEspañol.EstadoPH;
                        eIdioma.Ciudad = EIdiomaAdicionalesEspañol.Ciudad;
                        eIdioma.CiudadPH = EIdiomaAdicionalesEspañol.CiudadPH;
                        eIdioma.Direccion = EIdiomaAdicionalesEspañol.Direccion;
                        eIdioma.DireccionPH = EIdiomaAdicionalesEspañol.DireccionPH;
                        eIdioma.TituloResumen = EIdiomaAdicionalesEspañol.TituloResumen;
                        eIdioma.Precio = EIdiomaAdicionalesEspañol.Precio;
                        eIdioma.TituloAdicionales = EIdiomaAdicionalesEspañol.TituloAdicionales;
                        eIdioma.TotalPagar = EIdiomaAdicionalesEspañol.TotalPagar;
                        eIdioma.BtnPagar = EIdiomaAdicionalesEspañol.BtnPagar;
                        eIdioma.TituloFrecuenciaPago = EIdiomaAdicionalesEspañol.TituloFrecuenciaPago;
                        eIdioma.MetodoAnual = EIdiomaAdicionalesEspañol.MetodoAnual;
                        eIdioma.MetodoMensual = EIdiomaAdicionalesEspañol.MetodoMensual;
                        eIdioma.TerminosCondiciones = EIdiomaAdicionalesEspañol.TerminosCondiciones;

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