using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Tienda.Idioma
{
    public class IdiomaTiendaGeneral
    {
        private string titulo;
        private string resumenDeOrden;
        private string cantidadActivos;
        private string adicionales;
        private string ubicacionesA;
        private string personalAsigActivos;
        private string usuariosGestores;
        private string totalPagar;
        private string pagar;

        public IdiomaTiendaGeneral()
        {
        }

        public IdiomaTiendaGeneral(string titulo, string resumenDeOrden, string cantidadActivos, string adicionales, string ubicacionesA, string personalAsigActivos, string usuariosGestores, string totalPagar, string pagar)
        {
            Titulo = titulo;
            ResumenDeOrden = resumenDeOrden;
            CantidadActivos = cantidadActivos;
            Adicionales = adicionales;
            UbicacionesA = ubicacionesA;
            PersonalAsigActivos = personalAsigActivos;
            UsuariosGestores = usuariosGestores;
            TotalPagar = totalPagar;
            Pagar = pagar;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string ResumenDeOrden { get => resumenDeOrden; set => resumenDeOrden = value; }
        public string CantidadActivos { get => cantidadActivos; set => cantidadActivos = value; }
        public string Adicionales { get => adicionales; set => adicionales = value; }
        public string UbicacionesA { get => ubicacionesA; set => ubicacionesA = value; }
        public string PersonalAsigActivos { get => personalAsigActivos; set => personalAsigActivos = value; }
        public string UsuariosGestores { get => usuariosGestores; set => usuariosGestores = value; }
        public string TotalPagar { get => totalPagar; set => totalPagar = value; }
        public string Pagar { get => pagar; set => pagar = value; }
    }
}