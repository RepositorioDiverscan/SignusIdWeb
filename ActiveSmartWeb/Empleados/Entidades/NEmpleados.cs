using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ActiveSmartWeb.Empleados.Entidades
{
    public class NEmpleados
    {

        DEmpleados _empleados = new DEmpleados();

        public NEmpleados()
        {
        }

        //Metodo para hacer la inserción y actualización de un empleado
        public string InsertarEmpleado(EEmpleados empleados)
        {
            var respuesta = "";
            string formatoEmail = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(empleados.Correo, formatoEmail))
            {
                if (Regex.Replace(empleados.Correo, formatoEmail, String.Empty).Length == 0)
                {
                            try
                            {
                                respuesta = _empleados.InsertarEmpleado(empleados);
                                return respuesta;
                            }
                            catch (Exception ex)
                            {
                                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                                return "";
                            }
                }
                else
                {
                    return "Correo";
                }
            }
            else
            {
                return "Correo";
            }
            
        }

        //Metodo para actualizar el estado de un empleado
        public string ActualizarEstadoEmpleado(bool Estado, int idEmpleado)
        {
            try
            {
                var empleado = _empleados.ActualizarEstadoEmpleado( Estado,  idEmpleado);
                return empleado;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

        //Metodo para consultar los empleados de una empresa
        public List<EEmpleados> ConsultarEmpleadoXEmpresa(int idEmpresa)
        {
            try
            {
                var empleado = _empleados.ConsultarEmpleadoXEmpresa(idEmpresa);
                return empleado;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EEmpleados>();
            }
        }
        //Metodo para consultar los empleados de una empresa segun su estado
        public List<EEmpleados> ConsultarEmpleadoEstado(int idEmpresa, bool estado)
        {
            try
            {
                var empleado = _empleados.ConsultarEmpleadoEstado(idEmpresa, estado);
                return empleado;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EEmpleados>();
            }
        }
        //Metodo para consultar el detalle de un empleado por identificacion
        public List<EEmpleados> ConsultarEmpleadoXIdentificacion(int idEmpresa, string Identificacion)
        {
            try
            {
                var empleado = _empleados.ConsultarEmpleadoXIdentificacion(idEmpresa, Identificacion);
                return empleado;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EEmpleados>();
            }
        }
    }
}