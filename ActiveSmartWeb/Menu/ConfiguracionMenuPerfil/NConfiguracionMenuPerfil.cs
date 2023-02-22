using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Menu.ConfiguracionMenuPerfil
{
    public class NConfiguracionMenuPerfil
    {
        public readonly IDConfiguracionMenuPerfil _idConfiguracionMenu;
        DConfiguracionMenuPerfil _dConfiguracionMenuPerfil = new DConfiguracionMenuPerfil();
        public NConfiguracionMenuPerfil(IDConfiguracionMenuPerfil dConfiguracionMenu)
        {
            if (dConfiguracionMenu is null)
                throw new ArgumentNullException("dConfiguracionMenu", "dConfiguracionMenu is null");

            _idConfiguracionMenu = dConfiguracionMenu;
        }

        public EConfiguracionMenuPerfil ObtenerObtenerConfiguracionPerfil(int idPerfilActive, int idPerfilEmpresa)
        {
            try
            {
                var eConfiguracionMenuPerfil = _idConfiguracionMenu.ObtenerConfiguracionPerfil(idPerfilActive, idPerfilEmpresa);
                return eConfiguracionMenuPerfil;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new EConfiguracionMenuPerfil();
            }
        }

        public int ConsultarTomasCompletas(int idPerfilActive)
        {
            int tomas;
            try
            {
                return tomas = _dConfiguracionMenuPerfil.ConsultarTomasCompletas(idPerfilActive);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return 0;
            }
        }

        public int ConsultarTomasVencidas(int idPerfilActive)
        {
            int tomas;
            try
            {
                return tomas = _dConfiguracionMenuPerfil.ConsultarTomasVencidas(idPerfilActive);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return 0;
            }
        }

        public int ConsultarTomasPendientes(int idPerfilActive)
        {
            int tomas;
            try
            {
                return tomas = _dConfiguracionMenuPerfil.ConsultarTomasPendientes(idPerfilActive);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return 0;
            }
        }

        public int ConsultarIncidentes(int IdPerfilUsuario)
        {
            int total = 0;
            try
            {
                total = _idConfiguracionMenu.ConsultarIncidentes(IdPerfilUsuario);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return 0;
            }

            return total;
        }

        public string ActualizarEstadoTomas()
        {
            var respuesta = "";
            try
            {
                respuesta = _idConfiguracionMenu.ActualizarEstadoTomas();
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }

            return respuesta;

        }

        public int ConsultarTomasIncompletas(int idPerfilActive)
        {
            int total = 0;
            try
            {
                total = _idConfiguracionMenu.ConsultarTomasIncompletas(idPerfilActive);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return 0;
            }

            return total;
        }

    }
}