using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.VisorActivos.VisorActivos
{
    public class DVisorActivo : IVisorActivo
    {
        public List<EVisorActivo> ObtenerActivoPorNumero(string numActivo, int idPerfilEmpresa)
        {
            List<EVisorActivo> eActivos = new List<EVisorActivo>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var DbCommand = Db.GetStoredProcCommand("Visor_ObtenerActivoPorNumero");
            Db.AddInParameter(DbCommand, "@NumeroActivo", DbType.String, numActivo);
            Db.AddInParameter(DbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EVisorActivo eActivosA = new EVisorActivo();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string serie = reader["Serie"].ToString();
                    string descripcionCorta = reader["DescripcionCorta"].ToString();
                    string descripcionLarga = reader["Descripcion"].ToString();
                    string categoria = reader["Categoria"].ToString();
                    string estado = reader["Estado"].ToString();
                    string marca = reader["Marca"].ToString();
                    string modelo = reader["Modelo"].ToString();
                    string ubicacionA = reader["UbicacionA"].ToString();
                    string ubicacionB = reader["UbicacionB"].ToString();
                    string ubicacionC = reader["UbicacionC"].ToString();
                    string ubicacionD = reader["UbicacionD"].ToString();
                    string observaciones = reader["Observaciones"].ToString();

                    eActivosA = new EVisorActivo(
                        idActivo,
                        numeroActivo,
                        placaActivo,
                        serie,
                        descripcionCorta,
                        descripcionLarga,
                        categoria,
                        estado,
                        marca,
                        modelo,
                        ubicacionA,
                        ubicacionB,
                        ubicacionC,
                        ubicacionD,
                        observaciones
                        );
                    eActivos.Add(eActivosA);
                }
            }
            return eActivos;
        }

       

        public List<EVisorActivo> ObtenerActivoPorPlaca(string numPlaca, int idPerfilEmpresa)
        {
            List<EVisorActivo> eActivos = new List<EVisorActivo>();
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionStringPro");
            var DbCommand = Db.GetStoredProcCommand("Visor_ObtenerActivoPorPlaca");
            Db.AddInParameter(DbCommand, "@PlacaActivo", DbType.String, numPlaca);
            Db.AddInParameter(DbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    EVisorActivo eActivosA = new EVisorActivo();
                    int idActivo = Convert.ToInt32(reader["IdActivo"].ToString());
                    string numeroActivo = reader["NumeroActivo"].ToString();
                    string placaActivo = reader["PlacaActivo"].ToString();
                    string serie = reader["Serie"].ToString();
                    string descripcionCorta = reader["DescripcionCorta"].ToString();
                    string descripcionLarga = reader["Descripcion"].ToString();
                    string categoria = reader["Categoria"].ToString();
                    string estado = reader["Estado"].ToString();
                    string marca = reader["Marca"].ToString();
                    string modelo = reader["Modelo"].ToString();
                    string ubicacionA = reader["UbicacionA"].ToString();
                    string ubicacionB = reader["UbicacionB"].ToString();
                    string ubicacionC = reader["UbicacionC"].ToString();
                    string ubicacionD = reader["UbicacionD"].ToString();
                    string observaciones = reader["Observaciones"].ToString();

                    eActivosA = new EVisorActivo(
                        idActivo,
                        numeroActivo,
                        placaActivo,
                        serie,
                        descripcionCorta,
                        descripcionLarga,
                        categoria,
                        estado,
                        marca,
                        modelo,
                        ubicacionA,
                        ubicacionB,
                        ubicacionC,
                        ubicacionD,
                        observaciones
                        );
                    eActivos.Add(eActivosA);
                }
            }
            return eActivos;
        }

     
    }
}