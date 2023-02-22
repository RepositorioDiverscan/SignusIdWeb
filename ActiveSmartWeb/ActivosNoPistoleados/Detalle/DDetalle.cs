using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ActivosNoPistoleados.Detalle
{
    public class DDetalle
    {
        //trae activos por el IdTomaFisica 
        public List<EDetalle> ConsultaActivosNoPistoleados(int IdTomaFisica)
        {
            List<EDetalle> EDetalleInventario = new List<EDetalle>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaActivosPorCategoriaTomaWEB");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EDetalle edetalle = new EDetalle();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string descripcionActivo = reader["DescripcionActivo"].ToString();
                    string observacionActivo = reader["Observacion"].ToString();
                    edetalle = new EDetalle(idActivo, numeroActivo, placaActivo, observacionActivo, descripcionActivo);
                    EDetalleInventario.Add(edetalle);
                }
            }
            return EDetalleInventario;
        }

        //actualiza la observation


        public string ActualizarObservacion(int IdTomaFisicaA , int IdPerfilActiveA , int IdActivo, string Observacion)
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizarObservacionDetalle");
            db.AddInParameter(dbCommand, "@IdTomaFisica", DbType.String, IdTomaFisicaA);
            db.AddInParameter(dbCommand, "@IdPerfilActive", DbType.String, IdPerfilActiveA);
            db.AddInParameter(dbCommand, "@IdActivo", DbType.String, IdActivo);
            db.AddInParameter(dbCommand, "@Observacion", DbType.String, Observacion);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;


        }


        




    }
}