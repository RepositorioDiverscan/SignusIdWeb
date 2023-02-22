using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Paquetes.Entidades
{
    public class DPaquetes
    {

        //Metodo para hacer la inserción de un paquete
        public string InsertarPaquete(EPaquetes paquete)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InsertarPaquete");
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, paquete.Nombre);
            db.AddInParameter(dbCommand, "@Descripcion", DbType.String, paquete.Descripcion);
            db.AddInParameter(dbCommand, "@Cantidad", DbType.Int64, paquete.Cantidad);
            db.AddInParameter(dbCommand, "@Costo", DbType.Decimal, paquete.Costo);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        //Metodo para actualizar el estado de un paquete
        public string ActualizarPaquete(EPaquetes paquete)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizarPaquete");
            db.AddInParameter(dbCommand, "@IdPaqueteContratado", DbType.Int64, paquete.IdPaqueteContratado);
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, paquete.Nombre);
            db.AddInParameter(dbCommand, "@Descripcion", DbType.String, paquete.Descripcion);
            db.AddInParameter(dbCommand, "@Cantidad", DbType.Int64, paquete.Cantidad);
            db.AddInParameter(dbCommand, "@Costo", DbType.Decimal, paquete.Costo);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        //Metodo para consultar los paquetes
        public List<EPaquetes> ConsultarPaquetes()
        {
            List<EPaquetes> paquetes = new List<EPaquetes>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarPaquetes");
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EPaquetes paquete = new EPaquetes();
                    int idPaqueteContratado = Convert.ToInt32(reader["IdPaqueteContratado"].ToString());
                    string nombre = Convert.ToString(reader["Nombre"].ToString());
                    string descripcion = Convert.ToString(reader["Descripcion"].ToString());
                    int cantidad = Convert.ToInt32(reader["Cantidad"].ToString());
                    decimal costo = Convert.ToDecimal(reader["Costo"].ToString());

                    paquete = new EPaquetes(idPaqueteContratado, nombre, descripcion, cantidad, costo);
                    paquetes.Add(paquete);
                }
            }
            return paquetes;
        }
        //Metodo para consultar un paquete en especifico
        public List<EPaquetes> ConsultarPaqueteX(int idpaquete)
        {
            List<EPaquetes> paquetes = new List<EPaquetes>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarPaquetes");
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    
                    EPaquetes paquete = new EPaquetes();
                    int idPaqueteContratado = Convert.ToInt32(reader["IdPaqueteContratado"].ToString());
                    string nombre = Convert.ToString(reader["Nombre"].ToString());
                    string descripcion = Convert.ToString(reader["Descripcion"].ToString());
                    int cantidad = Convert.ToInt32(reader["Cantidad"].ToString());
                    decimal costo = Convert.ToDecimal(reader["Costo"].ToString());

                    paquete = new EPaquetes(idPaqueteContratado, nombre, descripcion, cantidad, costo);
                    if (idPaqueteContratado==idpaquete)
                    {
                        paquetes.Add(paquete);
                    }
                   
                }
            }
            return paquetes;
        }
    }
}