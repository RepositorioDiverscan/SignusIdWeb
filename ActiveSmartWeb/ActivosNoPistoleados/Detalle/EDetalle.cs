using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ActivosNoPistoleados.Detalle
{
    public class EDetalle
    {

        private int idActivo;
        private string numeroActivo;
        private string placaActivo;
        private string observacionActivo;
        private string descripcionActivo;

        public EDetalle()
        {
        }

        public EDetalle(int idActivo, string numeroActivo, string placaActivo, string observacionActivo, string descripcionActivo)
        {
            this.idActivo = idActivo;
            this.numeroActivo = numeroActivo;
            this.placaActivo = placaActivo;
            this.observacionActivo = observacionActivo;
            this.descripcionActivo = descripcionActivo;
        }

        public int IdActivo { get => idActivo; set => idActivo = value; }
        public string NumeroActivo { get => numeroActivo; set => numeroActivo = value; }
        public string PlacaActivo { get => placaActivo; set => placaActivo = value; }
        public string ObservacionActivo { get => observacionActivo; set => observacionActivo = value; }
        public string DescripcionActivo { get => descripcionActivo; set => descripcionActivo = value; }
    }
}