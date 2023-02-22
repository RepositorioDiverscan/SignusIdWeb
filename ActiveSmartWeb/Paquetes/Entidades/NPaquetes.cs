using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Paquetes.Entidades
{
    public class NPaquetes
    {

        DPaquetes _paquetes = new DPaquetes();

        public NPaquetes()
        {
        }

        //Metodo para hacer la inserción de un paquete
        public string InsertarPaquete(EPaquetes paquete)
        {
            try
            {
                var respuesta = _paquetes.InsertarPaquete(paquete);
                return respuesta;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

        //Metodo para actualizar el paquete
        public string ActualizarPaquete(EPaquetes paquete)
        {
            try
            {
                var respuesta = _paquetes.ActualizarPaquete(paquete);
                return respuesta;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

        //Metodo para consultar los paquetes
        public List<EPaquetes> ConsultarPaquete()
        {
            try
            {
                var paquete = _paquetes.ConsultarPaquetes();
                return paquete;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EPaquetes>();
            }
        }

        //Metodo para consultar un paquete en especifico
        public List<EPaquetes> ConsultarPaqueteX(int idpaquete)
        {
            try
            {
                var paquete = _paquetes.ConsultarPaqueteX(idpaquete);
                return paquete;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EPaquetes>();
            }
        }
    }
}