using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.TomaFisica.Encabezado
{
    public class DTomaFisica : ITomaFisica
    {
        public string ActualizarTomaFisica(int idTomaFisica, string nombre, string descripcion, DateTime fechaInicial, 
            DateTime fechaFinal, int categoria, int usuario, int ubicacion)
        {
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ActualizarTomaFisicaFijo");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, idTomaFisica);
            Db.AddInParameter(DbCommand, "@Nombre", DbType.String, nombre);
            Db.AddInParameter(DbCommand, "@Descripcion", DbType.String, descripcion);
            Db.AddInParameter(DbCommand, "@FechaInicio", DbType.DateTime, fechaInicial);
            Db.AddInParameter(DbCommand, "@FechaFinal", DbType.DateTime, fechaFinal);
            Db.AddInParameter(DbCommand, "@IdCategoriaActivo", DbType.Int32, categoria);
            Db.AddInParameter(DbCommand, "@UsuarioAsignado", DbType.Int32, usuario);
            Db.AddInParameter(DbCommand, "@IdUbicacion", DbType.Int32, ubicacion);
            Db.AddOutParameter(DbCommand, "@Respuesta", DbType.String, 200);
            DbCommand.CommandTimeout = 3600;
            Db.ExecuteNonQuery(DbCommand);

            var Respuesta = Db.GetParameterValue(DbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public string InsertarTomaFisica(string nombre, string descripcion, DateTime fechaInicial, DateTime fechaFinal, int categoria,
            int idPerfilActive , int idUsarioAsignado , int idUbicacion)
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

        public List<ETomaFisica> ConsultarTomaFisica(int idPerfilActive, DateTime fechaInicial, DateTime fechaFinal)
        {
            List<ETomaFisica> eTomasFisicas = new List<ETomaFisica>();
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
                    ETomaFisica eTomaFisica = new ETomaFisica();
                    int idTomaFisica = Convert.ToInt32(reader["IdTomaFisica"].ToString());
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    int categoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    string nombreCategoria = reader["Categoria"].ToString();
                    int cantidadActivos = Convert.ToInt32(reader["Activos"].ToString());
                    string Ubicacion = reader["Ubicacion"].ToString();
                    eTomaFisica = new ETomaFisica(idTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), categoria, nombreCategoria, cantidadActivos, Ubicacion, 0, 0);
                    eTomasFisicas.Add(eTomaFisica);
                }
            }

            return eTomasFisicas;
        }

        public List<ETomaFisica> ConsultarTodosTomaFisica(int idPerfilActive)
        {
            List<ETomaFisica> eTomasFisicas = new List<ETomaFisica>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaTomaFisica");
            Db.AddInParameter(DbCommand, "@IdPerfilActive", DbType.Int32, idPerfilActive);
            DbCommand.CommandTimeout = 3600;

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    ETomaFisica eTomaFisica = new ETomaFisica();
                    int idTomaFisica = Convert.ToInt32(reader["IdTomaFisica"].ToString());
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    int idCategoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    string nombreCategoria = reader["Categoria"].ToString();
                    int cantidadActivos = Convert.ToInt32(reader["Activos"].ToString());
                    string Ubicacion = reader["Ubicacion"].ToString();
                    int idUbicacion = Convert.ToInt32(reader["IdUbicacion"].ToString());
                    int idUsuarioAsignado = Convert.ToInt32(reader["UsuarioAsignado"].ToString());
                    eTomaFisica = new ETomaFisica(idTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), idCategoria, nombreCategoria, cantidadActivos, Ubicacion, idUsuarioAsignado, idUbicacion);
                    eTomasFisicas.Add(eTomaFisica);
                }
            }

            return eTomasFisicas;
        }

        public List<ETomaFisica> ConsultaIDTomaFisica(int IdTomaFisica)
        {
            List<ETomaFisica> eTomasFisicas = new List<ETomaFisica>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaIDTomaFisica");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            DbCommand.CommandTimeout = 3600;

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    ETomaFisica eTomaFisica = new ETomaFisica();
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    int idCategoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idUsuarioAsignado = Convert.ToInt32(reader["UsuarioAsignado"].ToString());
                    int idUbicacion = Convert.ToInt32(reader["idUbicacion"].ToString());
                    eTomaFisica = new ETomaFisica(IdTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), idCategoria, nombreCategoria, 0, "", idUsuarioAsignado, idUbicacion);
                    eTomasFisicas.Add(eTomaFisica);
                }
            }

            return eTomasFisicas;
        }

        public List<ETomaFisica> ConsultaIDEditarTomaFisica(int IdTomaFisica)
        {
            List<ETomaFisica> eTomasFisicas = new List<ETomaFisica>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaIDEditarTomaFisica");
            Db.AddInParameter(DbCommand, "@IdTomaFisica", DbType.Int32, IdTomaFisica);
            DbCommand.CommandTimeout = 3600;

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    ETomaFisica eTomaFisica = new ETomaFisica();
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    int idCategoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idUsuarioAsignado = Convert.ToInt32(reader["UsuarioAsignado"].ToString());
                    int idUbicacion = Convert.ToInt32(reader["idUbicacion"].ToString());
                    eTomaFisica = new ETomaFisica(IdTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), idCategoria, "", 0, "", idUsuarioAsignado, idUbicacion);
                    eTomasFisicas.Add(eTomaFisica);
                }
            }


            return eTomasFisicas;
        }

    }
}