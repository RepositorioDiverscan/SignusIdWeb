using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatSmart.Chat.Entidades
{
    public class EMensaje
    {
        private int idMensaje;
        private int index;
        private string texto;
        private DateTime fechaEnvio;
        private int idChat;
        private int emisor;
        private int estado;

        public EMensaje()
        {
        }

        public EMensaje(int idMensaje, int index, string texto, DateTime fechaEnvio, int idChat, int emisor, int estado)
        {
            IdMensaje = idMensaje;
            Index = index;
            Texto = texto;
            FechaEnvio = fechaEnvio;
            IdChat = idChat;
            Emisor = emisor;
            Estado = estado;
        }

        public int IdMensaje { get => idMensaje; set => idMensaje = value; }
        public int Index { get => index; set => index = value; }
        public string Texto { get => texto; set => texto = value; }
        public DateTime FechaEnvio { get => fechaEnvio; set => fechaEnvio = value; }
        public int IdChat { get => idChat; set => idChat = value; }
        public int Emisor { get => emisor; set => emisor = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}