using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.SincronizarActivos.SincronizarAct
{
    public interface ISincronizaActivos
    {
        string InsertarActivoSincronizacion(string numeroActivo, string placaActivo, string idEstadoActivo, string idCategoriaActivo,
                                         string idUbicaionA, int idPerfilEmpresa, string marca, string modelo,
                                         string descripcionCorta, decimal costoActivo, int idArchivo);
        string InsertarArchivo(int idPerfilEmpresa, int estado, string nombrearhivo);
         List<ESincronizaActivos> ConsultaArchivo(int idPerfilEmpresa);
        string InsertarActivoFijo(int IdArchivo, int idPerfilEmpresa);

        string BorrarArchivo(int IdArchivo);
       List<ESincronizaActivos> ConsultaActivos();
        string ActualizaArchivoEstado(int idArchivo, string estadoSicroniza);


    }
}