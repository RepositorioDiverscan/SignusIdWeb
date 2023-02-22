using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Utilities
{
    public class CLErrores
    {
        public static void EscribirError(string error, string traceError)
        {
            // Lee el .config de la capa de servicios que lo llama
            var ruta = ConfigurationManager.AppSettings["RutaLogErrores"];

            ruta = ruta + "Errores_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

            // Crea o Abre el archivo para ecribir en el.
            using (var sw = File.AppendText(ruta))
            {
                sw.WriteLine("********************************************************************************************************");
                sw.WriteLine("********************************************************************************************************");
                sw.WriteLine(DateTime.Now.ToString(CultureInfo.InvariantCulture));
                sw.WriteLine(error);
                sw.WriteLine(traceError);
                sw.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////");
            }
        }

        /// <summary>
        /// Descripción: Crea un registro de error general.
        /// Autor y Fecha: Francisco Torres. 16/09/2014.
        /// </summary>
        /// <param name="exception">Excepción que se quiere registrar en el Log de Errores</param>
        public static void EscribirError(Exception exception)
        {
            EscribirError(exception.Message, exception.StackTrace);
        }
    }
}