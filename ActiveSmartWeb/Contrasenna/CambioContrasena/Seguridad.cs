using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ActiveSmartWeb.Contrasenna.CambioContrasena
{
    public static class Seguridad
    {
        private static string LongitudAdmin = @"^\w{10,50}\b";
        private static string LongitudNormal    =  @"^\w{8,50}\b";
        private static string Numeros     = @"\d";
        private static string Especiales  = @"[ñÑ\-_¿.#¡*$&@]";
        private static string Mayusculas  = @"[A-Z]";
        private static string Minusculas = @"[a-z]";


        private static Match matchLongitud;
        private static Match matchNumeros;
        private static Match matchEspeciales;
        private static Match matchMayusculas;
        private static Match matchMinusculas;

        ///<summary>
        ///Método que comprueba sí una cadena de texto contiene los valores necesarios 
        ///para cumplir con la norma iso 27001:A9.4.3 password management policy
        ///</summary>
        ///<remarks>
        ///Devuelve un numero que indica sí es 0 todo estuvo correcto, de lo contrario
        ///hubo algún error
        ///</remarks>
        public static int CompruebaNormal(string cadena)
        {
             matchLongitud = Regex.Match(cadena, LongitudNormal);
             matchNumeros = Regex.Match(cadena, Numeros);
             matchEspeciales = Regex.Match(cadena, Especiales);
             matchMayusculas = Regex.Match(cadena, Mayusculas);
             matchMinusculas = Regex.Match(cadena, Minusculas);

            return Analiza();

        }

        public static int CompruebaAdmin(string cadena)
        {
            matchLongitud = Regex.Match(cadena, LongitudAdmin);
            matchNumeros = Regex.Match(cadena, Numeros);
            matchEspeciales = Regex.Match(cadena, Especiales);
            matchMayusculas = Regex.Match(cadena, Mayusculas);
            matchMinusculas = Regex.Match(cadena, Minusculas);

            return Analiza();

        }
        private static int Analiza()
        {
            bool error = false;
            int codigoError = 0;

            
            if (!matchLongitud.Success)
            {
                error = true;
                codigoError = 1;

            } else


            if (error || !matchNumeros.Success)
            {
                error = true;
                codigoError = 2;
            } else


            if (error || !matchEspeciales.Success)
            {
                error = true;
                codigoError = 3;
            } else

            if (error || !matchMayusculas.Success)
            {
                error = true;
                codigoError = 4;
            } else

            if (error || !matchMinusculas.Success)
            {
                error = true;
                codigoError = 5;
            }



            return codigoError;
        }

    }
}