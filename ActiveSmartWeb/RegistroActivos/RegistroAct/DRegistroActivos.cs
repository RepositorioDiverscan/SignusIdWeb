using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroActivos.RegistroAct
{
    public class DRegistroActivos : IRegistroActivos
    {
        public List<ERegistroActivos> ConsultaRegistroActivo ()
        {
            List<ERegistroActivos> eRegistroActivos = new List<ERegistroActivos>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaRegistroActivo");
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    ERegistroActivos eregistro = new ERegistroActivos();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string descripcion = reader["DescripcionActivo"].ToString();
                    string marca = reader["Marca"].ToString();
                    string modelo = reader["Modelo"].ToString();
                    string serie = reader["Serie"].ToString();
                    string numerotag = reader["NumeroTag"].ToString();
                    DateTime fechabaja = Convert.ToDateTime(reader["FechaBaja"].ToString());
                    DateTime fecharegistro = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    int idUbicaionA = Convert.ToInt32(reader["idUbicacionA"].ToString());
                    int idPerfilEmpresa = Convert.ToInt32(reader["IdPerfilEmpresa"].ToString());
                    int idEstadoActivo = Convert.ToInt32(reader["idEstadoActivo"].ToString());
                    int idCategoriaActivo = Convert.ToInt32(reader["idCategoriaActivo"].ToString());
                    string numeroSerie = reader["NumeroSerie"].ToString();
                    string descripcionCorta = reader["DescripcionCorta"].ToString();
                    string descripcionCategoria = reader["DescripcionCategoria"].ToString();
                    string descripcionEstado = reader["DescripcionEstado"].ToString();
                    string numeroFactura = reader["NumeroFactura"].ToString();
                    DateTime fechaCompra = Convert.ToDateTime(reader["FechaCompra"].ToString());
                    decimal costoActivo = Convert.ToDecimal(reader["CostoActivo"].ToString());


                    eregistro = new ERegistroActivos(idActivo, numeroActivo, placaActivo, descripcion, marca, modelo,serie, numerotag
                                , fechabaja, fecharegistro, idPerfilEmpresa, idEstadoActivo, idCategoriaActivo, idUbicaionA,
                                numeroSerie, descripcionCorta, descripcionCategoria, descripcionEstado, numeroFactura, fechaCompra, costoActivo);
                    eRegistroActivos.Add(eregistro);
                }
            }
            return eRegistroActivos;
        }

        public string InsertarActivoFijo(string numeroActivo, string placaActivo, string marca, string modelo,
                                              int idEstadoActivo, int idCategoriaActivo, int idUbicaionA, int idPerfilEmpresa, string numeroSerie,
                                              string descripcionCorta, string descripcionCategoria, string descripcionEstado, string numerofactura,
                                              DateTime fechaCompra, decimal costoActivo )
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InsertarActivoFijo");
            db.AddInParameter(dbCommand, "@NumeroActivo", DbType.String, numeroActivo);
            db.AddInParameter(dbCommand, "@PlacaActivo", DbType.String, placaActivo);
            db.AddInParameter(dbCommand, "@Marca", DbType.String, marca);
            db.AddInParameter(dbCommand, "@Modelo", DbType.String, modelo);
            db.AddInParameter(dbCommand, "@IdEstadoActivo", DbType.Int32, idEstadoActivo);
            db.AddInParameter(dbCommand, "@IdCategoriaActivo", DbType.Int32, idCategoriaActivo);
            db.AddInParameter(dbCommand, "@IdUbicacionA", DbType.Int32, idUbicaionA);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            db.AddInParameter(dbCommand, "@NumeroSerie", DbType.String, numeroSerie);
            db.AddInParameter(dbCommand, "@DescripcionCorta", DbType.String, descripcionCorta);
            db.AddInParameter(dbCommand, "@DescripcionCategoria", DbType.String, descripcionCategoria);
            db.AddInParameter(dbCommand, "@DescripcionEstado", DbType.String, descripcionEstado);
            db.AddInParameter(dbCommand, "@NumeroFactura", DbType.String, numerofactura);
            db.AddInParameter(dbCommand, "@FechaCompra", DbType.DateTime, fechaCompra);
            db.AddInParameter(dbCommand, "@CostoActivo", DbType.Decimal, costoActivo);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
          
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;


        }

        public string ActualizaActivoFijo (int IdActivo, string numeroActivo, string placaActivo, string marca, string modelo,
                                             int idEstadoActivo, int idCategoriaActivo, int idUbicaionA,string numeroSerie, string descripcionCorta,
                                             string descripcionCategoria, string descripcionEstado, string numeroFactura, DateTime fechaCompra,
                                             decimal costoActivo)
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizaActivoFijo");
            db.AddInParameter(dbCommand, "@IdActivo", DbType.String, IdActivo);
            db.AddInParameter(dbCommand, "@NumeroActivo", DbType.String, numeroActivo);
            db.AddInParameter(dbCommand, "@PlacaActivo", DbType.String, placaActivo);    
            db.AddInParameter(dbCommand, "@Marca", DbType.String, marca);
            db.AddInParameter(dbCommand, "@Modelo", DbType.String, modelo);
            db.AddInParameter(dbCommand, "@IdEstadoActivo", DbType.Int32, idEstadoActivo);
            db.AddInParameter(dbCommand, "@IdCategoriaActivo", DbType.Int32, idCategoriaActivo);
            db.AddInParameter(dbCommand, "@IdUbicacionA", DbType.Int32, idUbicaionA);
            db.AddInParameter(dbCommand, "@NumeroSerie", DbType.String, numeroSerie);
            db.AddInParameter(dbCommand, "@DescripcionCorta", DbType.String, descripcionCorta);
            db.AddInParameter(dbCommand, "@DescripcionCategoria", DbType.String, descripcionCategoria);
            db.AddInParameter(dbCommand, "@DescripcionEstado", DbType.String, descripcionEstado);
            db.AddInParameter(dbCommand, "@NumeroFactura", DbType.String, numeroFactura);
            db.AddInParameter(dbCommand, "@FechaCompra", DbType.DateTime, fechaCompra);
            db.AddInParameter(dbCommand, "@CostoActivo", DbType.Decimal, costoActivo);

            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;


        }

    }
}