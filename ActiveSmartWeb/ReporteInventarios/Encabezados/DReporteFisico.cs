using ActiveSmartWeb.ReporteInventariosPrueba.DetalleReporteInventario;

using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteInventariosPrueba.Encabezados
{
    public class DReporteFisico
    {
        public List<EReporteFisico> ConsultarTomaFisica(int idPerfilActive, DateTime fechaInicial, DateTime fechaFinal)
        {
            List<EReporteFisico> eTomasFisicas = new List<EReporteFisico>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaTomaFisicaFijo");
            Db.AddInParameter(DbCommand, "@IdPerfilActive", DbType.Int32, idPerfilActive);
            Db.AddInParameter(DbCommand, "@FechaInicial", DbType.DateTime, Convert.ToDateTime(fechaInicial).Date);
            Db.AddInParameter(DbCommand, "@FechaFinal", DbType.DateTime, Convert.ToDateTime(fechaFinal).Date);
            DbCommand.CommandTimeout = 3600;

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EReporteFisico eTomaFisica = new EReporteFisico();
                    int idTomaFisica = Convert.ToInt32(reader["IdTomaFisica"].ToString());
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    int categoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    int cantidadActivos = Convert.ToInt32(reader["CantidadActivos"].ToString());
                    string nombreUsuario = reader["NombreUsuario"].ToString();
                    eTomaFisica = new EReporteFisico(idTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), categoria, nombreCategoria, cantidadActivos, nombreUsuario);
                    eTomasFisicas.Add(eTomaFisica);
                }
            }

            return eTomasFisicas;
        }
        // Metodo que ejecuta el procedimiento almacenado 
        public List<EDetalleResultadoInventario> ConsultaResultadoInventario(int IdTomaFisica)
        {
            List<EDetalleResultadoInventario> eDetalleReporte = new List<EDetalleResultadoInventario>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaResultadoInventario");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            DbCommand.CommandTimeout = 3600;

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EDetalleResultadoInventario eDetalleReporteI = new EDetalleResultadoInventario();
                    //int idTomaFisica = Convert.ToInt32(reader["IdTomaFisica"].ToString());
                    //int idCategoriaActivo = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numActivos = reader["NumeroActivo"].ToString();
                    string placa = reader["PlacaActivo"].ToString();
                    string descripcionActivo = reader["DescripcionActivo"].ToString();
                    string observacionActivo = reader["ObservacionActivoToma"].ToString();
                    string resultadoReporte = reader["ResultadoInventario"].ToString();
                    eDetalleReporteI = new EDetalleResultadoInventario(idActivo, numActivos, placa, descripcionActivo, observacionActivo, resultadoReporte);
                    eDetalleReporte.Add(eDetalleReporteI);
                }
            }

            return eDetalleReporte;
        }
        //CONSULTA TOMA FISICA 
        public List<EReporteFisico> ConsultaIDTomaFisica(int IdTomaFisica)
        {
            List<EReporteFisico> eTomasFisicas = new List<EReporteFisico>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaIDTomaFisica");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            DbCommand.CommandTimeout = 3600;

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EReporteFisico eTomaFisica = new EReporteFisico();
                    int idTomaFisica = Convert.ToInt32(reader["IdTomaFisica"].ToString());
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    int categoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    int cantidadActivos = Convert.ToInt32(reader["CantidadActivos"].ToString());
                    string nombreUsuario = reader["NombreUsuario"].ToString();
                    eTomaFisica = new EReporteFisico(idTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), categoria, nombreCategoria, cantidadActivos, nombreUsuario);
                    eTomasFisicas.Add(eTomaFisica);
                }
            }

            return eTomasFisicas;
        }



    }
}