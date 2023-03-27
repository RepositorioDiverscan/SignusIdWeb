using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.PerfilEmpresa.Entidades
{
    public class DPerfilEmpresa
    {

        //Metodo para actualizar el perfil de una empresa
        public string ActualizarPerfilEmpresa(EPerfilEmpresa perfilEmpresa)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ModificarPerfilEmpresa");
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int64, perfilEmpresa.IdPerfilEmpresa);
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, perfilEmpresa.Nombre);
            db.AddInParameter(dbCommand, "@Telefono", DbType.String, perfilEmpresa.Telefono);
            db.AddInParameter(dbCommand, "@Correo", DbType.String, perfilEmpresa.Correo);
            db.AddInParameter(dbCommand, "@IdEmpresa", DbType.String, perfilEmpresa.IdEmpresa);
            db.AddInParameter(dbCommand, "@Pais", DbType.String, perfilEmpresa.Pais);
            db.AddInParameter(dbCommand, "@Direccion", DbType.String, perfilEmpresa.Direccion);
            db.AddInParameter(dbCommand, "@IdIndustria", DbType.Int64, perfilEmpresa.Industria);
            db.AddInParameter(dbCommand, "@ContactoPrincipal", DbType.String, perfilEmpresa.ContactoPrincipal);
            db.AddInParameter(dbCommand, "@Moneda", DbType.String, perfilEmpresa.Moneda);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        //Metodo para consultar el perfil de la empresa
        public List<EPerfilEmpresa> ConsultarPerfilEmpresa(int IdEmpresa)
        {
            List<EPerfilEmpresa> perfilEmpresa = new List<EPerfilEmpresa>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarPerfilEmpresa");
            db.AddInParameter(dbCommand, "@IdEmpresa", DbType.Int64, IdEmpresa);
            dbCommand.CommandTimeout = 3600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EPerfilEmpresa perfil = new EPerfilEmpresa();
                    int idPerfilEmpresa = Convert.ToInt32(reader["IdPerfilEmpresa"].ToString());
                    string nombre = Convert.ToString(reader["Nombre"].ToString());
                    string telefono = Convert.ToString(reader["Telefono"].ToString());
                    string correo = Convert.ToString(reader["Correo"].ToString());
                    string idEmpresa = Convert.ToString(reader["IdEmpresa"].ToString());
                    string IdIndustria = Convert.ToString(reader["IdIndustria"].ToString());
                    string Pais = Convert.ToString(reader["Pais"].ToString());
                    string Direccion = Convert.ToString(reader["Direccion"].ToString());
                    string ContactoPrincipal = Convert.ToString(reader["ContactoPrincipal"].ToString());
                    string ImagenEmpresa = Convert.ToString(reader["ImagenEmpresa"].ToString());
                    string Moneda = Convert.ToString(reader["Moneda"].ToString());
                   
                    perfil = new EPerfilEmpresa(idPerfilEmpresa, nombre, ContactoPrincipal, correo, Pais,
                        Direccion, telefono, IdIndustria, idEmpresa, ImagenEmpresa, Moneda);
                    perfilEmpresa.Add(perfil);
                }
            }
            return perfilEmpresa;
        }

        //Metodo para consultar el rol del usuario
        public string ConsultarRolUsuario(int IdEmpresa, int IdperfilUsuario)
        {
            string rol="";
            List<EPerfilEmpresa> perfilEmpresa = new List<EPerfilEmpresa>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarUsuarioRol");
            db.AddInParameter(dbCommand, "@IdEmpresa", DbType.Int64, IdEmpresa);
            db.AddInParameter(dbCommand, "@IdPerfilUsuario", DbType.Int64, IdperfilUsuario);
            dbCommand.CommandTimeout = 3600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    rol = Convert.ToString(reader["NombreRol"].ToString());
                }
            }
            return rol;
        }
      
        //Metodo para consultar las industrias
        public List<EIndustria> ConsultarIndustria()
        {
            List<EIndustria> Industrias = new List<EIndustria>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ConsultaIndustria");
            dbCommand.CommandTimeout = 3600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EIndustria industria = new EIndustria();
                    int idIndustria = Convert.ToInt32(reader["IdIndustria"].ToString());
                    string Nombre = Convert.ToString(reader["Nombre"].ToString());
                    string Descripcion = Convert.ToString(reader["Descripcion"].ToString());

                    industria = new EIndustria(idIndustria, Nombre, Descripcion);
                    Industrias.Add(industria);
                }
            }
            return Industrias;
        }
    }
}