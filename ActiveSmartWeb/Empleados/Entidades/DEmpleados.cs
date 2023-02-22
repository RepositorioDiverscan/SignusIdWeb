using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Empleados.Entidades
{
    public class DEmpleados
    {

        //Metodo para hacer la inserción y actualización de un empleado
        public string InsertarEmpleado(EEmpleados empleados)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InsertarEmpleado");
            db.AddInParameter(dbCommand, "@IdEmpleados", DbType.Int64, empleados.IdEmpleados);
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, empleados.Nombre);
            db.AddInParameter(dbCommand, "@Apellidos", DbType.String, empleados.Apellidos);
            db.AddInParameter(dbCommand, "@Identificacion", DbType.String, empleados.Identificacion);
            db.AddInParameter(dbCommand, "@Correo", DbType.String, empleados.Correo);
            db.AddInParameter(dbCommand, "@Puesto", DbType.String, empleados.Puesto);
            db.AddInParameter(dbCommand, "@Telefono", DbType.String, empleados.Telefono);
            db.AddInParameter(dbCommand, "@Estado", DbType.Boolean, empleados.Estado);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.String, empleados.IdPerfilEmpresa);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        //Metodo para actualizar el estado de un empleado
        public string ActualizarEstadoEmpleado(bool Estado, int idEmpleado)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizarEstadoEmpleado");
            db.AddInParameter(dbCommand, "@IdEmpleados", DbType.Int64, idEmpleado);
            db.AddInParameter(dbCommand, "@Estado", DbType.Boolean, Estado);
             db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        //Metodo para consultar los empleados de una empresa
        public List<EEmpleados> ConsultarEmpleadoXEmpresa(int IdEmpresa)
        {
            List<EEmpleados> Empleados = new List<EEmpleados>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarEmpleadosEmpresa");
            db.AddInParameter(dbCommand, "@IdEmpresa", DbType.Int32, IdEmpresa);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EEmpleados empleado = new EEmpleados();
                    int idEmpleados = Convert.ToInt32(reader["IdEmpleados"].ToString());
                    string nombre = Convert.ToString(reader["Nombre"].ToString());
                    string apellidos = Convert.ToString(reader["Apellidos"].ToString());
                    string identificacion = Convert.ToString(reader["Identificacion"].ToString());
                    string correo = Convert.ToString(reader["Correo"].ToString());
                    string puesto = Convert.ToString(reader["Puesto"].ToString());
                    string telefono = Convert.ToString(reader["Telefono"].ToString());
                    string estado = Convert.ToString(reader["Estado"].ToString());
                    int idPerfilEmpresa = Convert.ToInt32(reader["IdPerfilEmpresa"].ToString());

                    empleado = new EEmpleados(idEmpleados, nombre, apellidos, identificacion, correo, puesto, telefono, estado, idPerfilEmpresa);
                    Empleados.Add(empleado);
                }
            }
            return Empleados;
        }
        //Metodo para consultar los empleados de una empresa por identificacion
        public List<EEmpleados> ConsultarEmpleadoXIdentificacion(int IdEmpresa, string Identificacion)
        {
            List<EEmpleados> Empleados = new List<EEmpleados>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarEmpleadosEmpresa");
            db.AddInParameter(dbCommand, "@IdEmpresa", DbType.Int32, IdEmpresa);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EEmpleados empleado = new EEmpleados();
                    int idEmpleados = Convert.ToInt32(reader["IdEmpleados"].ToString());
                    string nombre = Convert.ToString(reader["Nombre"].ToString());
                    string apellidos = Convert.ToString(reader["Apellidos"].ToString());
                    string identificacion = Convert.ToString(reader["Identificacion"].ToString());
                    string correo = Convert.ToString(reader["Correo"].ToString());
                    string puesto = Convert.ToString(reader["Puesto"].ToString());
                    string telefono = Convert.ToString(reader["Telefono"].ToString());
                    string estado = Convert.ToString(reader["Estado"].ToString());
                    int idPerfilEmpresa = Convert.ToInt32(reader["IdPerfilEmpresa"].ToString());

                    if (Identificacion.Equals(identificacion))
                    {
                        empleado = new EEmpleados(idEmpleados, nombre, apellidos, identificacion, correo, puesto, telefono, estado, idPerfilEmpresa);
                        Empleados.Add(empleado);
                    }

                }
            }
            return Empleados;
        }
        //Metodo para consultar los empleados de una empresa segun su estado
        public List<EEmpleados> ConsultarEmpleadoEstado(int IdEmpresa, bool Est)
        {
            List<EEmpleados> Empleados = new List<EEmpleados>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarEmpleadosEmpresa");
            db.AddInParameter(dbCommand, "@IdEmpresa", DbType.Int32, IdEmpresa);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EEmpleados empleado = new EEmpleados();
                    int idEmpleados = Convert.ToInt32(reader["IdEmpleados"].ToString());
                    string nombre = Convert.ToString(reader["Nombre"].ToString());
                    string apellidos = Convert.ToString(reader["Apellidos"].ToString());
                    string identificacion = Convert.ToString(reader["Identificacion"].ToString());
                    string correo = Convert.ToString(reader["Correo"].ToString());
                    string puesto = Convert.ToString(reader["Puesto"].ToString());
                    string telefono = Convert.ToString(reader["Telefono"].ToString());
                    string estado = Convert.ToString(reader["Estado"].ToString());
                    int idPerfilEmpresa = Convert.ToInt32(reader["IdPerfilEmpresa"].ToString());

                    if (Convert.ToBoolean(estado) == Est)
                    {
                        empleado = new EEmpleados(idEmpleados, nombre, apellidos, identificacion, correo, puesto, telefono, estado, idPerfilEmpresa);
                        Empleados.Add(empleado);
                    }
                }
            }
            return Empleados;
        }

    }
    }