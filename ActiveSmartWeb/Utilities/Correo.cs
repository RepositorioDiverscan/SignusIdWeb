using System;
using System.Collections.Generic;
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

            MailMessage correo = new MailMessage();
            try
            {
                // hlnorislpucdyrux
                correo.From = new MailAddress("pruebas.activeidsmart@gmail.com", "Sistema Active ID SMART", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(Destinatatio); //Correo destino
                correo.Subject = Asunto; //Asunto
                correo.Body = Mensaje; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                smtp.Port = 587; //Puerto de salida

                smtp.Credentials = new System.Net.NetworkCredential("pruebas.activeidsmart@gmail.com", "hlnorislpucdyrux");//Cuenta de correo "Diverscan2022."
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

            MailMessage correo = new MailMessage();
            try
            {
                // hlnorislpucdyrux
                correo.From = new MailAddress("pruebas.activeidsmart@gmail.com", "Sistema Active ID SMART", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(Destinatatio); //Correo destino
                correo.Subject = Asunto; //Asunto
                correo.Body = Mensaje; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                //Cuerpo de correo
                string cuerpoCorreo;
                using (var stringReader = new StreamReader("C:/Correos Signus/contraseña signus id 2.txt", true))
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

                smtp.Credentials = new System.Net.NetworkCredential("pruebas.activeidsmart@gmail.com", "hlnorislpucdyrux");//Cuenta de correo "Diverscan2022."
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

            MailMessage correo = new MailMessage();
            try
            {
                // hlnorislpucdyrux
                correo.From = new MailAddress("pruebas.activeidsmart@gmail.com", "Sistema Active ID SMART", System.Text.Encoding.UTF8);//Correo de salida
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

                smtp.Credentials = new System.Net.NetworkCredential("pruebas.activeidsmart@gmail.com", "hlnorislpucdyrux");//Cuenta de correo "Diverscan2022."
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

            MailMessage correo = new MailMessage();
            try
            {
                // hlnorislpucdyrux
                correo.From = new MailAddress("pruebas.activeidsmart@gmail.com", "Sistema Active ID SMART", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(Destinatatio); //Correo destino
                correo.Subject = Asunto; //Asunto
                correo.Body = Mensaje; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                //Cuerpo de correo
                string cuerpoCorreo;
                using (var stringReader = new StreamReader("C:/Correos Signus/link cambio de contraseña.txt", true))
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

                smtp.Credentials = new System.Net.NetworkCredential("pruebas.activeidsmart@gmail.com", "hlnorislpucdyrux");//Cuenta de correo "Diverscan2022."
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

    }
}