using ActiveSmartWeb.Authorize;
using ActiveSmartWeb.MetodosPago.Entidades;
using ActiveSmartWeb.RegistroUsuarioEmpresas.Registro;
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
            switch (Request.Form["Opcion"])
            {
                case "CargarMetodos":
                    ObtenerMetodosPago();
                    break;
            }
        }

        #region Metodos

        private void ObtenerMetodosPago()
        {
            int idEmpresa = Convert.ToInt32(Request.Form["IdEmpresa"]);

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
                    metodoPago.Estado = ValidarExpiracionTarjeta(metodoPago.FechaExpiracion);
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

        #endregion

    }
}