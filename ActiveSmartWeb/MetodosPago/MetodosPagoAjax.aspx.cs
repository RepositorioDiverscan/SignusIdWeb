using ActiveSmartWeb.Authorize;
using ActiveSmartWeb.MetodosPago.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ActiveSmartWeb.MetodosPago
{
    public partial class MetodosPagoAjax : System.Web.UI.Page
    {
        NMetodosPago _nMetodosPago = new NMetodosPago();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var opcion = Request.Form["Opcion"];


            switch (opcion)
            {
                case "CargarMetodos":
                    ObtenerMetodosPago();
                    break;

                case "AgregarMetodoPago":
                    AgregarMetodoPago();
                    break;

                case "EliminarMetodoPago":
                    EliminarMetodoPago();
                    break;


            }
        }

        #region Metodos

        private void ObtenerMetodosPago()
        {
            int idEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);

            //Obtiene el id del perfil de usuario de Authorize
            string perfilUsuario = _nMetodosPago.ObtenerPerfilUsuario(idEmpresa);

            //Obtiene los perfiles de pago del usuario de BD
            List<EPerfilPago> perfilesPago = _nMetodosPago.ObtenerPerfilesPago(idEmpresa);

            //Obtiene la informacion de los metodos de pago
            List<EMetodoPago> metodosPago = ObtenerInformacionPerfilesPago(perfilesPago, perfilUsuario);

            //Crea un json con los datos que se necesata retornar 
            var json = new
            {
                PerfilUsuario = perfilUsuario,
                MetodosPago = metodosPago
            };

            Response.Write(JsonConvert.SerializeObject(json, Formatting.Indented));

        }

        //Obtiene la informacion de los perfiles de pago y los retorna en una lista
        private List<EMetodoPago> ObtenerInformacionPerfilesPago(List<EPerfilPago> perfilesPago, string perfilUsuario)
        {
            List<EMetodoPago> metodosPago = new List<EMetodoPago>();

            foreach (EPerfilPago perfilPago in perfilesPago)
            {
                EMetodoPago metodoPago = PagoAuthorize.ObtenerInformacionPerfilPago(perfilUsuario, perfilPago);
                if(metodoPago != null)
                {
                    metodoPago.Valido = ValidarExpiracionTarjeta(metodoPago.FechaExpiracion);
                    metodosPago.Add(metodoPago);
                }
            }

            return metodosPago;
        }

        //Valida la fecha de expiracion de la tarjeta, si es valida retorna true, si esta vencida false 
        private bool ValidarExpiracionTarjeta(string fechaExpiracionStr)
        {
            DateTime fechaExpiracion;
            if (DateTime.TryParseExact(fechaExpiracionStr, "yyyy-MM", null, System.Globalization.DateTimeStyles.None, out fechaExpiracion))
            {
                DateTime fechaActual = DateTime.Now;

                if (fechaExpiracion < fechaActual)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        private void AgregarMetodoPago()
        {
            string perfilUsuario = Request.Form["PerfilUsuario"];

            var fecha = Request.Form["FechaVencimiento"].Split('/');
            var fechaAuth = fecha[1] + "-" + fecha[0];


            EMetodoPago nuevoMetodo = new EMetodoPago(
                Request.Form["Numerotarjeta"].Replace(" ", ""),
                fechaAuth,
                Request.Form["Codigo"],
                Request.Form["Pais"],
                Request.Form["Estado"],
                Request.Form["Ciudad"],
                Request.Form["Direccion"],
                Request.Form["Nombretitular"],
                Request.Form["Apellidotitular"]);

            string nuevoPerfilPago = PagoAuthorize.AgregarMetodoPago(perfilUsuario, nuevoMetodo);
            //string nuevoPerfilPago = "";

            if (nuevoPerfilPago != "Error")
            {
               

             var x = _nMetodosPago.AgregarMetodoPago(nuevoPerfilPago, perfilUsuario, Convert.ToInt32(Request.Form["IdEmpresa"]));

            }

        }

        private void EliminarMetodoPago()
        {
            string perfilUsuario = Request.Form["idCustomerSQL"];
            string idPaymentProfile = Request.Form["idPaymentProfile"];



         


          
           

            var eliminarMetodo = PagoAuthorize.EliminarMetodoPago(perfilUsuario, idPaymentProfile);

            string nuevoPerfilPago = "";

            if (nuevoPerfilPago != "Error")
            {


               //var x = _nMetodosPago.AgregarMetodoPago(nuevoPerfilPago, perfilUsuario, Convert.ToInt32(Request.Form["IdEmpresa"]));

            }

        }

        #endregion

    }
}