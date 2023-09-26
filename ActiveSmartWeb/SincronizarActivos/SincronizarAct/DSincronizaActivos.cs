using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.SincronizarActivos.SincronizarAct
{
    public class DSincronizaActivos : ISincronizaActivos
    {
        public string InsertarActivoSincronizacion(string numeroActivo, string placaActivo, string idEstadoActivo, string idCategoriaActivo,
                                        string idUbicaionA, int idPerfilEmpresa, string marca, string modelo,
                                        string descripcionCorta, decimal costoActivo, int idArchivo)
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InsertarSincActivos");
            db.AddInParameter(dbCommand, "@NumeroActivo", DbType.String, numeroActivo);
            db.AddInParameter(dbCommand, "@PlacaActivo", DbType.String, placaActivo);
            db.AddInParameter(dbCommand, "@EstadoActivo", DbType.String, idEstadoActivo);
            db.AddInParameter(dbCommand, "@CategoriaActivo", DbType.String, idCategoriaActivo);
            db.AddInParameter(dbCommand, "@UbicacionA", DbType.String, idUbicaionA);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            db.AddInParameter(dbCommand, "@Marca", DbType.String, marca);
            db.AddInParameter(dbCommand, "@Modelo", DbType.String, modelo);
            db.AddInParameter(dbCommand, "@DescripcionCorta", DbType.String, descripcionCorta);
            db.AddInParameter(dbCommand, "@CostoActivo", DbType.Decimal, costoActivo);
            db.AddInParameter(dbCommand, "@idArchivo", DbType.Int32, idArchivo);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;


        }
        public string InsertarArchivo(int idPerfilEmpresa, int estado, string nombrearchivo)
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InsertarSincArchivo"); 
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            db.AddInParameter(dbCommand, "@Estado", DbType.Int32, estado);
            db.AddInParameter(dbCommand, "@NombreArchivo", DbType.String, nombrearchivo);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;

        }
        public List<ESincronizaActivos> ConsultaArchivo(int idPerfilEmpresa)
        {

            List<ESincronizaActivos> eSincro = new List<ESincronizaActivos>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaSincArchivo");
            Db.AddInParameter(DbCommand, "@idPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            DbCommand.CommandTimeout = 3600;

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    ESincronizaActivos eArchivo = new ESincronizaActivos();
                    int idSincro = Convert.ToInt32(reader["IdSincArchivo"].ToString());
                    string fechaRegistro = reader["FechaRegistro"].ToString();
                    int estado = Convert.ToInt32(reader["Estado"].ToString());
                    string estadosinc = reader["EstadoSincronizacion"].ToString();
                    string nombre = reader["Nombre"].ToString();

                    eArchivo = new ESincronizaActivos(idSincro, DateTime.Parse(fechaRegistro), estado,estadosinc);
                    eArchivo.Nombre = nombre;

                    eSincro.Add(eArchivo);
                }
            }

            return eSincro;
        }
        public string InsertarActivoFijo(int IdArchivo, int idPerfilEmpresa)
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InsertarActivosSincronizados");
            db.AddInParameter(dbCommand, "@idArchivo", DbType.Int32, IdArchivo);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;


        }
        public List<ESincronizaActivos> ConsultaActivos()
        {

            List<ESincronizaActivos> eSincro = new List<ESincronizaActivos>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultacActivosaSincronizar");
            DbCommand.CommandTimeout = 3600;

            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    ESincronizaActivos eActivos = new ESincronizaActivos();
                    string numActiv = reader["NumeroActivo"].ToString();
                    string numEtiqueta = reader["PlacaActivo"].ToString();
                    string descripcion = reader["DescripcionCorta"].ToString();
                    int idEstado = Convert.ToInt32(reader["IdEstadoActivo"].ToString());
                    int idCategoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    int idUbicacion = Convert.ToInt32(reader["IdUbicacionA"].ToString());
                    int IdPerfilEmpresa = Convert.ToInt32(reader["IdPerfilEmpresa"].ToString());
                    string marca = reader["Marca"].ToString();
                    string modelo = reader["Modelo"].ToString();
                    decimal costo = Convert.ToDecimal(reader["CostoActivo"].ToString());

                    eActivos = new ESincronizaActivos(numActiv, numEtiqueta, descripcion, idEstado, idCategoria, idUbicacion, IdPerfilEmpresa,
                                                   marca, modelo, costo);
                    eSincro.Add(eActivos);
                }
            }

            return eSincro;
        }
        public string BorrarArchivo(int IdArchivo)
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("BorrarArchivo");
            db.AddInParameter(dbCommand, "@idArchivo", DbType.Int32, IdArchivo);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;


        }
        public string ActualizaArchivoEstado(int idArchivo, string estadoSicroniza)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizaArchivoEstado");
            db.AddInParameter(dbCommand, "@idArchivo", DbType.Int32, idArchivo);
            db.AddInParameter(dbCommand, "@EstadoSinc", DbType.String, estadoSicroniza);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }
        public string ObtenertipoMonedaporIdEmpresa(int IdPerfilEmpresa)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ObtenertipoMonedaporIdEmpresa");
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, IdPerfilEmpresa);

            db.AddOutParameter(dbCommand, "@respuesta", DbType.String, 10);

            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@respuesta").ToString();
            return Respuesta;
            
        }


        public List<ESincronizaActivos> SincronizarActivos(int idEmpresa, List<ESincronizaActivos> eSincronizaActivos)
        {
            var Respuesta = "";
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");


            for (int i = 0; i < eSincronizaActivos.Count; i++)
            {
                if (eSincronizaActivos[i].Costo =="")
                {
                    eSincronizaActivos[i].Costo = "0";
                }

                var dbCommand = db.GetStoredProcCommand("SincronizarActivos");

                db.AddInParameter(dbCommand, "@idPerfilEmpresa", DbType.Int32, idEmpresa);
                db.AddInParameter(dbCommand, "@Descripcion", DbType.String, eSincronizaActivos[i].Descripcion);
                db.AddInParameter(dbCommand, "@NumEtiqueta", DbType.String, eSincronizaActivos[i].NumEtiqueta);
                db.AddInParameter(dbCommand, "@Categoria", DbType.String, eSincronizaActivos[i].Categoria);
                db.AddInParameter(dbCommand, "@Estado", DbType.String, eSincronizaActivos[i].Estado);
                db.AddInParameter(dbCommand, "@Ubicacion", DbType.String, eSincronizaActivos[i].Ubicacion);
                db.AddInParameter(dbCommand, "@Marca", DbType.String, eSincronizaActivos[i].Marca);
                db.AddInParameter(dbCommand, "@Modelo", DbType.String, eSincronizaActivos[i].Modelo);
                db.AddInParameter(dbCommand, "@Serie", DbType.String, eSincronizaActivos[i].Serie);
                db.AddInParameter(dbCommand, "@Costo", DbType.Decimal, Decimal.Parse(eSincronizaActivos[i].Costo));
                db.AddInParameter(dbCommand, "@Factura", DbType.String, eSincronizaActivos[i].Factura);
                db.AddInParameter(dbCommand, "@FechaCompra", DbType.DateTime, eSincronizaActivos[i].FechaCompra);
                db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);

                dbCommand.CommandTimeout = 3600;
                db.ExecuteNonQuery(dbCommand);
                Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();

                if (Respuesta.Equals("Registrado"))
                {
                    eSincronizaActivos[i].EstadoSincronizacionArc = "sincronizado";
                }
                else if (Respuesta.Equals("YA SE ALCANZÓ LA CANTIDAD PERMITIDA DE ACTIVOS"))
                {
                    eSincronizaActivos[i].EstadoSincronizacionArc = "Ya supero el total de activos permitidos";
                }
                else if (Respuesta.Equals("Ya existe la placa") || Respuesta.Equals("El numero de placa del activo es obligatoria"))
                {
                    eSincronizaActivos[i].EstadoSincronizacionArc = "El numero de placa del activo es obligatoria";
                }
                else if (Respuesta.Equals("La descripcion del activo es obligatoria"))
                {
                    eSincronizaActivos[i].EstadoSincronizacionArc = "La descripcion del activo es obligatoria";
                }
                else if (Respuesta.Equals("La marca del activo es obligatoria"))
                {
                    eSincronizaActivos[i].EstadoSincronizacionArc = "La marca del activo es obligatoria";
                }
                else if (Respuesta.Equals("No se encontró la categoría del activo que quiere insertar")|| Respuesta.Equals("La categoria del activo es obligatoria"))
                {
                    eSincronizaActivos[i].EstadoSincronizacionArc = "No se encontró la categoría del activo que quiere insertar";
                }
                else if (Respuesta.Equals("No se encontró el estado del activo que quiere insertar")|| Respuesta.Equals("El estado del activo es obligatorio"))
                {
                    eSincronizaActivos[i].EstadoSincronizacionArc = "No se encontró el estado del activo que quiere insertar";
                }
                else if (Respuesta.Equals("No se encontró la ubicación del activo que quiere insertar")|| Respuesta.Equals("La ubicacion del activo es obligatoria"))
                {
                    eSincronizaActivos[i].EstadoSincronizacionArc = "No se encontró la ubicación del activo que quiere insertar";
                }
                else
                {
                    eSincronizaActivos[i].EstadoSincronizacionArc = "nosincronizado";
                }
            }

            return eSincronizaActivos;
        }

    }
}
