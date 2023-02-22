using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Empleados.Entidades
{
    public class EEmpleados
    {

        private int idEmpleados;
        private string nombre;
        private string apellidos;
        private string identificacion;
        private string correo;
        private string puesto;
        private string telefono;
        private string estado;
        private int idPerfilEmpresa;

        public EEmpleados()
        {
        }

        public EEmpleados(int idEmpleados, string nombre, string apellidos, string identificacion, string correo, string puesto, string telefono, string estado, int idPerfilEmpresa)
        {
            this.IdEmpleados = idEmpleados;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Identificacion = identificacion;
            this.Correo = correo;
            this.Puesto = puesto;
            this.Telefono = telefono;
            this.Estado = estado;
            this.IdPerfilEmpresa = idPerfilEmpresa;
        }

        public int IdEmpleados { get => idEmpleados; set => idEmpleados = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdPerfilEmpresa { get => idPerfilEmpresa; set => idPerfilEmpresa = value; }
    }
}