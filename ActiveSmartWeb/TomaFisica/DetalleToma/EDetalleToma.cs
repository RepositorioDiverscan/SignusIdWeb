using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.TomaFisica.DetalleToma
{
    public class EDetalleToma
    {
        private int idActivo;
        private string numeroActivo;
        private string placaActivo;
        private string observacionActivo;
        private string descripcionActivo;
        private int estado;
        public EDetalleToma() { }
        public EDetalleToma(int idActivo, string numeroActivo, string placaActivo, string observacionActivo, string descripcionActivo,int estado)
        {
            this.idActivo = idActivo;
            this.numeroActivo = numeroActivo;
            this.placaActivo = placaActivo;
            this.observacionActivo = observacionActivo;
            this.descripcionActivo = descripcionActivo;
            this.Estado = estado;
        }
        public int IdActivo { get => idActivo; set => idActivo = value; }
        public string PlacaActivo { get => placaActivo; set => placaActivo = value; }
      
        public string ObservacionActivo { get => observacionActivo; set => observacionActivo = value; }
        public string DescripcionActivo { get => descripcionActivo; set => descripcionActivo = value; }
        public string NumeroActivo { get => numeroActivo; set => numeroActivo = value; }
        public int Estado { get =>estado; set => estado = value; }
    }
}