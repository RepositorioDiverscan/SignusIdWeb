using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatSmart.Chat.Entidades
{
    public class EChat
    {
        private int idChat;
        private int idIncidente;
        private int idUsuarioSoporte;
        private int estado;

        public EChat()
        {
        }

        public EChat(int idChat, int idIncidente, int idUsuarioSoporte, int estado)
        {
            IdChat = idChat;
            IdIncidente = idIncidente;
            IdUsuarioSoporte = idUsuarioSoporte;
            Estado = estado;
        }

        public int IdChat { get => idChat; set => idChat = value; }
        public int IdIncidente { get => idIncidente; set => idIncidente = value; }
        public int IdUsuarioSoporte { get => idUsuarioSoporte; set => idUsuarioSoporte = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}