using ActiveSmartWeb.Ubicaciones.UbicacionA;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.UbicacionesB.UbicacionB
{
    public class DUbicacionB
    {
        // Este metodo se encarga de ejecutar el sp que realizara la actualizacion de un registro , recibiendo los parametros necesarios 
        public string ActualizaUbicacion(int idUbicacionB, int idUbicacionA, string nombre, string descripcion)
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("ActualizaUbicacionB");

            db.AddInParameter(dbCommand, "@Nombre", DbType.String, nombre);
            db.AddInParameter(dbCommand, "@Descripcion", DbType.String, descripcion);
            db.AddInParameter(dbCommand, "@IdUbicacionB", DbType.Int32, idUbicacionB);
            db.AddInParameter(dbCommand, "@IdUbicacionA", DbType.Int32, idUbicacionA);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }
        // consulta toda la Ubicacion A ligado al Id de la empresa
        public List<EUbicacionA> ConsultarUbicacionesA(int idPerfilEmpresa)
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
                    EUbicacionA eUbicacion;
                    int idUbicacionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombre = reader["Nombre"].ToString();
                    string descripcion = reader["Descripcion"].ToString();
                    eUbicacion = new EUbicacionA(idUbicacionA, nombre, descripcion);
                    eUbicacionAs.Add(eUbicacion);
                }
            }
            return eUbicacionAs;
        }

        // consulta todas la Ubicacion B ligado al Id de la empresa
        public List<EUbicacionB> ConsultarUbicacionesB(int idPerfilEmpresa) //cargarTablade la UbicacionB
        {
            List<EUbicacionB> eUbicacionBs = new List<EUbicacionB>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("ConsultaUbicacionesBUnicamente");

            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.String, idPerfilEmpresa);

            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EUbicacionB eUbicacion;
                    int idUbicacionB = Convert.ToInt32(reader["IdUbicacionB"].ToString());
                    int idUbicacionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombre = reader["Nombre"].ToString();
                    string descripcion = reader["Descripcion"].ToString();
                    eUbicacion = new EUbicacionB(idUbicacionB, idUbicacionA, nombre, descripcion);
                    eUbicacionBs.Add(eUbicacion);
                }
            }
            return eUbicacionBs;
        }

        // Este metodo se encarga de ejecutar el sp de Insertar Ubicacion B con los parametros necesarios para ejecutar el sp
        public string InsertarUbicacion(string nombre, string descripcion, int idPerfilEmpresa, int IdUbicacionA)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("InsertarUbicacionB");
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, nombre);
            db.AddInParameter(dbCommand, "@Descripcion", DbType.String, descripcion);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            db.AddInParameter(dbCommand, "@IdUbicacionA", DbType.Int32, IdUbicacionA);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }
    }
}