using ActiveSmartWeb.Recursos.JSON;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Registro
{
    public class NUsuarioEmpresa
    {

        DBUsuarioEmpresa dBUsuarioEmpresa = new DBUsuarioEmpresa();


        public string IngresarUsuarioEmpresa(EUsuarioEmpresa eUsuarioEmpresa)
        {
            try
            {

                return dBUsuarioEmpresa.RegistrarUsuarioEmpresa(eUsuarioEmpresa);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        public string GenerarNuevoCodigo(string correo)
        {
            try
            {

                return dBUsuarioEmpresa.GenerarNuevoCodigo(correo);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        public List<EIndustria> CargarIndustrias()
        {
            try
            {

                return dBUsuarioEmpresa.CargarIndustrias();

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        public List<EEmpresaTamano> CargarEmpresaTamano()
        {
            try
            {

                return dBUsuarioEmpresa.CargarEmpresaTamano();

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        public string ValidarCodigo(string correo, string codigo)
        {
            try
            {

                return dBUsuarioEmpresa.ValidarCodigo(correo, codigo);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        //Metodo carga los adicionales, conectando la capa de datos con los ajax.
        public List<EPaqueteAdicional> CargarAdicionales()
        {
            try
            {

                return dBUsuarioEmpresa.CargarAdicionales();

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        //Metodo carga el plan seleccionado, conectando la capa de datos con los ajax.
        public ETipoPlanes CargarPlan(int idplan)
        {
            try
            {

                return dBUsuarioEmpresa.CargarPlan(idplan);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new ETipoPlanes();

            }
        }

        //Metodo inserta el contrato, conectando la capa de datos con los ajax.
        public string InsertarContrato(string correo, int frecuenciapago, int idtipocontrato, List<EPaqueteAdicionalContratado> PaquetesAdicionales)
        {
            try
            {

                return dBUsuarioEmpresa.InsertarContrato(correo,frecuenciapago,idtipocontrato,PaquetesAdicionales);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        public string InsertarContratoConSuscripcion(string correo, int frecuenciapago, int idtipocontrato, List<EPaqueteAdicionalContratado> PaquetesAdicionales)
        {
            try
            {

                return dBUsuarioEmpresa.InsertarContratoConSuscripcion(correo, frecuenciapago, idtipocontrato, PaquetesAdicionales);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        public string SeleccionMoneda(string codPais, List<Monedas> monedas)
        {
            string monedaSeleccionada = "USD $";
            foreach (Monedas moneda in monedas)
            {
                var hola = moneda.Codigo.Substring(0, 2);
                var adios = codPais.ToUpper();
                if (moneda.Codigo.Substring(0, 2).Equals(codPais.ToUpper()))
                {
                    monedaSeleccionada = moneda.Codigo + " " + moneda.Simbolo;
                    break;
                }
            }

            return monedaSeleccionada;
        }

    }
}