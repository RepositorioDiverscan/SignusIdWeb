using ActiveSmartWeb.Ubicaciones.UbicacionA;
using ActiveSmartWeb.UbicacionesB.UbicacionB;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.UbicacionesC.UbicacionC
{
    public class DUbicacionC
    {
        // Este metodo se encarga de ejecutar el sp que realizara la actualizacion de un registro , recibiendo los parametros necesarios 
        public string InsertarUbicacion(string nombre, string descripcion, int idPerfilEmpresa, int IdUbicacionB)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("InsertarUbicacionC");
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, nombre);
            db.AddInParameter(dbCommand, "@Descripcion", DbType.String, descripcion);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            db.AddInParameter(dbCommand, "@IdUbicacionB", DbType.Int32, IdUbicacionB);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        // Este metodo se encarga de cargar las ubicaciones A por Empresa
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

        // Este metodo se encarga de cargar las ubicaciones B por Empresa
        public List<EUbicacionB> ConsultarUbicacionesB(int idPerfilEmpresa, int idUbicacionA)
        {
            List<EUbicacionB> eUbicacionBs = new List<EUbicacionB>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("ConsultaUbicacionesB");

            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.String, idPerfilEmpresa);
            db.AddInParameter(dbCommand, "@IdUbicacionA", DbType.String, idUbicacionA);

            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EUbicacionB eUbicacion;
                    int idUbicacionB = Convert.ToInt32(reader["IdUbicacionB"].ToString());
                    idUbicacionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombre = reader["Nombre"].ToString();
                    string descripcion = reader["Descripcion"].ToString();
                    eUbicacion = new EUbicacionB(idUbicacionB, idUbicacionA, nombre, descripcion);
                    eUbicacionBs.Add(eUbicacion);
                }
            }
            return eUbicacionBs;
        }

        // consulta todas las Ubicacion C ligado al Id de la empresa
        public List<EUbicacionC> ConsultarUbicacionesC(int idPerfilEmpresa)
        {
            List<EUbicacionC> eUbicacionBs = new List<EUbicacionC>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("ConsultaUbicacionesC");

            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.String, idPerfilEmpresa);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EUbicacionC eUbicacion;
                    int idUbicacionC = Convert.ToInt32(reader["IdUbicacionC"].ToString());
                    int idUbicacionB = Convert.ToInt32(reader["IdUbicacionB"].ToString());
                    string nombre = reader["Nombre"].ToString();
                    string descripcion = reader["Descripcion"].ToString();
                    eUbicacion = new EUbicacionC(idUbicacionC, idUbicacionB, nombre, descripcion);
                    eUbicacionBs.Add(eUbicacion);
                }
            }
            return eUbicacionBs;
        }


        public int ConsultarUbicacionesXId(int IdUbicacionB)
        {
            int idUbiA = 0;
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("ConsultaUbicacionxId");
            db.AddInParameter(dbCommand, "@IdUbicacionB", DbType.Int32, IdUbicacionB);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    idUbiA = Convert.ToInt32(reader["IdUbicacionA"].ToString());

                }
            }
            return idUbiA;
        }

        // Este metodo se encarga de ejecutar el sp que realizara la actualizacion de un registro , recibiendo los parametros necesarios 
        public string ActualizaUbicacion(int idUbicacionC, int idUbicacionB, string nombre, string descripcion)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("ActualizaUbicacionC");
            db.AddInParameter(dbCommand, "@idUbicacionB", DbType.Int32, idUbicacionB);
            db.AddInParameter(dbCommand, "@idUbicacionC", DbType.Int32, idUbicacionC);
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