using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.EstadoActivoFijo.EstadoActivo
{
    public interface IEstadoActivo
    {
        List<EEstadoActivo> ConsultarEstado();
        string ConsultarDescEstadoX(int Id);
    }
}