using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.PerfilEmpresa.Entidades
{
    public class EPerfilEmpresa
    {
        private int idPerfilEmpresa;
        private string idEmpresa;
        private string nombre;
        private string contactoPrincipal;
        private string correo;
        private string pais;
        private string direccion;
        private string telefono;
        private string industria;
        private string imagen;
        private string moneda;
        public EPerfilEmpresa()
        {
        }

        public EPerfilEmpresa(int idPerfilEmpresa, string nombre, string contactoPrincipal, string correo, string pais, string direccion, string telefono, string industria, string idEmpresa, string imagen, string moneda)
        {
            this.idPerfilEmpresa = idPerfilEmpresa;
            this.nombre = nombre;
            this.contactoPrincipal = contactoPrincipal;
            this.correo = correo;
            this.pais = pais;
            this.direccion = direccion;
            this.telefono = telefono;
            this.industria = industria;
            this.idEmpresa = idEmpresa;
            this.imagen = imagen;
            this.moneda = moneda;
        }

        public int IdPerfilEmpresa { get => idPerfilEmpresa; set => idPerfilEmpresa = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ContactoPrincipal { get => contactoPrincipal; set => contactoPrincipal = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Industria { get => industria; set => industria = value; }
        public string IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Moneda { get => moneda; set => moneda = value; }
    }
}