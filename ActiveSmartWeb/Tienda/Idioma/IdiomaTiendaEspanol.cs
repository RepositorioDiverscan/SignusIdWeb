using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Tienda.Idioma
{
    public class IdiomaTiendaEspanol
    {
        private const string titulo = "Tienda";
        private const string resumenDeOrden = "RESUMEN DE LA ORDEN";
        private const string adicionales = "ADICIONALES";
        private const string cantidadActivos = "Cantidad de Activos";
        private const string ubicacionesA = "Ubicaciones de 1 Nivel (A)";
        private const string personalAsigActivos = "Personal para asignar activos";
        private const string usuariosGestores = "Usuarios gestores del sistema";
        private const string totalPagar ="TOTAL A PAGAR:";
        private const string pagar = "Pagar";
        private const string precio = "Precio";

        public static string Titulo => titulo;

        public static string ResumenDeOrden => resumenDeOrden;

        public static string Adicionales => adicionales;

        public static string CantidadActivos => cantidadActivos;

        public static string UbicacionesA => ubicacionesA;

        public static string PersonalAsigActivos => personalAsigActivos;

        public static string UsuariosGestores => usuariosGestores;

        public static string TotalPagar => totalPagar;

        public static string Pagar => pagar;

        public static string Precio => precio;
    }
}