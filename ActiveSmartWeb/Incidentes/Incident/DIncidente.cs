using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Incidentes.Incident
{
    public class DIncidente
    {

        public string InsertarIncidente(EIncidente incidente)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InsertarIncidente");
            db.AddInParameter(dbCommand, "@IdTipoIncidente", DbType.Int32, incidente.IdTipoIncidente);
            db.AddInParameter(dbCommand, "@IdPerfilActive", DbType.Int32, incidente.IdPerfilActive);
            db.AddInParameter(dbCommand, "@Mensaje", DbType.String, incidente.Mensaje);
            db.AddInParameter(dbCommand, "@Telefono", DbType.String, incidente.Telefono);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public List<ETipoIncidente> ConsultarTiposIncidentes()
        {
            List<ETipoIncidente> listaTipoIncidentes = new List<ETipoIncidente>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarTiposIncidente");
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    ETipoIncidente tipoIncidente = new ETipoIncidente();
                    tipoIncidente.IdTipoIncidente = Convert.ToInt32(reader["idTipoIncidente"].ToString());
                    tipoIncidente.Nombre = reader["Nombre"].ToString();
                    tipoIncidente.Descripcion = reader["Descripcion"].ToString();
                    listaTipoIncidentes.Add(tipoIncidente);
                }
            }
            return listaTipoIncidentes;

        }


    }
}