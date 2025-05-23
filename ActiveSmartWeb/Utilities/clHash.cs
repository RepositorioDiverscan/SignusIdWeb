﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;



namespace ActiveSmartWeb.Utilities
{
    public class clHash
    {
        /// <summary>
        /// Descripción: Encripta el texto de cada pass
        /// Autor y Fecha: Leonardo Cortes Mora. 4-6-13
        /// </summary>
        /// <param name="texto">Texto a encriptar</param>
        /// <returns></returns>
        public string CrearHash2(string texto)
        {
            string textoHash = Cryptographer.CreateHash("passwordHash", texto);
            return textoHash;
        }

        /// <summary>
        /// Descripción: Retorna true si una palabra coincide con un textoHash
        /// medoto del Enterprise Librery
        /// Autor y Fecha: Leonardo Cortes Mora. 4-6-13
        /// </summary>
        /// <param name="textoProbar">Texto a Comparar</param>
        /// <param name="textoHash">Texto Encriptado</param>
        /// <returns></returns>
        public bool CompararHash(string textoProbar, string textoHash)
        {
            bool result = Cryptographer.CompareHash("passwordHash", textoProbar, textoHash);
            return result;
        }


        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }

        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {

            // Hash the input. 
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Verify a hash against a string. 
        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash, string PassSuperAdmin)
        {

            // Hash the input. 
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                if (0 == comparer.Compare(hashOfInput, PassSuperAdmin))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }//fin class
}//fin namespace

