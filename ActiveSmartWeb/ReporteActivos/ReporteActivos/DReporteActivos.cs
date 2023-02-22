using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;

namespace ActiveSmartWeb.ReporteActivos.ReporteActivos
{
    public class DReporteActivos : IReporteActivos
    {

        public List<EReporteActivos> ObtenerReporteActPorNumActivo(string numActivo, int idPerfilEmpresa)
        {
            List<EReporteActivos> eReporteActivos = new List<EReporteActivos>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerReporteActPorNumActivo");
            Db.AddInParameter(DbCommand, "@NumeroActivo", DbType.String, numActivo);
            Db.AddInParameter(DbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);

            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EReporteActivos eReporteA = new EReporteActivos();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string descripcion = reader["DescripcionCorta"].ToString();
                    DateTime fechaActualiza = Convert.ToDateTime(reader["FechaActualizacion"].ToString());
                    DateTime fecharegistro = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    int idEstadoActivo = Convert.ToInt32(reader["IdEstadoActivo"].ToString());
                    int idCategoriaActivo = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idUbicaionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    string nombreEstado = reader["NombreEstado"].ToString();
                    string nombreUbicacion = reader["Nombre"].ToString();


                    eReporteA = new EReporteActivos(idActivo, numeroActivo, placaActivo, descripcion, idEstadoActivo, idCategoriaActivo,
                                            idUbicaionA, nombreEstado, nombreCategoria, nombreUbicacion, fecharegistro, fechaActualiza);
                    eReporteActivos.Add(eReporteA);
                }
            }
            return eReporteActivos;
        }
        public List<EReporteActivos> ObtenerReporteActPorNumPlaca(string numPlaca, int idPerfilEmpresa)
        {
            List<EReporteActivos> eReporteAct = new List<EReporteActivos>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerReporteActPorNumPlaca");
            Db.AddInParameter(DbCommand, "@PlacaActivo", DbType.String, numPlaca);
            Db.AddInParameter(DbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);

            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EReporteActivos eReporteA = new EReporteActivos();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string descripcion = reader["DescripcionCorta"].ToString();
                    DateTime fechaActualiza = Convert.ToDateTime(reader["FechaActualizacion"].ToString());
                    DateTime fecharegistro = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    int idEstadoActivo = Convert.ToInt32(reader["IdEstadoActivo"].ToString());
                    int idCategoriaActivo = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idUbicaionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    string nombreEstado = reader["NombreEstado"].ToString();
                    string nombreUbicacion = reader["Nombre"].ToString();


                    eReporteA = new EReporteActivos(idActivo, numeroActivo, placaActivo, descripcion, idEstadoActivo, idCategoriaActivo,
                                            idUbicaionA, nombreEstado, nombreCategoria, nombreUbicacion, fecharegistro, fechaActualiza);
                    eReporteAct.Add(eReporteA);
                }
            }
            return eReporteAct;
        }
        public List<EReporteActivos> ObtenerReporteActPorDescripcion(string descripcionActivo, int idPerfilEmpresa)
        {
            List<EReporteActivos> eReporteActivos = new List<EReporteActivos>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerReporteActPorDescrip");
            Db.AddInParameter(DbCommand, "@DescripcionActivo", DbType.String, descripcionActivo);
            Db.AddInParameter(DbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EReporteActivos eReporteA = new EReporteActivos();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string descripcion = reader["DescripcionCorta"].ToString();
                    DateTime fechaActualiza = Convert.ToDateTime(reader["FechaActualizacion"].ToString());
                    DateTime fecharegistro = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    int idEstadoActivo = Convert.ToInt32(reader["IdEstadoActivo"].ToString());
                    int idCategoriaActivo = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idUbicaionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    string nombreEstado = reader["NombreEstado"].ToString();
                    string nombreUbicacion = reader["Nombre"].ToString();


                    eReporteA = new EReporteActivos(idActivo, numeroActivo, placaActivo, descripcion, idEstadoActivo, idCategoriaActivo,
                                            idUbicaionA, nombreEstado, nombreCategoria, nombreUbicacion, fecharegistro, fechaActualiza);
                    eReporteActivos.Add(eReporteA);
                }
            }
            return eReporteActivos;
        }

        public List<EReporteActivos> ObtenerReporteActivos(int idPerfilEmpresa)
        {
            List<EReporteActivos> eReporteActivos = new List<EReporteActivos>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ObtenerReporteActivosTodo");
            Db.AddInParameter(DbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EReporteActivos eReporteA = new EReporteActivos();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string descripcion = reader["DescripcionCorta"].ToString();
                    DateTime fechaActualiza = Convert.ToDateTime(reader["FechaActualizacion"].ToString());
                    DateTime fecharegistro = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    int idEstadoActivo = Convert.ToInt32(reader["IdEstadoActivo"].ToString());
                    int idCategoriaActivo = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idUbicaionA = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    string nombreEstado = reader["NombreEstado"].ToString();
                    string nombreUbicacion = reader["Nombre"].ToString();


                    eReporteA = new EReporteActivos(idActivo, numeroActivo, placaActivo, descripcion, idEstadoActivo, idCategoriaActivo,
                                            idUbicaionA, nombreEstado, nombreCategoria, nombreUbicacion, fecharegistro, fechaActualiza);
                    eReporteActivos.Add(eReporteA);
                }
            }
            return eReporteActivos;
        }

    }
}