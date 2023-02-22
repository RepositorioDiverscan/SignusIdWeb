using ActiveSmartWeb.Empleados.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Empleados.Ajax
{
    public partial class AjaxEmpleados : System.Web.UI.Page
    {
        NEmpleados nempleaados = new NEmpleados();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Request.Form["option"]) {
                    //Consulta de empleados por empresa
                    case "ConsultarEmpleadosXEmpresa":
                        var IdEmpresa = Convert.ToInt32(Request.Form["IdEmpresa"]);
                        var listaEmpleados = nempleaados.ConsultarEmpleadoXEmpresa(IdEmpresa);
                        Response.Write(JsonConvert.SerializeObject(listaEmpleados, Formatting.Indented));
                        break;

                    //Insertar empleado
                    case "InsertarEmpleado":
                        var EmpleadoJson = Request.Form["NuevoEmpleado"];
                        EEmpleados empleado = JsonConvert.DeserializeObject<EEmpleados>(EmpleadoJson);
                        var ResultadoInsert = nempleaados.InsertarEmpleado(empleado);
                        Response.Write(ResultadoInsert);
                        break;

                    //Consulta de empleados según estado
                    case "ConsultarEmpleadosEstado":
                        var IdEmp = Convert.ToInt32(Request.Form["IdEmpresa"]);
                        var All = Convert.ToString(Request.Form["Estado"]);
                        if (String.IsNullOrEmpty(All) || All.Equals("All"))
                        {
                            var listaEmp = nempleaados.ConsultarEmpleadoXEmpresa(IdEmp);
                            Response.Write(JsonConvert.SerializeObject(listaEmp, Formatting.Indented));
                        }
                        else
                        {
                            var Estado = Convert.ToBoolean(Request.Form["Estado"]);
                            var listaEmp = nempleaados.ConsultarEmpleadoEstado(IdEmp, Estado);
                            Response.Write(JsonConvert.SerializeObject(listaEmp, Formatting.Indented));
                        }
                        break;
                    //Actualizar estado empleado
                    case "ModificarEstadoEmpleado":
                        var Est = Convert.ToBoolean(Request.Form["Estado"]);
                        var IdEmpleado = Convert.ToInt32(Request.Form["IdEmpleado"]);
                        var Resultado = nempleaados.ActualizarEstadoEmpleado(Est,IdEmpleado);
                        Response.Write(Resultado);
                        break;

                        //Consulta los empleados por identificación
                    case "ConsultarEmpleadoXIdentificacion":
                        var Emp = Convert.ToInt32(Request.Form["IdEmpresa"]);
                        var IdentEmpleado = Convert.ToString(Request.Form["IdEmpleado"]);
                        var Empleado = nempleaados.ConsultarEmpleadoXIdentificacion(Emp, IdentEmpleado);
                        Response.Write(JsonConvert.SerializeObject(Empleado, Formatting.Indented));
                        break;
                }
            }
            catch
            {

            }
        }
    }
}