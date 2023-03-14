using ActiveSmartWeb.Utilities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Registro
{
    public class DBUsuarioEmpresa
    {


        public string RegistrarUsuarioEmpresa(EUsuarioEmpresa eUsuarioEmpresa)
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("RegistrarEmpresaUsuario");

            db.AddInParameter(dbCommand, "@NombreEmpresa", DbType.String, eUsuarioEmpresa.NombreEmpresa);
            db.AddInParameter(dbCommand, "@TelefonoEmpresa", DbType.String, eUsuarioEmpresa.TelefonoEmpresa);
            db.AddInParameter(dbCommand, "@CorreoEmpresa", DbType.String, eUsuarioEmpresa.CorreoEmpresa);
            db.AddInParameter(dbCommand, "@NombreUsuario", DbType.String, eUsuarioEmpresa.NombreUsuario);
            db.AddInParameter(dbCommand, "@ApellidosUsuario", DbType.String, eUsuarioEmpresa.ApellidosUsuario);
            db.AddInParameter(dbCommand, "@CorreoUsuario", DbType.String, eUsuarioEmpresa.CorreoUsuario);
            db.AddInParameter(dbCommand, "@ContrasenaUsuario", DbType.String, Encrypt.EncriptarSHA3_512(eUsuarioEmpresa.Contrasena));

            db.AddInParameter(dbCommand, "@IdEmpresa", DbType.String, eUsuarioEmpresa.IdEmpresa);
            db.AddInParameter(dbCommand, "@IdIndustria", DbType.Int32, eUsuarioEmpresa.IdIndustria);
            db.AddInParameter(dbCommand, "@Pais", DbType.String, eUsuarioEmpresa.Pais);
            db.AddInParameter(dbCommand, "@Direccion", DbType.String, eUsuarioEmpresa.Direccion);
            db.AddInParameter(dbCommand, "@IdEmpresaTamano", DbType.Int32, eUsuarioEmpresa.IdEmpresaTamano);
            db.AddInParameter(dbCommand, "@Posicion", DbType.String, eUsuarioEmpresa.Posicion);
            db.AddInParameter(dbCommand, "@Moneda", DbType.String, eUsuarioEmpresa.Moneda);

            db.AddOutParameter(dbCommand, "@Codigo", DbType.String, 100);
            db.AddOutParameter(dbCommand, "@Resultado", DbType.String,600);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);

            var Codigo = db.GetParameterValue(dbCommand, "@Codigo").ToString();
            var Respuesta = db.GetParameterValue(dbCommand, "@Resultado").ToString();
            if (Codigo.Equals("0") || !Respuesta.Equals("Exitoso"))
            {
                return Respuesta;
            }
            else
            {
                var e = Correo.EnviarCorreoCodigo(eUsuarioEmpresa.CorreoUsuario, "CODIGO DE VERIFICACIÓN",
                    "Reciba un cordial saludo. " +
                    "El siguiente es un codigo de verificación de su cuenta: "+Codigo, Codigo);

                return Respuesta;
            }
           

            

        }

        public string GenerarNuevoCodigo(string correo)
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("GenerarNuevoCodigo");

            db.AddInParameter(dbCommand, "@CorreoUsuario", DbType.String, correo);

            db.AddOutParameter(dbCommand, "@CodigoVerifica", DbType.String, 100);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);

            var Codigo = db.GetParameterValue(dbCommand, "@CodigoVerifica").ToString();
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            if (Codigo.Equals("0") || !Respuesta.Equals("EXITOSO"))
            {
                return Respuesta;
            }
            else
            {
                var e = Correo.EnviarCorreoCodigo(correo, "CODIGO DE VERIFICACIÓN",
                    "Reciba un cordial saludo. " +
                    "El siguiente es su nuevo código de verificación de su cuenta: " + Codigo, Codigo);

                return Respuesta;
            }




        }

        public List<EIndustria> CargarIndustrias()
        {
             List<EIndustria> eIndustria = new List<EIndustria>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ConsultaIndustria");
            dbCommand.CommandTimeout = 3600;
        
            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    eIndustria.Add(new EIndustria(
                        Convert.ToInt32(reader["IdIndustria"].ToString()),
                        reader["Nombre"].ToString(),
                        reader["Descripcion"].ToString()
                        
                    ));
                }
            }
            return eIndustria;
        }

        public List<EEmpresaTamano> CargarEmpresaTamano()
        {
            List<EEmpresaTamano> empresaTamano = new List<EEmpresaTamano>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ConsultaEmpresaTamano");
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    empresaTamano.Add(new EEmpresaTamano(
                        Convert.ToInt32(reader["IdEmpresaTamano"].ToString()),
                        reader["Rango"].ToString(),
                        reader["Descripcion"].ToString()

                    ));
                }
            }
            return empresaTamano;
        }

        public string ValidarCodigo(string correo, string codigo)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ValidarCodigo");

            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo);
            db.AddInParameter(dbCommand, "@Codigo", DbType.String, codigo);

            db.AddOutParameter(dbCommand, "@Resultado", DbType.String, 600);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);

        
             var Respuesta = db.GetParameterValue(dbCommand, "@Resultado").ToString();

            return Respuesta;

        }

        //Metodo para cargar los adicionales.
        public List<EPaqueteAdicional> CargarAdicionales()
        {
            List<EPaqueteAdicional> ePaquetesAdicionales = new List<EPaqueteAdicional>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ObtenerPaqueteContratado");
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    ePaquetesAdicionales.Add(new EPaqueteAdicional(
                        Convert.ToInt32(reader["IdPaqueteContratado"].ToString()),
                        reader["Nombre"].ToString(),
                        reader["Descripcion"].ToString(),
                        Convert.ToInt32(reader["Tipo"].ToString()),
                        Convert.ToInt32(reader["Cantidad"].ToString()),
                        Convert.ToDecimal(reader["Costo"].ToString())

                    ));
                }
            }
            return ePaquetesAdicionales;
        }

        //Metodo que trae la informacion del plan seleccionado.
        public ETipoPlanes CargarPlan(int idplan)
        {

            ETipoPlanes  etipoplanes = new ETipoPlanes();
            
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_TipoContrato");
            db.AddInParameter(dbCommand, "@idtipocontrato", DbType.String, idplan);
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    int id = Convert.ToInt32(reader["IdTipoContrato"].ToString());
                    string nombreplan = reader["NombreTipoContrato"].ToString();
                    decimal costo = Convert.ToDecimal(reader["Costo"].ToString());
                    int cantidadRegalias = Convert.ToInt32(reader["cantidadRegalias"].ToString());

                    etipoplanes.IdTipoPlan = id;
                    etipoplanes.NombrePlan = nombreplan;
                    etipoplanes.Costo = costo;
                }
            }

            return etipoplanes;
        }

        //Metodo que llama al sp para insertar un contrato.
        public string InsertarContrato(string correo, int frecuenciapago, int idtipocontrato, List<EPaqueteAdicionalContratado> PaquetesAdicionales)
        {
            //Se crea un datatable con la lista de paquetes adicionales seleccionados.
            var dataTablePaquetesAdicionales = PaquetesAdicionales.ToDataTable();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_InsertarContrato");

            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo);
            db.AddInParameter(dbCommand, "@IdFrecuenciaPago", DbType.Int32, frecuenciapago);
            db.AddInParameter(dbCommand, "@IdTipoContrato", DbType.Int32, idtipocontrato);
            db.AddInParameter(dbCommand, "@IdMetodoPago", DbType.Int32, 1);
            db.AddOutParameter(dbCommand, "@Resultado", DbType.String, 600);

            SqlParameter parameterPaquetesAdicionales = new SqlParameter();
            parameterPaquetesAdicionales.ParameterName = "@TablaAdicionales";
            parameterPaquetesAdicionales.SqlDbType = System.Data.SqlDbType.Structured;
            parameterPaquetesAdicionales.Value = dataTablePaquetesAdicionales;
            dbCommand.Parameters.Add(parameterPaquetesAdicionales);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);

            var Respuesta = db.GetParameterValue(dbCommand, "@Resultado").ToString();

            return Respuesta;

        }
    }
}