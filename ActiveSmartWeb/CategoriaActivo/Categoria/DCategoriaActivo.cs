using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.CategoriaActivo.Categoria
{
    public class DCategoriaActivo : ICategoriaActivo
    {
        public List<ECategoriaActivo> ConsultaCategoriaActivos()
        {
            List<ECategoriaActivo> eCategoriaActivos = new List<ECategoriaActivo>();

            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaCategoriaActivo");          
            DbCommand.CommandTimeout = 3600;
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    ECategoriaActivo eCategoria = new ECategoriaActivo();
                    int idCategoriaActivos = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    string nombreCartegoria = reader["NombreCategoria"].ToString();
                    string descripcionCategoria = reader["DescripcionCategoria"].ToString();

                    eCategoria = new ECategoriaActivo(idCategoriaActivos, nombreCartegoria, descripcionCategoria);
                    eCategoriaActivos.Add(eCategoria);
                }
            }
            return eCategoriaActivos;
        }
        public string ConsultaDescCategoriaX(int id)
        {
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultaCategoriaActivo");
            DbCommand.CommandTimeout = 3600;

            string descripcionCategoria = "";
            using (IDataReader reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                  
                    int idCategoriaActivos = Convert.ToInt32(reader["IdCategoriaActivo"].ToString());
                    if (idCategoriaActivos==id)
                    {
                        descripcionCategoria = reader["DescripcionCategoria"].ToString();
                    }
                  
                }
            }
            return descripcionCategoria;
        }
    }
}