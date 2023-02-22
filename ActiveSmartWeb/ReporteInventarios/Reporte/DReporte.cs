using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteInventariosPrueba.DetalleReporte
{
    public class DReporte
    {


        public string ActualizarTomaFisica(string nombre, string descripcion, DateTime fechaInicial,
           DateTime fechaFinal, int idTomaFisica, int categoria)
        {
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ActualizarTomaFisicaFijo");
            Db.AddInParameter(DbCommand, "@Nombre", DbType.String, nombre);
            Db.AddInParameter(DbCommand, "@Descripcion", DbType.String, descripcion);
            Db.AddInParameter(DbCommand, "@FechaInicio", DbType.DateTime, fechaInicial);
            Db.AddInParameter(DbCommand, "@FechaFinal", DbType.DateTime, fechaFinal);
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, idTomaFisica);
            Db.AddInParameter(DbCommand, "@IdCategoriaActivo", DbType.Int32, categoria);
            Db.AddOutParameter(DbCommand, "@Respuesta", DbType.String, 200);
            DbCommand.CommandTimeout = 3600;
            Db.ExecuteNonQuery(DbCommand);

            var Respuesta = Db.GetParameterValue(DbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public string InsertarTomaFisica(string nombre, string descripcion, DateTime fechaInicial, DateTime fechaFinal, int categoria,
            int idPerfilActive, int idUsarioAsignado, int idUbicacion)
        {
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("InsertarTomaFisicaFijo");
            Db.AddInParameter(DbCommand, "@Nombre", DbType.String, nombre);
            Db.AddInParameter(DbCommand, "@Descripcion", DbType.String, descripcion);
            Db.AddInParameter(DbCommand, "@FechaInicial", DbType.DateTime, fechaInicial);
            Db.AddInParameter(DbCommand, "@FechaFinal", DbType.DateTime, fechaFinal);
            Db.AddInParameter(DbCommand, "@IdPerfilActive", DbType.Int32, idPerfilActive);
            Db.AddInParameter(DbCommand, "@IdCategoriaActivo", DbType.Int32, categoria);
            Db.AddInParameter(DbCommand, "@UsuarioAsignado", DbType.Int32, idUsarioAsignado);
            Db.AddInParameter(DbCommand, "@IdUbicacion", DbType.Int32, idUbicacion);
            Db.AddOutParameter(DbCommand, "@Respuesta", DbType.String, 200);
            DbCommand.CommandTimeout = 3600;
            Db.ExecuteNonQuery(DbCommand);

            var Respuesta = Db.GetParameterValue(DbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public List<EDetalleReporte> ConsultarTomaFisica(int idPerfilActive, DateTime fechaInicial, DateTime fechaFinal)
        {
            List<EDetalleReporte> eTomasFisicas = new List<EDetalleReporte>();
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
                    EDetalleReporte eTomaFisica = new EDetalleReporte();
                    int idTomaFisica = Convert.ToInt32(reader["IdTomaFisica"].ToString());
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    int categoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    string nombreCategoria = reader["Categoria"].ToString();
                    int cantidadActivos = Convert.ToInt32(reader["Activos"].ToString());
                    string Ubicacion = reader["Ubicacion"].ToString();
                    eTomaFisica = new EDetalleReporte(idTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), categoria, nombreCategoria, cantidadActivos, Ubicacion);
                    eTomasFisicas.Add(eTomaFisica);
                }
            }

            return eTomasFisicas;
        }

        public List<EDetalleReporte> ConsultarTodosTomaFisica(int idPerfilActive)
        {
            List<EDetalleReporte> eTomasFisicas = new List<EDetalleReporte>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaTomaFisica");
            Db.AddInParameter(DbCommand, "@IdPerfilActive", DbType.Int32, idPerfilActive);
            DbCommand.CommandTimeout = 3600;

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EDetalleReporte eTomaFisica = new EDetalleReporte();
                    int idTomaFisica = Convert.ToInt32(reader["IdTomaFisica"].ToString());
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    int categoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    string nombreCategoria = reader["Categoria"].ToString();
                    int cantidadActivos = Convert.ToInt32(reader["Activos"].ToString());
                    string Ubicacion = reader["Ubicacion"].ToString();
                    eTomaFisica = new EDetalleReporte(idTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), categoria, nombreCategoria, cantidadActivos, Ubicacion);
                    eTomasFisicas.Add(eTomaFisica);
                }
            }

            return eTomasFisicas;
        }

        public List<EDetalleReporte> ConsultaIDTomaFisica(int IdTomaFisica)
        {
            List<EDetalleReporte> eTomasFisicas = new List<EDetalleReporte>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaIDTomaFisica");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            DbCommand.CommandTimeout = 3600;

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EDetalleReporte eTomaFisica = new EDetalleReporte();
                    int idTomaFisica = Convert.ToInt32(reader["IdTomaFisica"].ToString());
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    int categoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    int cantidadActivos = Convert.ToInt32(reader["CantidadActivos"].ToString());
                    string nombreUsuario = reader["NombreUsuario"].ToString();
                    eTomaFisica = new EDetalleReporte(idTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), categoria, nombreCategoria, cantidadActivos, nombreUsuario);
                    eTomasFisicas.Add(eTomaFisica);
                }
            }
            return eTomasFisicas;
        }
    }
}