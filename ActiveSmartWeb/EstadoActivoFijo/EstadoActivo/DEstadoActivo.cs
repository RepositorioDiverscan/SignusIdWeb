using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.EstadoActivoFijo.EstadoActivo
{
    public class DEstadoActivo : IEstadoActivo
    {
       public List<EEstadoActivo> ConsultarEstado ()
        {
            List<EEstadoActivo> eEstadoActivo = new List<EEstadoActivo>();

            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaEstadoActivo");
            DbCommand.CommandTimeout = 3600;
           

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EEstadoActivo eEstado = new EEstadoActivo();
                    int idEstado = Convert.ToInt32(reader["IdEstadoActivo"].ToString());
                    string nombre = reader["NombreEstado"].ToString();
                    string descripcion = reader["DescripcionEstado"].ToString();
                    eEstado = new EEstadoActivo(idEstado, nombre, descripcion);
                    eEstadoActivo.Add(eEstado);
                }
            }
            return eEstadoActivo;
       }
        public string ConsultarDescEstadoX(int Id)
        {
            List<EEstadoActivo> eEstadoActivo = new List<EEstadoActivo>();

            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaEstadoActivo");
            DbCommand.CommandTimeout = 3600;

            string descripcion=" ";
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    int idEstado = Convert.ToInt32(reader["IdEstadoActivo"].ToString());
                    if (idEstado==Id)
                    {
                      descripcion = reader["DescripcionEstado"].ToString();
                    }
                  
                }
            }
            return descripcion;
        }
    }
}