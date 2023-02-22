using ActiveSmartWeb.Ubicaciones.UbicacionA;
using ActiveSmartWeb.UbicacionesB.UbicacionB;
using ActiveSmartWeb.UbicacionesC.UbicacionC;
using ActiveSmartWeb.UbicacionesD.UbicacionD;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.UbicacionesD.UbicacionD
{
    public class DUbicacionD
    {
        // Este metodo se encarga de ejecutar el sp que realizara la actualizacion de un registro , recibiendo los parametros necesarios 
        public string InsertarUbicacion(string nombre, string descripcion, int idPerfilEmpresa, int IdUbicacionC)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("InsertarUbicacionD");
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, nombre);
            db.AddInParameter(dbCommand, "@Descripcion", DbType.String, descripcion);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            db.AddInParameter(dbCommand, "@IdUbicacionC", DbType.Int32, IdUbicacionC);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        // Este metodo se encarga de cargar una ubicacion por Id
        public List<Int32> ConsultarUbicacionesPorIdD(int IdUbicacionD)
        {
            List<Int32> lista = new List<Int32>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("SP_ConsultaUbicacionPorIdD");
            db.AddInParameter(dbCommand, "@IdUbicacionD", DbType.Int32, IdUbicacionD);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    lista.Add(Convert.ToInt32(reader["IdUbicacionA"].ToString()));
                    lista.Add(Convert.ToInt32(reader["IdUbicacionB"].ToString()));
                    lista.Add(Convert.ToInt32(reader["IdUbicacionC"].ToString()));
                    lista.Add(Convert.ToInt32(reader["IdUbicacionD"].ToString()));
                }
            }
            return lista;
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

        // Este metodo se encarga de cargar las ubicaciones C por Empresa
        public List<EUbicacionC> ConsultarUbicacionesC(int idPerfilEmpresa, int IdUbicacionB)
        {
            List<EUbicacionC> eUbicacionBs = new List<EUbicacionC>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("ConsultaUbicacionesCubicacionD");

            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.String, idPerfilEmpresa);
            db.AddInParameter(dbCommand, "@IdUbicacionB", DbType.String, @IdUbicacionB);
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

        // Este metodo se encarga de cargar las ubicaciones D por Empresa
        public List<EUbicacionD> ConsultarUbicacionesD(int idPerfilEmpresa)
        {
            List<EUbicacionD> eUbicacionBs = new List<EUbicacionD>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("ConsultaUbicacionesD");

            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.String, idPerfilEmpresa);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EUbicacionD eUbicacion;
                    int idUbicacionD = Convert.ToInt32(reader["IdUbicacionD"].ToString());
                    int idUbicacionC = Convert.ToInt32(reader["IdUbicacionC"].ToString());
                    string nombre = reader["Nombre"].ToString();
                    string descripcion = reader["Descripcion"].ToString();

                    eUbicacion = new EUbicacionD();
                    eUbicacion.IdUbicacionD = idUbicacionD;
                    eUbicacion.IdUbicacionC = idUbicacionC;
                    eUbicacion.Descripcion = descripcion;
                    eUbicacion.Nombre = nombre;

                    eUbicacionBs.Add(eUbicacion);
                }
            }
            return eUbicacionBs;
        }

        // Este metodo se encarga de cargar las ubicaciones C por Id
        public int ConsultaUbicacionxIdUbicacionC(int IdUbicacionC)
        {
            int idUbiD = 0;
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("ConsultaUbicacionxIdUbicacionC");
            db.AddInParameter(dbCommand, "@IdUbicacionC", DbType.Int32, IdUbicacionC);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    idUbiD = Convert.ToInt32(reader["IdUbicacionB"].ToString());
                }
            }
            return idUbiD;
        }


        public int ConsultarUbicacionesByC(int idUbicacionC, int idUbicacionB)
        {
            int idUbiD = 0;
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("ConsultarUbicacionesByC");
            db.AddInParameter(dbCommand, "@IdUbicacionC", DbType.Int32, idUbicacionC);
            db.AddInParameter(dbCommand, "@IdUbicacionB", DbType.Int32, idUbicacionB);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    idUbiD = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                }
            }
            return idUbiD;
        }

        // Este metodo se encarga de ejecutar el sp que realizara la actualizacion de un registro , recibiendo los parametros necesarios 
        public string ActualizaUbicacion(int idUbicacionD, int idUbicacionC, string nombre, string descripcion)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("ActualizaUbicacionD");
            db.AddInParameter(dbCommand, "@idUbicacionD", DbType.Int32, idUbicacionD);
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