
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ActivosNoPistoleados.Encabezado
{
    public class DEncabezado
    {
        

        public List<EEncabezado> ConsultarTomaFisica(int idPerfilActive, DateTime fechaInicial, DateTime fechaFinal)
        {
            List<EEncabezado> eTomasFisicas = new List<EEncabezado>();
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
                    EEncabezado eTomaFisica = new EEncabezado();
                    int idTomaFisica = Convert.ToInt32(reader["IdTomaFisica"].ToString());
                    string nombre = reader["NombreTomaFisica"].ToString();
                    string descripcion = reader["DescripcionTomaFisica"].ToString();
                    string fechaInicialC = reader["FechaInicio"].ToString();
                    string fechaFinalC = reader["FechaFinal"].ToString();
                    int categoria = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    string nombreCategoria = reader["NombreCategoria"].ToString();
                    int cantidadActivos = Convert.ToInt32(reader["CantidadActivos"].ToString());
                    string nombreUsuario = reader["NombreUsuario"].ToString();
                    eTomaFisica = new EEncabezado(idTomaFisica, nombre, descripcion, DateTime.Parse(fechaInicialC),
                        DateTime.Parse(fechaFinalC), categoria, nombreCategoria, cantidadActivos, nombreUsuario);
                    eTomasFisicas.Add(eTomaFisica);
                }
            }

            return eTomasFisicas;
        }

      
    }
}