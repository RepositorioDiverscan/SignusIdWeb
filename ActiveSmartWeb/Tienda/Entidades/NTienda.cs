using ActiveSmartWeb.Perfil;
using ActiveSmartWeb.RegistroUsuarioEmpresas.Registro;
using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Tienda.Entidades
{
    public class NTienda
    {
        DBTienda _dbTienda = new DBTienda();

        public int obtenerFrecuenciaPagoPorIdEpresa(int idEmpresa)
        {
            try
            {
                return Convert.ToInt32(_dbTienda.obtenerFrecuenciaPagoPorIdEpresa(idEmpresa));
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return -1;
            }

        }

        public string obtenerTipoContratoPorIdEpresa(int idEmpresa)
        {
            try
            {
                return _dbTienda.obtenerTipoContratoPorIdEpresa(idEmpresa);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }

        }

        public string ActualizarPlan(int idPerfilUsuario, List<EPaqueteAdicionalContratado> PaquetesAdicionales)
        {
            try
            {

                return _dbTienda.ActualizarPlan(idPerfilUsuario, PaquetesAdicionales);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        public List<EPaqueteAdicional> CargarAdicionales(int idPerfilActive)
        {
            try
            {

                return _dbTienda.CargarAdicionales(idPerfilActive);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

    }
}