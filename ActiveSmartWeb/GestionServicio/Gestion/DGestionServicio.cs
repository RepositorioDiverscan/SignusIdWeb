using ActiveSmartWeb.Activos.Activos;
using ActiveSmartWeb.Login.Entidades;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.GestionServicio.Gestion
{
    public class DGestionServicio 
    {
        public List<EGestionServicio> ObtenerDetalleEmpresa(int idEmpresa)
        {
            List<EGestionServicio> detallesEmpresa = new List<EGestionServicio>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ObtenerDetalleEmpresa");
            db.AddInParameter(dbCommand, "@IdEmpresa", DbType.Int32, idEmpresa);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EGestionServicio gestionServicio = new EGestionServicio();
                    int idGestionServicio = Convert.ToInt32(reader["IdGestionServicio"].ToString());
                    int numeroTicket = Convert.ToInt32(reader["NumeroTicket"].ToString());
                    long idActivo = Convert.ToInt64(reader["IdActivo"].ToString());
                    string tipoRequerimiento = reader["TipoRequerimiento"].ToString();
                    string estado = reader["Estado"].ToString();
                    int idUsuarioSolicita = Convert.ToInt32(reader["IdUsuarioSolicita"].ToString());
                    int idUsuarioAsignado = Convert.ToInt32(reader["IdUsuarioAsignado"].ToString());
                    string descripcion = reader["Descripcion"].ToString();
                    int idPerfilEmpresa = Convert.ToInt32(reader["IdPerfilEmpresa"].ToString());
                    string fecha = reader["Fecha"].ToString();

                    gestionServicio = new EGestionServicio(idGestionServicio, numeroTicket, idActivo, tipoRequerimiento, estado, idUsuarioSolicita, idUsuarioAsignado, descripcion, idPerfilEmpresa, DateTime.Parse(fecha));
                    detallesEmpresa.Add(gestionServicio);
                }
            }
            return detallesEmpresa;
        }

        public string InsertarGestion(EGestionServicio gestionServicio)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_InsertarGestionServicio");
            db.AddInParameter(dbCommand, "@IdActivo", DbType.Int64, gestionServicio.IdActivo);
            db.AddInParameter(dbCommand, "@TipoRequerimiento", DbType.String, gestionServicio.TipoRequerimiento);
            db.AddInParameter(dbCommand, "@Estado", DbType.String, gestionServicio.Estado);
            db.AddInParameter(dbCommand, "@IdUsuarioSolicita", DbType.Int32, gestionServicio.IdUsuarioSolicita);
            db.AddInParameter(dbCommand, "@IdUsuarioAsignado", DbType.Int32, gestionServicio.IdUsuarioAsignado);
            db.AddInParameter(dbCommand, "@Descripcion", DbType.String, gestionServicio.Descripcion);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, gestionServicio.IdPerfilEmpresa);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public string ActualizarGestion(EGestionServicio gestionServicio)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ActualizarGestionServicio");
            db.AddInParameter(dbCommand, "@IdGestionServicio", DbType.Int32, gestionServicio.IdGestionServicio);
            db.AddInParameter(dbCommand, "@Estado", DbType.String, gestionServicio.Estado);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public List<Elogin> ObtenerUsuarios(int IdPerfilEmpresa)
        {
            List<Elogin> elogins = new List<Elogin>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ConsultaUsuariosEmpresa");
            db.AddInParameter(dbCommand, "@idEmpresa", DbType.Int32, IdPerfilEmpresa);
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    Elogin eE = new Elogin();
                    eE.IdPerfilUsuario = Convert.ToInt64(reader["IdPerfilUsuario"].ToString());
                    eE.Nombre = reader["Nombre"].ToString();
                    eE.Apellildo = reader["Apellidos"].ToString();
                    elogins.Add(eE);
                }
            }
            return elogins;
        }

        public List<string> ObtenerActivo(int TipoDeBusqueda, string Buscar, int IdPerfilEmpresa)
        {
            List<string> activo = new List<string>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_BuscarActivo");
            db.AddInParameter(dbCommand, "@TipoBusqueda", DbType.Int32, TipoDeBusqueda);
            db.AddInParameter(dbCommand, "@Buscar", DbType.String, Buscar);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, IdPerfilEmpresa);
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    activo.Add(reader["IdActivo"].ToString());  
                    activo.Add(reader["DescripcionActivo"].ToString());
                }
            }
            return activo;
        }

        public EActivo ObtenerActivoId (int idActico)
        {
            EActivo eA = null;
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ObtenerActivoId");
            db.AddInParameter(dbCommand, "@IdActivo", DbType.Int32, idActico);
            dbCommand.CommandTimeout = 3600;
            using (var reader = db.ExecuteReader(dbCommand))
            {
                if (reader.Read())
                {
                    eA = new EActivo();
                    eA.IdActivo = reader["IdActivo"].ToString();
                    eA.NumeroActivo = reader["NumeroActivo"].ToString();
                    eA.PlacaActivo = reader["PlacaActivo"].ToString();
                    eA.DescripcionCorta = reader["DescripcionCorta"].ToString();
                    eA.NombreEstado = reader["NombreEstado"].ToString();
                    eA.NombreCategoria = reader["NombreCategoria"].ToString();
                    eA.NombreUbicacion = reader["Nombre"].ToString();
                    eA.Marca = reader["Marca"].ToString();
                    eA.Modelo = reader["Modelo"].ToString();
                    eA.Serie = reader["Serie"].ToString();
                }
            }

            return eA;
        }

        public List<string> ObtenerNombreUsuario(int IdUsuario)
        {
            List<string> usuario = new List<string>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ObtenerNombreUsuarioId");
            db.AddInParameter(dbCommand, "@IdPerfilUsuario", DbType.Int32, IdUsuario);
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    usuario.Add(reader["Nombre"].ToString());
                    usuario.Add(reader["Apellidos"].ToString());
                }
            }
            return usuario;
        }

    }
}