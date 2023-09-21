using ActiveSmartWeb.RegistroActivos.RegistroAct;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.RegistroActivos
{
    public partial class RegistroActivosAjax : System.Web.UI.Page
    {
        DRegistroActivos _dRegistroActivos;
        NRegistroActivos _nRegistroActivos;
        protected void Page_Load(object sender, EventArgs e)
        {
            _dRegistroActivos = new DRegistroActivos();
            _nRegistroActivos = new NRegistroActivos(_dRegistroActivos);
            try
            {
                switch (Request.Form["option"])
                {
                    case "InsertarActivoFijo":
                        //var x=0;
                        var numeroActivo = Request.Form["NumeroActivo"];
                        var numeroPlaca = Request.Form["PlacaActivo"];
                        var marca = Request.Form["Marca"];
                        var modelo = Request.Form["Modelo"];
                        var idEstadoActivo = Convert.ToInt32(Request.Form["IdEstadoActivo"]);
                        var idCategoria = Convert.ToInt32(Request.Form["IdCategoriaActivo"]);
                        var idUbicacion = Convert.ToInt32(Request.Form["IdUbicacionA"]);
                        var idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var numeroSerie = Request.Form["NumeroSerie"];
                        var descripcionCorta = Request.Form["DescripcionCorta"];
                        var descripcionCategoria = Request.Form["DescripcionCategoria"];
                        var descripcionEstado = Request.Form["DescripcionEstado"];
                        var numeroFactura = Request.Form["NumeroFactura"];
                        var fechaCompra = Convert.ToDateTime(Request.Form["FechaCompra"]);
                        decimal costoActivo;

                        var costo = Request.Form["CostoActivo"];
                        if (costo!= "" )
                        {


                            if (costo.Contains(","))
                            {
                               costo = costo.Replace(",", ".");
                                costo = costo + "M";
                            }
                            
                     

                            costoActivo = Convert.ToDecimal(costo);


                        }
                        else
                        {
                            costoActivo = 0M; 
                        }
                        var xhffhg = costoActivo;

                        var resultadoinsertar = _nRegistroActivos.InsertarActivoFijo(numeroActivo, numeroPlaca,
                             marca, modelo, idEstadoActivo, idCategoria, idUbicacion, idPerfilEmpresa,
                            numeroSerie, descripcionCorta, descripcionCategoria, descripcionEstado, numeroFactura, fechaCompra, costoActivo);
                        Response.Write(resultadoinsertar);
                        break;
                    case "ConsultaRegistroActivo":
                        var RegistroActivos = _nRegistroActivos.ConsultaRegistroActivo();
                        Response.Write(JsonConvert.SerializeObject(RegistroActivos, Formatting.Indented));
                        break;
                    case "ActualizaActivoFijo":
                        var idActivo = Convert.ToInt32(Request.Form["IdActivo"]);
                        var acnumeroActivo = Request.Form["NumeroActivo"];
                        var acnumeroPlaca = Request.Form["PlacaActivo"];
                        var acmarca = Request.Form["Marca"];
                        var acmodelo = Request.Form["Modelo"];
                        var acidEstadoActivo = Convert.ToInt32(Request.Form["IdEstadoActivo"]);
                        var acidCategoria = Convert.ToInt32(Request.Form["IdCategoriaActivo"]);
                        var acidUbicacion = Convert.ToInt32(Request.Form["IdUbicacionA"]);
                        var acnumeroSerie = Request.Form["NumeroSerie"];
                        var acdescripcionCorta = Request.Form["DescripcionCorta"];
                        var acdDescripcionCategoria = Request.Form["DescripcionCategoria"];
                        var acdescripcionEstado = Request.Form["DescripcionEstado"];
                        var acnumeroFactura = Request.Form["NumeroFactura"];
                        var acfechaCompra = Convert.ToDateTime(Request.Form["FechaCompra"]);
                        decimal acostoActivo;

                        if (Request.Form["CostoActivo"] != "")
                        {
                            acostoActivo = Convert.ToDecimal(Request.Form["CostoActivo"].Replace(",", "."), CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            acostoActivo = 0M;
                        }

                        var resultadoactualizar = _nRegistroActivos.ActualizaActivoFijo(idActivo, acnumeroActivo, acnumeroPlaca,
                           acmarca, acmodelo, acidEstadoActivo, acidCategoria, acidUbicacion,acnumeroSerie,
                           acdescripcionCorta,acdDescripcionCategoria,acdescripcionEstado,acnumeroFactura,acfechaCompra, acostoActivo);
                        Response.Write(resultadoactualizar);
                        break;

                }
            }catch(Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }


            

        }
    }
}