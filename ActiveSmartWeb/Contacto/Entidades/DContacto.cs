using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Contacto.Entidades
{
    public class DContacto
    {

        public string InsertarContacto(EContacto contacto)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_Registrar_Contacto");
            db.AddInParameter(dbCommand, "@asunto", DbType.String, contacto.Asunto);
            db.AddInParameter(dbCommand, "@nombre", DbType.String, contacto.Nombre);
            db.AddInParameter(dbCommand, "@apellido", DbType.String, contacto.Apellido);
            db.AddInParameter(dbCommand, "@telefono", DbType.String, contacto.Telefono);
            db.AddInParameter(dbCommand, "@correo", DbType.String, contacto.Correo);
            db.AddInParameter(dbCommand, "@mensaje", DbType.String, contacto.Mensaje);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

    }
}