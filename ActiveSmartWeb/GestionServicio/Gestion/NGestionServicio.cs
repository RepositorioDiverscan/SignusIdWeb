using ActiveSmartWeb.Activos.Activos;
using ActiveSmartWeb.Login.Entidades;
using ActiveSmartWeb.Utilities;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.GestionServicio.Gestion
{
    public class NGestionServicio
    {
        DGestionServicio _gestionServicio = new DGestionServicio();

        public NGestionServicio()
        {
        }

        public string InsertarGestion(EGestionServicio gestionServicio)
        {
            try
            {
                var igestion = _gestionServicio.InsertarGestion(gestionServicio);
                return igestion;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

        public string ActualizarGestion(EGestionServicio gestionServicio)
        {
            try
            {
                var agestion = _gestionServicio.ActualizarGestion(gestionServicio);
                return agestion;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

        public List<EGestionServicio> ObtenerDetalleEmpresa(int id)
        {
            try
            {
                var dgestiones = _gestionServicio.ObtenerDetalleEmpresa(id);
                return dgestiones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EGestionServicio>();
            }
        }

     
        public List<Elogin> ObtenerUsuarios(int IdPerfilEmpresa)
        {
            try
            {
                var dgestiones =  _gestionServicio.ObtenerUsuarios(IdPerfilEmpresa);
                return dgestiones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<Elogin>();
            }
        }

       public List<string> ObtenerActivo(int TipoDeBusqueda, string Buscar, int IdPerfilEmpresa)
        {
            try
            {
                var activo = _gestionServicio.ObtenerActivo(TipoDeBusqueda, Buscar, IdPerfilEmpresa);
                return activo;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<string>();
            }
        }

        public EActivo ObtenerActivoId(int IdActivo)
        {
            try
            {
                var activo = _gestionServicio.ObtenerActivoId(IdActivo);
                return activo;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new EActivo();
            }
        }

    }
}