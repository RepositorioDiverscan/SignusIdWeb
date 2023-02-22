using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.Paquetes.Entidades;
using Newtonsoft.Json;

namespace ActiveSmartWeb.Paquetes.Ajax
{
    public partial class AjaxPaquetes : System.Web.UI.Page
    {
        //Hoala
        NPaquetes npaquetes = new NPaquetes();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Request.Form["option"])
                {
                    //Consulta de los paquetes
                    case "ConsultarPaquete":
                        var listaPaquetes = npaquetes.ConsultarPaquete();
                        Response.Write(JsonConvert.SerializeObject(listaPaquetes, Formatting.Indented));
                        break;

                    //Insertar un paquete
                    case "InsertarPaquete":
                        var PaqueteJson = Request.Form["NuevoPaquete"];
                        EPaquetes paquete = JsonConvert.DeserializeObject<EPaquetes>(PaqueteJson);
                        var ResultadoInsert = npaquetes.InsertarPaquete(paquete);
                        Response.Write(ResultadoInsert);
                        break;


                    //Actualizar un paquete
                    case "ActualizarPaquete":
                        var APaqueteJson = Request.Form["ActualizarPaquete"];
                        EPaquetes Apaquete = JsonConvert.DeserializeObject<EPaquetes>(APaqueteJson);
                        var Resultado = npaquetes.ActualizarPaquete(Apaquete);
                        Response.Write(Resultado);
                        break;

                    //Consultar un paquete en especifico
                    case "ConsultarPaqueteX":
                        var IdPaquete = Convert.ToInt32(Request.Form["IdPaquete"]);
                        var XResultado = npaquetes.ConsultarPaqueteX(IdPaquete);
                        Response.Write(JsonConvert.SerializeObject(XResultado, Formatting.Indented));
                        break;
                }
            }
            catch
            {

            }
        }
    }
}