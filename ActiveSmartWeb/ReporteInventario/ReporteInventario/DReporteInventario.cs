using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteInventario.ReporteInventario
{
    public class DReporteInventario : IReporteInventario
    {
       
        public List<EReporteInventario> ConsultarReporteInventario(int idPerfilActive, DateTime fechaInicial, DateTime fechaFinal)
        {
            List<EReporteInventario> eTomasReporte = new List<EReporteInventario>();
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
                    EReporteInventario eReporteInventario = new EReporteInventario();
                    int idTomaFisica = Convert.ToInt32(reader["IdTomaFisica"].ToString());
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    int categoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    int cantidadActivos = Convert.ToInt32(reader["CantidadActivos"].ToString());
                    string nombreUsuario = reader["NombreUsuario"].ToString();
                    eReporteInventario = new EReporteInventario(idTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), categoria, nombreCategoria, cantidadActivos, nombreUsuario);
                    eTomasReporte.Add(eReporteInventario);
                }
            }

            return eTomasReporte;
        }
        public List<EReporteInventario> ConsultaIDTomaFisica(int IdTomaFisica)
        {
            List<EReporteInventario> eReporteInventario = new List<EReporteInventario>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaIDTomaFisica");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            DbCommand.CommandTimeout = 3600;

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EReporteInventario eTomaReporte = new EReporteInventario();
                    int idTomaFisica = Convert.ToInt32(reader["IdTomaFisica"].ToString());
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    int categoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    int cantidadActivos = Convert.ToInt32(reader["CantidadActivos"].ToString());
                    string nombreUsuario = reader["NombreUsuario"].ToString();
                    eTomaReporte = new EReporteInventario(idTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), categoria, nombreCategoria, cantidadActivos, nombreUsuario);
                    eReporteInventario.Add(eTomaReporte);
                }
            }

            return eReporteInventario;
        }

    }
}