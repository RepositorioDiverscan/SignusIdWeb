using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Ubicaciones.UbicacionA
{
    public class DUbicacion : IUbicacionA
    {

        public string InsertarUbicacion(string nombre, string descripcion, int idPerfilEmpresa)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InsertarUbicacionA");
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, nombre);
            db.AddInParameter(dbCommand, "@Descripcion", DbType.String, descripcion);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public List<EUbicacionA> ConsultarUbicaciones(int idPerfilEmpresa)
        {
            List<EUbicacionA> eUbicacionAs = new List<EUbicacionA>();
             var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultaUbicacionesA");
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.String, idPerfilEmpresa);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EUbicacionA eUbicacion = new EUbicacionA();
                    int idUbicacionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombre = reader["Nombre"].ToString();
                    string descripcion = reader["Descripcion"].ToString();
                    eUbicacion = new EUbicacionA(idUbicacionA, nombre, descripcion);
                    eUbicacionAs.Add(eUbicacion);
                }
            }
            return eUbicacionAs;
        }

        public string ActualizaUbicacion(int idUbicacionA, string nombre, string descripcion)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizaUbicacionA");
            db.AddInParameter(dbCommand, "@IdUbicacionA", DbType.Int32, idUbicacionA);
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, nombre);
            db.AddInParameter(dbCommand, "@Descripcion", DbType.String, descripcion);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }
    }
}