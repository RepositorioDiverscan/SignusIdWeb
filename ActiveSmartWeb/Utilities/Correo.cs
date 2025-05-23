﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Web;

namespace ActiveSmartWeb.Utilities
{
    public class Correo
    {

        public static int EnviarCorreo(string Destinatatio, string Asunto, string Mensaje)
        {

            //Correo de envio.
            var correode = ConfigurationManager.AppSettings["CorreoSignus"];
            var pass = ConfigurationManager.AppSettings["PassSignus"];

            string correofrom = ConfigurationManager.AppSettings["CorreoNoReply"];

            MailMessage correo = new MailMessage();
            try
            {
                // hlnorislpucdyrux
                correo.From = new MailAddress(correofrom, "no-reply", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(Destinatatio); //Correo destino
                correo.Subject = Asunto; //Asunto
                correo.Body = Mensaje; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                smtp.Port = 587; //Puerto de salida

                smtp.Credentials = new System.Net.NetworkCredential(correode, pass);//Cuenta de correo "Diverscan2022."
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl

                smtp.Send(correo);

                return 0;
            }
            catch (Exception e)
            {
                CLErrores.EscribirError(e.Message, e.StackTrace);
                return -1;
            }

        }

        public static int EnviarCorreoContrasenna(string Destinatatio, string Asunto, string Mensaje)
        {

            //Correo de envio.
            var correode = ConfigurationManager.AppSettings["CorreoSignus"];
            var pass = ConfigurationManager.AppSettings["PassSignus"];

            string correofrom = ConfigurationManager.AppSettings["CorreoNoReply"];

            MailMessage correo = new MailMessage();
            try
            {
                // hlnorislpucdyrux
                correo.From = new MailAddress(correofrom, "no-reply", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(Destinatatio); //Correo destino
                correo.Subject = Asunto; //Asunto
                correo.Body = Mensaje; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                //Cuerpo de correo
              
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantillastxt/contraseña signus id 2.txt");
                string cuerpoCorreo;
                using (var stringReader = new StreamReader(rutaArchivo)) 
                {
                    cuerpoCorreo = stringReader.ReadToEnd();
                }

                string _cuerpoCorreo = cuerpoCorreo.Replace("@contrasenna", Mensaje);


                var plainView = AlternateView.CreateAlternateViewFromString(Regex.Replace(_cuerpoCorreo, @"<(.|\n)*?>", string.Empty), null, "text/plain");

                var htmlView = AlternateView.CreateAlternateViewFromString(_cuerpoCorreo, null, "text/html");


                correo.AlternateViews.Add(plainView);
                correo.AlternateViews.Add(htmlView);


                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                smtp.Port = 587; //Puerto de salida

                smtp.Credentials = new System.Net.NetworkCredential(correode, pass);//Cuenta de correo "Diverscan2022."
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl

                smtp.Send(correo);

                return 0;
            }
            catch (Exception e)
            {
                CLErrores.EscribirError(e.Message, e.StackTrace);
                return -1;
            }

        }

        //Mensaje predeterminado que se le envia al cliente al llenar el formulario de contacto
        public static int EnviarCorreoContactoCliente(string Destinatario)
        {

            //Correo de envio.
            var correode = ConfigurationManager.AppSettings["CorreoSignus"];
            var pass = ConfigurationManager.AppSettings["PassSignus"];

            string correofrom = ConfigurationManager.AppSettings["CorreoNoReply"];


            //Mensajes con la informacion brindada.

            MailMessage correo = new MailMessage();
            try
            {

                //Cuerpo de correo
                string cuerpoCorreo;
                using (var stringReader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantillastxt", "ContactoCliente.txt"), true))
                {
                    cuerpoCorreo = stringReader.ReadToEnd();
                }


                // hlnorislpucdyrux
                correo.From = new MailAddress(correofrom, "no-reply", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(Destinatario); //Correo destino
                correo.Subject = "Contacto Signus ID"; //Asunto
                correo.Body = cuerpoCorreo; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;


                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = ConfigurationManager.AppSettings["ServerSmtp"]; //Host del servidor de correo
                smtp.Port = Convert.ToInt32(ConfigurationManager.AppSettings["PortSmtp"]); //Puerto de salida

                smtp.Credentials = new System.Net.NetworkCredential(correode, pass);//Cuenta de correo "Diverscan2022."
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl

                smtp.Send(correo);

                return 0;
            }
            catch (Exception e)
            {
                CLErrores.EscribirError(e.Message, e.StackTrace);
                return -1;
            }

        }

        //Mensaje que se envia al correo de signus con la informacion suministrada
        //por el cliente en el formulario de contacto
        public static int EnviarCorreoContactoInformacion(string asunto, string nombre, string apellido, string correoUsuario, string numero, string mensaje)
        {

            //Correo de envio.
            var correode = ConfigurationManager.AppSettings["CorreoSignus"];
            var pass = ConfigurationManager.AppSettings["PassSignus"];

            string correofrom = ConfigurationManager.AppSettings["CorreoSupport"];


            //Mensajes con la informacion brindada.

            MailMessage correo = new MailMessage();
            try
            {

                //Cuerpo de correo
                string cuerpoCorreo;
                using (var stringReader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantillastxt", "ContactoInformacionCliente.txt"), true))
                {
                    cuerpoCorreo = stringReader.ReadToEnd();
                }

                cuerpoCorreo = cuerpoCorreo.Replace("@Asunto", asunto);
                cuerpoCorreo = cuerpoCorreo.Replace("@Nombre", nombre);
                cuerpoCorreo = cuerpoCorreo.Replace("@Apellido", apellido);
                cuerpoCorreo = cuerpoCorreo.Replace("@Correo", correoUsuario);
                cuerpoCorreo = cuerpoCorreo.Replace("@Numero", numero);
                cuerpoCorreo = cuerpoCorreo.Replace("@Mensaje", mensaje);

                // hlnorislpucdyrux
                correo.From = new MailAddress(correofrom, "Solicitud de contacto", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(correofrom); //Correo destino
                correo.Subject = "Contacto Signus ID"; //Asunto
                correo.Body = cuerpoCorreo; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;


                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = ConfigurationManager.AppSettings["ServerSmtp"]; //Host del servidor de correo
                smtp.Port = Convert.ToInt32(ConfigurationManager.AppSettings["PortSmtp"]); //Puerto de salida

                smtp.Credentials = new System.Net.NetworkCredential(correode, pass);//Cuenta de correo "Diverscan2022."
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl

                smtp.Send(correo);

                return 0;
            }
            catch (Exception e)
            {
                CLErrores.EscribirError(e.Message, e.StackTrace);
                return -1;
            }

        }

        //Mensaje que se envia al correo de signus con la informacion suministrada
        //por el cliente en el formulario de incidentes
        public static int EnviarCorreoIncidenteInformacion(string asunto, string nombre, string apellido, string correoUsuario, string numero, string mensaje, string idPerfilActive)
        {

            //Correo de envio.
            var correode = ConfigurationManager.AppSettings["CorreoSignus"];
            var pass = ConfigurationManager.AppSettings["PassSignus"];

            string correofrom = ConfigurationManager.AppSettings["CorreoSupport"];


            //Mensajes con la informacion brindada.

            MailMessage correo = new MailMessage();
            try
            {

                //Cuerpo de correo
                string cuerpoCorreo;
                using (var stringReader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantillastxt", "ReporteIncidenteInformacion.txt"), true))
                {
                    cuerpoCorreo = stringReader.ReadToEnd();
                }

                cuerpoCorreo = cuerpoCorreo.Replace("@Id", idPerfilActive);
                cuerpoCorreo = cuerpoCorreo.Replace("@Asunto", asunto);
                cuerpoCorreo = cuerpoCorreo.Replace("@Nombre", nombre);
                cuerpoCorreo = cuerpoCorreo.Replace("@Apellido", apellido);
                cuerpoCorreo = cuerpoCorreo.Replace("@Correo", correoUsuario);
                cuerpoCorreo = cuerpoCorreo.Replace("@Numero", numero);
                cuerpoCorreo = cuerpoCorreo.Replace("@Mensaje", mensaje);

                // hlnorislpucdyrux
                correo.From = new MailAddress(correofrom, "REPORTE DE INCIDENTE", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(correofrom); //Correo destino
                correo.Subject = "Reporte de incidente"; //Asunto
                correo.Body = cuerpoCorreo; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;


                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = ConfigurationManager.AppSettings["ServerSmtp"]; //Host del servidor de correo
                smtp.Port = Convert.ToInt32(ConfigurationManager.AppSettings["PortSmtp"]); //Puerto de salida

                smtp.Credentials = new System.Net.NetworkCredential(correode, pass);//Cuenta de correo "Diverscan2022."
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl

                smtp.Send(correo);

                return 0;
            }
            catch (Exception e)
            {
                CLErrores.EscribirError(e.Message, e.StackTrace);
                return -1;
            }

        }

        public static int EnviarCorreoCodigo(string Destinatatio, string Asunto, string Mensaje, string Codigo)
        {

            //Correo de envio.
            var correode = ConfigurationManager.AppSettings["CorreoSignus"];
            var pass = ConfigurationManager.AppSettings["PassSignus"];

            string correofrom = ConfigurationManager.AppSettings["CorreoNoReply"];

            MailMessage correo = new MailMessage();
            try
            {
                // hlnorislpucdyrux
                correo.From = new MailAddress(correofrom, "no-reply", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(Destinatatio); //Correo destino
                correo.Subject = Asunto; //Asunto
                correo.Body = Mensaje; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                //Cuerpo de correo
                string cuerpoCorreo;
                using (var stringReader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Plantillastxt", "correoValidacionCodigo.txt"), true))
                {
                    cuerpoCorreo = stringReader.ReadToEnd();
                }

                string _cuerpoCorreo = cuerpoCorreo.Replace("@Codigo", Codigo);


                var plainView = AlternateView.CreateAlternateViewFromString(Regex.Replace(_cuerpoCorreo, @"<(.|\n)*?>", string.Empty), null, "text/plain");

                var htmlView = AlternateView.CreateAlternateViewFromString(_cuerpoCorreo, null, "text/html");


                correo.AlternateViews.Add(plainView);
                correo.AlternateViews.Add(htmlView);


                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                smtp.Port = 587; //Puerto de salida

                smtp.Credentials = new System.Net.NetworkCredential(correode, pass);
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl

                smtp.Send(correo);

                return 0;
            }
            catch (Exception e)
            {
                CLErrores.EscribirError(e.Message, e.StackTrace);
                return -1;
            }

        }

        public static int EnviarCorreoCambioContrasenna(string Destinatatio, string Asunto, string Mensaje)
        {

            //Correo de envio.
            var correode = ConfigurationManager.AppSettings["CorreoSignus"];
            var pass = ConfigurationManager.AppSettings["PassSignus"];

            string correofrom = ConfigurationManager.AppSettings["CorreoNoReply"];

            MailMessage correo = new MailMessage();
            try
            {
                // hlnorislpucdyrux
                correo.From = new MailAddress(correofrom, "no-reply", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(Destinatatio); //Correo destino
                correo.Subject = Asunto; //Asunto
                correo.Body = Mensaje; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

            //Cuerpo de correo
            
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantillastxt/link cambio de contraseña.txt");
            string cuerpoCorreo;
            using (var stringReader = new StreamReader(rutaArchivo))
            {
                cuerpoCorreo = stringReader.ReadToEnd();
            }

            string _cuerpoCorreo = cuerpoCorreo.Replace("@Link", Mensaje);


                var plainView = AlternateView.CreateAlternateViewFromString(Regex.Replace(_cuerpoCorreo, @"<(.|\n)*?>", string.Empty), null, "text/plain");

                var htmlView = AlternateView.CreateAlternateViewFromString(_cuerpoCorreo, null, "text/html");


                correo.AlternateViews.Add(plainView);
                correo.AlternateViews.Add(htmlView);


                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                smtp.Port = 587; //Puerto de salida

                smtp.Credentials = new System.Net.NetworkCredential(correode, pass);//Cuenta de correo "Diverscan2022."
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl

                smtp.Send(correo);

                return 0;
            }
            catch (Exception e)
            {
                CLErrores.EscribirError(e.Message, e.StackTrace);
                return -1;
            }

        }
        ////Mensaje que se envia al correo de signus con la informacion suministrada
        ////por el cliente al adquirir un plan
        ////public static int EnviarCorreoResumendelacompra(string planorden, string precioorden, string cantiActivosAdi, string precioadiocionales, string total, string correoUsuario, string idPerfilActive, string idEmpresa)
        //{
        //    //Correo de envio.
        //    //var correode = ConfigurationManager.AppSettings["CorreoSignus"];
        //    //var pass = ConfigurationManager.AppSettings["PassSignus"];


        //    //string correofrom = ConfigurationManager.AppSettings["CorreoNoReply"];


        //    //Mensajes con la informacion brindada.

        //    MailMessage correo = new MailMessage();
        //    try
        //    {

        //        //Cuerpo de correo
        //        string cuerpoCorreo;
        //        using (var stringReader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantillastxt", "PlantillaResumenCompra..txt"), true))
        //        {
        //            cuerpoCorreo = stringReader.ReadToEnd();
        //        }

        //        cuerpoCorreo = cuerpoCorreo.Replace("@PlanOrden", planorden);
        //        cuerpoCorreo = cuerpoCorreo.Replace("@PrecioOrden", precioorden);
        //        cuerpoCorreo = cuerpoCorreo.Replace("@CantiActivosAdi", cantiActivosAdi);
        //        cuerpoCorreo = cuerpoCorreo.Replace("@PrecioAdi", precioadiocionales);
        //        cuerpoCorreo = cuerpoCorreo.Replace("@NTotal", total);
        //        cuerpoCorreo = cuerpoCorreo.Replace("@IdEmpre", idEmpresa);
        //        cuerpoCorreo = cuerpoCorreo.Replace("@IdEmpresa", idPerfilActive);
        //        cuerpoCorreo = cuerpoCorreo.Replace("@Correo", correoUsuario);


        //        // hlnorislpucdyrux
        //        correo.From = new MailAddress(correofrom, "Resumen Compra", System.Text.Encoding.UTF8);//Correo de salida
        //        correo.To.Add(correofrom); //Correo destino
        //        correo.Subject = "Contacto Signus ID"; //Asunto
        //        correo.Body = cuerpoCorreo; //Mensaje del correo
        //        correo.IsBodyHtml = true;
        //        correo.Priority = MailPriority.Normal;


        //        SmtpClient smtp = new SmtpClient();
        //        smtp.UseDefaultCredentials = false;
        //        smtp.Host = ConfigurationManager.AppSettings["ServerSmtp"]; //Host del servidor de correo
        //        smtp.Port = Convert.ToInt32(ConfigurationManager.AppSettings["PortSmtp"]); //Puerto de salida

        //        smtp.Credentials = new System.Net.NetworkCredential(correode, pass);//Cuenta de correo "Diverscan2022."
        //        ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
        //        smtp.EnableSsl = true;//True si el servidor de correo permite ssl

        //        smtp.Send(correo);

        //        return 0;
        //    }
        //    catch (Exception e)
        //    {
        //        CLErrores.EscribirError(e.Message, e.StackTrace);
        //        return -1;
        //    }

        //}

    }

        }