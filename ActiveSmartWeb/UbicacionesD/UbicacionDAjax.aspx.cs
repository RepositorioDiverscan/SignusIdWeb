using ActiveSmartWeb.Utilities;
using ActiveSmartWeb.UbicacionesD.UbicacionD;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.UbicacionesD
{
    public partial class UbicacionDAjax : System.Web.UI.Page
    {
        NUbicacionD nUbicacionD = new NUbicacionD();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Request.Form["option"])
                {

                    case "ConsultarUbicacionesA":
                        var idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresaU"]);
                        var listaUbisA = nUbicacionD.ConsultarUbicacionesA(idPerfilEmpresa);
                        Response.Write(JsonConvert.SerializeObject(listaUbisA, Formatting.Indented));
                        break;

                    case "ConsultarUbicacionesB":
                        idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresaU"]);
                        var idUbicacionA1 = Convert.ToInt32(Request.Form["IdUbicacionA"]);
                        var listaUbisb = nUbicacionD.ConsultarUbicacionesB(idPerfilEmpresa, idUbicacionA1);
                        Response.Write(JsonConvert.SerializeObject(listaUbisb, Formatting.Indented));
                        break;
                    case "ConsultarUbicacionesC":
                        idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresaU"]);
                        var idUbicacionB = Convert.ToInt32(Request.Form["IdUbicacionB"]);
                        var listaUbisc = nUbicacionD.ConsultarUbicacionesC(idPerfilEmpresa, idUbicacionB);
                        Response.Write(JsonConvert.SerializeObject(listaUbisc, Formatting.Indented));
                        break;
                    case "RegistrarUbicacionD":
                        var IdUbicacionC = Convert.ToInt32(Request.Form["IdUbicacionC"]);
                        var Nombre = Request.Form["Nombre"];
                        var Descripcion = Request.Form["Descripcion"];
                        var IdPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfil_Empresa"]);
                        var resultadoInsercion = nUbicacionD.InsertarUbicacion(Nombre, Descripcion, IdPerfilEmpresa, IdUbicacionC);
                        Response.Write(resultadoInsercion);
                        break;

                    case "ConsultaUbicacionxIdUbicacionC"://
                        var IdUbica = Convert.ToInt32(Request.Form["IdUbicacionC"]);
                        var listaUbisCId = nUbicacionD.ConsultaUbicacionxIdUbicacionC(IdUbica);
                        Response.Write(listaUbisCId);
                        break;

                    case "ConsultarUbicacionesD":
                        idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresaU"]);
                        var listaUbisD = nUbicacionD.ConsultarUbicacionesD(idPerfilEmpresa);
                        Response.Write(JsonConvert.SerializeObject(listaUbisD, Formatting.Indented));
                        break;

                    case "ConsultarUbicacionesByC":
                        var idUbicacionBC = Convert.ToInt32(Request.Form["idUbicacionB"]);
                        var idUbicacionC = Convert.ToInt32(Request.Form["idUbicacionC"]);
                        var listaUbisBc = nUbicacionD.ConsultarUbicacionesB(idUbicacionBC, idUbicacionC);
                        Response.Write(JsonConvert.SerializeObject(listaUbisBc, Formatting.Indented));
                        break;

                    case "ConsultaUbicacionesPorIdD":
                        var idUbi = Convert.ToInt32(Request.Form["IdUbiD"]);
                        var listaIDS = nUbicacionD.ConsultarUbicacionesPorIdD(idUbi);
                        Response.Write(JsonConvert.SerializeObject(listaIDS, Formatting.Indented));
                        break;

                    case "ActualizaUbicacionD":
                        var IdUbicacionD = Convert.ToInt32(Request.Form["IdUbicacionD"]);
                        IdUbicacionC = Convert.ToInt32(Request.Form["IdUbicacionC"]);
                        Nombre = Request.Form["Nombre"];
                        Descripcion = Request.Form["Descripcion"];
                        var resultadoActualizar = nUbicacionD.ActualizaUbicacion(IdUbicacionD, IdUbicacionC, Nombre, Descripcion);
                        Response.Write(resultadoActualizar);
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