using ActiveSmartWeb.RegistroUsuarioEmpresas.IdiomaPlanes;
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
    public partial class AjaxPlanIdioma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaPlanesGeneral eIdioma = new EIdiomaPlanesGeneral();

            try
            {
                switch (Request.Form["idi"])
                {
                    case "ES":
                       

                        eIdioma.Titulo =                EIdiomaPlanesEspanol.Titulo;
                        eIdioma.DescripcionFree =       EIdiomaPlanesEspanol.DescripcionFree;
                        eIdioma.DescripcionBasic =      EIdiomaPlanesEspanol.DescripcionBasic;
                        eIdioma.DescripcionPro =        EIdiomaPlanesEspanol.DescripcionPro;
                        eIdioma.DescripcionBusiness =   EIdiomaPlanesEspanol.DescripcionBusiness;
                        eIdioma.MontoUsuarioFree =      EIdiomaPlanesEspanol.MontoUsuarioFree;
                        eIdioma.MontoUsuarioBasic =     EIdiomaPlanesEspanol.MontoUsuarioBasic;
                        eIdioma.MontoUsuarioPro =       EIdiomaPlanesEspanol.MontoUsuarioPro;
                        eIdioma.MontoUsuarioBusiness =  EIdiomaPlanesEspanol.MontoUsuarioBusiness;
                        eIdioma.FacturaFree =           EIdiomaPlanesEspanol.FacturaFree;
                        eIdioma.FacturaPro =            EIdiomaPlanesEspanol.FacturaPro;
                        eIdioma.FacturaBusiness =       EIdiomaPlanesEspanol.FacturaBusiness;
                        eIdioma.FacturaBasic =          EIdiomaPlanesEspanol.FacturaBasic;
                        eIdioma.BtnFree = EIdiomaPlanesEspanol.BtnFree;
                        eIdioma.BtnBasic = EIdiomaPlanesEspanol.BtnBasic;
                        eIdioma.BtnPro = EIdiomaPlanesEspanol.BtnPro;
                        eIdioma.BtnBusiness = EIdiomaPlanesEspanol.BtnBusiness;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;

                    case "EN":

                        eIdioma.Titulo =                 EIdiomInglesaPlanes.Titulo;
                        eIdioma.DescripcionFree =        EIdiomInglesaPlanes.DescripcionFree;
                        eIdioma.DescripcionBasic =       EIdiomInglesaPlanes.DescripcionBasic;
                        eIdioma.DescripcionPro =         EIdiomInglesaPlanes.DescripcionPro;
                        eIdioma.DescripcionBusiness =    EIdiomInglesaPlanes.DescripcionBusiness;
                        eIdioma.MontoUsuarioFree =       EIdiomInglesaPlanes.MontoUsuarioFree;
                        eIdioma.MontoUsuarioBasic =      EIdiomInglesaPlanes.MontoUsuarioBasic;
                        eIdioma.MontoUsuarioPro =        EIdiomInglesaPlanes.MontoUsuarioPro;
                        eIdioma.MontoUsuarioBusiness =   EIdiomInglesaPlanes.MontoUsuarioBusiness;
                        eIdioma.FacturaFree =            EIdiomInglesaPlanes.FacturaFree;
                        eIdioma.FacturaPro =             EIdiomInglesaPlanes.FacturaPro;
                        eIdioma.FacturaBasic = EIdiomInglesaPlanes.FacturaBasic;

                        eIdioma.FacturaBusiness = EIdiomInglesaPlanes.FacturaBusiness;
                        eIdioma.BtnFree = EIdiomInglesaPlanes.BtnFree;
                        eIdioma.BtnBasic = EIdiomInglesaPlanes.BtnBasic;
                        eIdioma.BtnPro = EIdiomInglesaPlanes.BtnPro;
                        eIdioma.BtnBusiness = EIdiomInglesaPlanes.BtnBusiness;


                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;


                    default:

                        eIdioma.Titulo = EIdiomaPlanesEspanol.Titulo;
                        eIdioma.DescripcionFree = EIdiomaPlanesEspanol.DescripcionFree;
                        eIdioma.DescripcionBasic = EIdiomaPlanesEspanol.DescripcionBasic;
                        eIdioma.DescripcionPro = EIdiomaPlanesEspanol.DescripcionPro;
                        eIdioma.DescripcionBusiness = EIdiomaPlanesEspanol.DescripcionBusiness;
                        eIdioma.MontoUsuarioFree = EIdiomaPlanesEspanol.MontoUsuarioFree;
                        eIdioma.MontoUsuarioBasic = EIdiomaPlanesEspanol.MontoUsuarioBasic;
                        eIdioma.MontoUsuarioPro = EIdiomaPlanesEspanol.MontoUsuarioPro;
                        eIdioma.MontoUsuarioBusiness = EIdiomaPlanesEspanol.MontoUsuarioBusiness;
                        eIdioma.FacturaFree = EIdiomaPlanesEspanol.FacturaFree;
                        eIdioma.FacturaPro = EIdiomaPlanesEspanol.FacturaPro;
                        eIdioma.FacturaBusiness = EIdiomaPlanesEspanol.FacturaBusiness;
                        eIdioma.FacturaBasic = EIdiomaPlanesEspanol.FacturaBasic;
                        eIdioma.BtnFree = EIdiomaPlanesEspanol.BtnFree;
                        eIdioma.BtnBasic = EIdiomaPlanesEspanol.BtnBasic;
                        eIdioma.BtnPro = EIdiomaPlanesEspanol.BtnPro;
                        eIdioma.BtnBusiness = EIdiomaPlanesEspanol.BtnBusiness;

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