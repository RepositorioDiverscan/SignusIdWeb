using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;

namespace ActiveSmartWeb.Activos.Activos
{
    public class DActivos : IActivos
    {
        public List<EActivos> ObtenerActivoPorNumActivo(string numActivo, int idPerfilEmpresa)
        {
            List<EActivos> eActivos = new List<EActivos>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerActivoPorNumActivo");
            Db.AddInParameter(DbCommand, "@NumeroActivo", DbType.String, numActivo);
            Db.AddInParameter(DbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            DbCommand.CommandTimeout = 3600;
            
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EActivos eActivosA = new EActivos();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string descripcion = reader["DescripcionCorta"].ToString();
                    string observacion = reader["Observacion"].ToString();
                    string marca = reader["Marca"].ToString();
                    string modelo = reader["Modelo"].ToString();
                    string serie = reader["Serie"].ToString();
                    string numerotag = reader["NumeroTag"].ToString();
                    DateTime fechabaja = Convert.ToDateTime(reader["FechaBaja"].ToString());
                    DateTime fecharegistro = Convert.ToDateTime(reader["FechaRegistro"].ToString());                    
                    int idEstadoActivo = Convert.ToInt32(reader["IdEstadoActivo"].ToString());
                    int idCategoriaActivo = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idUbicaionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    string nombreEstado = reader["NombreEstado"].ToString();
                    string nombreUbiccacion = reader["Nombre"].ToString();


                    eActivosA = new EActivos(idActivo, numeroActivo, placaActivo, descripcion, observacion, marca, modelo, serie,
                                            numerotag, fechabaja, fecharegistro, idPerfilEmpresa, idEstadoActivo, idCategoriaActivo,
                                            idUbicaionA, nombreCategoria, nombreEstado , nombreUbiccacion);
                    eActivos.Add(eActivosA);
                }
            }
            return eActivos;
        }
        public List<EActivos> ObtenerActivoPorNumPlaca(string numPlaca, int idPerfilEmpresa)
        {
            List<EActivos> eActivos = new List<EActivos>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerActivoPorNumPlaca");
            Db.AddInParameter(DbCommand, "@PlacaActivo", DbType.String, numPlaca);
            Db.AddInParameter(DbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EActivos eActivosA = new EActivos();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string descripcion = reader["DescripcionCorta"].ToString();
                    string observacion = reader["Observacion"].ToString();
                    string marca = reader["Marca"].ToString();
                    string modelo = reader["Modelo"].ToString();
                    string serie = reader["Serie"].ToString();
                    string numerotag = reader["NumeroTag"].ToString();
                    DateTime fechabaja = Convert.ToDateTime(reader["FechaBaja"].ToString());
                    DateTime fecharegistro = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    int idEstadoActivo = Convert.ToInt32(reader["IdEstadoActivo"].ToString());
                    int idCategoriaActivo = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idUbicaionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    string nombreEstado = reader["NombreEstado"].ToString();
                    string nombreUbiccacion = reader["Nombre"].ToString();
                   


                    eActivosA = new EActivos(idActivo, numeroActivo, placaActivo, descripcion, observacion, marca, modelo, serie,
                                            numerotag, fechabaja, fecharegistro, idPerfilEmpresa, idEstadoActivo, idCategoriaActivo,
                                            idUbicaionA, nombreCategoria, nombreEstado, nombreUbiccacion);
                    eActivos.Add(eActivosA);
                }
            }
            return eActivos;
        }
        public List<EActivos> ObtenerActivoPorDescripcion(string descripcionActivo, int idPerfilEmpresa)
        {
            List<EActivos> eActivos = new List<EActivos>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerActivoPorDescripcion");
            Db.AddInParameter(DbCommand, "@DescripcionActivo", DbType.String, descripcionActivo);
            Db.AddInParameter(DbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            DbCommand.CommandTimeout = 3600;
            
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EActivos eActivosA = new EActivos();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string descripcion = reader["DescripcionCorta"].ToString();
                    string observacion = reader["Observacion"].ToString();
                    string marca = reader["Marca"].ToString();
                    string modelo = reader["Modelo"].ToString();
                    string serie = reader["Serie"].ToString();
                    string numerotag = reader["NumeroTag"].ToString();
                    DateTime fechabaja = Convert.ToDateTime(reader["FechaBaja"].ToString());
                    DateTime fecharegistro = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    int idEstadoActivo = Convert.ToInt32(reader["IdEstadoActivo"].ToString());
                    int idCategoriaActivo = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idUbicaionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    string nombreEstado = reader["NombreEstado"].ToString();
                    string nombreUbiccacion = reader["Nombre"].ToString();
                 


                    eActivosA = new EActivos(idActivo, numeroActivo, placaActivo, descripcion, observacion, marca, modelo, serie,
                                            numerotag, fechabaja, fecharegistro, idPerfilEmpresa, idEstadoActivo, idCategoriaActivo,
                                            idUbicaionA, nombreCategoria, nombreEstado, nombreUbiccacion);
                    eActivos.Add(eActivosA);
                }
            }
            return eActivos;
        }
        public List<EActivos> ObtenerActivoPorNumActivoCompleto(string numActivo, int idPerfilEmpresa)
        {
            List<EActivos> eActivos = new List<EActivos>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerActivoPorNumActivoCompleto");
            Db.AddInParameter(DbCommand, "@NumeroActivo", DbType.String, numActivo);
            Db.AddInParameter(DbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            DbCommand.CommandTimeout = 3600;
           
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EActivos eActivosA = new EActivos();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string observacion = reader["Observacion"].ToString();
                    string marca = reader["Marca"].ToString();
                    string modelo = reader["Modelo"].ToString();
                    int idEstadoActivo = Convert.ToInt32(reader["IdEstadoActivo"].ToString());
                    int idCategoriaActivo = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idUbicaionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    string nombreEstado = reader["NombreEstado"].ToString();
                    string nombreUbiccacion = reader["Nombre"].ToString();
                    string numeroSerie = reader["NumeroSerie"].ToString();
                    string descripcionCorta = reader["DescripcionCorta"].ToString();
                    string descripcionCategoria = reader["DescripcionCategoria"].ToString();
                    string descripcionEstado = reader["DescripcionEstado"].ToString();
                    string numeroFactura = reader["NumeroFactura"].ToString();
                    DateTime fechaCompra = Convert.ToDateTime(reader["FechaCompra"].ToString());
                    decimal costoActivo = Convert.ToDecimal(reader["CostoActivo"].ToString());


                    eActivosA = new EActivos(idActivo, numeroActivo, placaActivo, observacion, marca, modelo, idPerfilEmpresa, idEstadoActivo, idCategoriaActivo,
                                            idUbicaionA, nombreCategoria, nombreEstado, nombreUbiccacion, numeroSerie, descripcionCorta,
                                           descripcionCategoria, descripcionEstado, numeroFactura, fechaCompra, costoActivo);
                    eActivos.Add(eActivosA);
                }
            }
            return eActivos;
        }

    }
}