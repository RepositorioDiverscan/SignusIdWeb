using ActiveSmartWeb.MetodosPago.Entidades;
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
                    Response.Write(ObtenerMetodosPago());
                    break;
            }
        }

        #region Metodos

        private string ObtenerMetodosPago()
        {
            int idEmpresa = Convert.ToInt32(Request.Form["IdEmpresa"]);

            //Obtiene el id del perfil de usuario de Authorize
            string perfilUsuario = _nMetodosPago.ObtenerPerfilUsuario(idEmpresa);

            //Obtiene los perfiles de pago del usuario de BD
            List<EPerfilPago> perfilesPago = _nMetodosPago.ObtenerPerfilesPago(idEmpresa);

            

            return perfilUsuario;

        }

        #endregion

    }
}