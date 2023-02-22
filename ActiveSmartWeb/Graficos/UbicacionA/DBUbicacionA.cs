using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Graficos.UbicacionA
{
    public class DBUbicacionA
    {

        public List<EUbicacionA> ConsultarActivosUbicacionA()
        {
            List<EUbicacionA> eUbicacionAs = new List<EUbicacionA>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("CantidadActivosUbicacionA");
           
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EUbicacionA eUbicacion = new EUbicacionA();
                    int id_ubicacion = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    int cantidad = Convert.ToInt32(reader["CANTIDAD"].ToString());
                    string nombre = reader["Nombre"].ToString();
                    eUbicacion = new EUbicacionA(id_ubicacion,cantidad, nombre);
                    eUbicacionAs.Add(eUbicacion);
                }
            }
            return eUbicacionAs;
        }
        public List<EUbicacionA> ConsultarActivosUbicacionB(int id)
        {
            List<EUbicacionA> eUbicacionAs = new List<EUbicacionA>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("CantidadActivosUbicacionB");
            db.AddInParameter(dbCommand, "@UbicacionA", DbType.String, id);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EUbicacionA eUbicacion = new EUbicacionA();
                    int id_UbicacionB = Convert.ToInt32(reader["IdUbicacionB"].ToString());
                    int cantidad = Convert.ToInt32(reader["CANTIDAD"].ToString());
                    string nombre = reader["Nombre"].ToString();
                    eUbicacion = new EUbicacionA(id_UbicacionB,cantidad, nombre);
                    eUbicacionAs.Add(eUbicacion);
                }
            }
            return eUbicacionAs;
        }

        public List<EUbicacionA> ConsultarActivosUbicacionC(int id)
        {
            List<EUbicacionA> eUbicacionAs = new List<EUbicacionA>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("CantidadActivosUbicacionC");
            db.AddInParameter(dbCommand, "@UbicacionB", DbType.String, id);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EUbicacionA eUbicacion = new EUbicacionA();
                    int id_UbicacionB = Convert.ToInt32(reader["IdUbicacionC"].ToString());
                    int cantidad = Convert.ToInt32(reader["CANTIDAD"].ToString());
                    string nombre = reader["Nombre"].ToString();
                    eUbicacion = new EUbicacionA(id_UbicacionB, cantidad, nombre);
                    eUbicacionAs.Add(eUbicacion);
                }
            }
            return eUbicacionAs;
        }


        public List<EUbicacionA> ConsultarActivosUbicacionD(int id)
        {
            List<EUbicacionA> eUbicacionAs = new List<EUbicacionA>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var dbCommand = db.GetStoredProcCommand("CantidadActivosUbicacionD");
            db.AddInParameter(dbCommand, "@UbicacionC", DbType.String, id);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EUbicacionA eUbicacion = new EUbicacionA();
                    int id_UbicacionB = Convert.ToInt32(reader["IdUbicacionD"].ToString());
                    int cantidad = Convert.ToInt32(reader["CANTIDAD"].ToString());
                    string nombre = reader["Nombre"].ToString();
                    eUbicacion = new EUbicacionA(id_UbicacionB, cantidad, nombre);
                    eUbicacionAs.Add(eUbicacion);
                }
            }
            return eUbicacionAs;
        }


    }
}