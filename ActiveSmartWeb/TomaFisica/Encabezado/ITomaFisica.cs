using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.TomaFisica.Encabezado
{
    public interface ITomaFisica
    {
        string InsertarTomaFisica(string nombre, string descripcion, DateTime fechaInicial, DateTime fechaFinal, int categoria,
            int idPerfilActive , int idUsuarioAsignado , int idUbicacionA );
        string ActualizarTomaFisica(int idTomaFisica, string nombre, string descripcion, DateTime fechaInicial,
            DateTime fechaFinal, int categoria, int usuario, int ubicacion);
        List<ETomaFisica> ConsultarTomaFisica(int idPerfilActive, DateTime fechaInicial, DateTime fechaFinal);
        List<ETomaFisica> ConsultaIDTomaFisica(int IdTomaFisica);
        List<ETomaFisica> ConsultarTodosTomaFisica(int idPerfilActive);

        List<ETomaFisica> ConsultaIDEditarTomaFisica(int IdTomaFisica);


    }
}