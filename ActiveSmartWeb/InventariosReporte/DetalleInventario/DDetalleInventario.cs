using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.InventariosReporte.DetalleInventario
{
    public class DDetalleInventario : IDetalleInventarios
    {
        public List<EDetalleInventario> ConsultaActivoporID(int IdTomaFisica)
        {
            List<EDetalleInventario> EDetalleInventario = new List<EDetalleInventario>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerActivoDetalleToma");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EDetalleInventario edetalle = new EDetalleInventario();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string observacionActivo = reader["Observacion"].ToString();
                    string descripcionActivo = reader["DescripcionActivo"].ToString();
                    int estado = Convert.ToInt32(reader["Encontrado"].ToString());
                    edetalle = new EDetalleInventario(idActivo, numeroActivo, placaActivo, observacionActivo, descripcionActivo, estado);
                    EDetalleInventario.Add(edetalle);
                }
            }
            return EDetalleInventario;
        }

        public List<EDetalleInventario> ObtenerActivosTomaFisica(int IdTomaFisica, int IdAccion)
        {
            List<EDetalleInventario> EDetalleInventario = new List<EDetalleInventario>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerActivosTomaFisica");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            Db.AddInParameter(DbCommand, "@IdAccion", DbType.Int32, IdAccion);
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EDetalleInventario edetalle = new EDetalleInventario();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string observacionActivo = reader["Observacion"].ToString();
                    string descripcionActivo = reader["DescripcionActivo"].ToString();
                    int estado = Convert.ToInt32(reader["Encontrado"].ToString());
                    edetalle = new EDetalleInventario(idActivo, numeroActivo, placaActivo, observacionActivo, descripcionActivo, estado);
                    EDetalleInventario.Add(edetalle);
                }
            }
            return EDetalleInventario;
        }

        //Obtiene todos los activos en la toma fisica
        public List<EDetalleInventario> ObtenerActivosTodosToma(int IdTomaFisica, int IdCategoria, int IdUbicacion)
        {
            List<EDetalleInventario> EDetalleInventario = new List<EDetalleInventario>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerActivosTodosToma");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            Db.AddInParameter(DbCommand, "@IdCategoria", DbType.Int32, IdCategoria);
            Db.AddInParameter(DbCommand, "@IdUbicacion", DbType.Int32, IdUbicacion);
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EDetalleInventario edetalle = new EDetalleInventario();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string observacionActivo = reader["Observacion"].ToString();
                    string descripcionActivo = reader["DescripcionActivo"].ToString();
                    int estado = Convert.ToInt32(reader["Encontrado"].ToString());
                    edetalle = new EDetalleInventario(idActivo, numeroActivo, placaActivo, observacionActivo, descripcionActivo, estado);
                    EDetalleInventario.Add(edetalle);
                }
            }
            return EDetalleInventario;
        }

        //Obtiene todos los activos no encontrados en la toma fisica
        public List<EDetalleInventario> ObtenerActivosNoEncontradosToma(int IdTomaFisica)
        {
            List<EDetalleInventario> EDetalleInventario = new List<EDetalleInventario>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerActivosNoEncontradosToma");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EDetalleInventario edetalle = new EDetalleInventario();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string observacionActivo = reader["Observacion"].ToString();
                    string descripcionActivo = reader["DescripcionActivo"].ToString();
                    int estado = Convert.ToInt32(reader["Encontrado"].ToString());
                    edetalle = new EDetalleInventario(idActivo, numeroActivo, placaActivo, observacionActivo, descripcionActivo, estado);
                    EDetalleInventario.Add(edetalle);
                }
            }
            return EDetalleInventario;
        }

        //Obtiene todos los activos encontrados en la toma fisica
        public List<EDetalleInventario> ObtenerActivosEncontradosToma(int IdTomaFisica)
        {
            List<EDetalleInventario> EDetalleInventario = new List<EDetalleInventario>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerActivosEncontradosToma");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EDetalleInventario edetalle = new EDetalleInventario();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string observacionActivo = reader["Observacion"].ToString();
                    string descripcionActivo = reader["DescripcionActivo"].ToString();
                    int estado = Convert.ToInt32(reader["Encontrado"].ToString());
                    edetalle = new EDetalleInventario(idActivo, numeroActivo, placaActivo, observacionActivo, descripcionActivo, estado);
                    EDetalleInventario.Add(edetalle);
                }
            }
            return EDetalleInventario;
        }

        public string ActualizarDetalleToma(int IdTomaFisica, int IdActivo, int IdPerfilActive)
        {
            List<EDetalleInventario> EDetalleInventario = new List<EDetalleInventario>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ActualizarDetalleTomaFisica");
            Db.AddInParameter(DbCommand, "@IdActivo", DbType.Int32, IdActivo);
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            Db.AddInParameter(DbCommand, "@IdPerfilActive", DbType.Int32, IdPerfilActive);
            Db.AddOutParameter(DbCommand, "@Respuesta", DbType.String, 200);
            DbCommand.CommandTimeout = 3600;
            Db.ExecuteNonQuery(DbCommand);
            var Respuesta = Db.GetParameterValue(DbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public string ActualizarObservacionToma(int IdTomaFisica, int IdActivo, int IdPerfilActive, string Observacion)
        {
            List<EDetalleInventario> EDetalleInventario = new List<EDetalleInventario>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ActualizarObservacionDetalle");
            Db.AddInParameter(DbCommand, "@IdActivo", DbType.Int32, IdActivo);
            Db.AddInParameter(DbCommand, "@Observacion", DbType.String, Observacion);
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            Db.AddInParameter(DbCommand, "@IdPerfilActive", DbType.Int32, IdPerfilActive);
            Db.AddOutParameter(DbCommand, "@Respuesta", DbType.String, 200);
            DbCommand.CommandTimeout = 3600;
            Db.ExecuteNonQuery(DbCommand);
            var Respuesta = Db.GetParameterValue(DbCommand, "@Respuesta").ToString();
            return Respuesta;
        }
    }
}