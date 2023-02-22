using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatSmart.Chat.Entidades
{
    public class NChat
    {
        DChat dChat = new DChat();


        public List<EMensaje> ConsultarChat(int idNotificacion)
        {
            List<EMensaje> listaMensajes = new List<EMensaje>();

            try
            {
                return listaMensajes = dChat.ConsultarChat(idNotificacion);

            }catch(Exception ex)
            {
                return new List<EMensaje>();
            }
        }

        public string InsertarMensaje(int idNotificacion, EMensaje mensaje)
        {
            var Respuesta = "";

            try
            {
                return Respuesta = dChat.InsertarMensaje(idNotificacion, mensaje);
            }catch(Exception ex)
            {
                return "";
            }
        }

        public string CerrarChat(int idChat)
        {
            var Respuesta = "";

            try
            {
                return Respuesta = dChat.CerrarChat(idChat);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public int ConsultarNumeroTicket(int idNotificacion)
        {
            try
            {
                var result = dChat.ConsultarNumeroTicket(idNotificacion);
                return result;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return 0;
            }
        }

    }
}