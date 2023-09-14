using ActiveSmartWeb.Utilities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Cupon
{
    public class BDACupon
    {
        public string ConsultarValidezCupon(string codigoCupon)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ValidarCupon");
            db.AddInParameter(dbCommand, "@Codigo_Cupon", DbType.String, codigoCupon);
            db.AddOutParameter(dbCommand, "@Resultado", DbType.String, 600);


            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);


            var Respuesta = db.GetParameterValue(dbCommand, "@Resultado").ToString();
            return Respuesta;
        }

        public string ActualizarCupon(string codigoCupon, string correoUsuario)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizarCupon");
            db.AddInParameter(dbCommand, "@Codigo_Cupon", DbType.String, codigoCupon);
            db.AddInParameter(dbCommand, "@Correo_Usuario", DbType.String, correoUsuario);
            db.AddOutParameter(dbCommand, "@Resultado", DbType.String, 600);



            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);


            var Respuesta = db.GetParameterValue(dbCommand, "@Resultado").ToString();
            return Respuesta;

        }

    }
}