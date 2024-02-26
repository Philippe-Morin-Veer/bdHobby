using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class Manager
    {
        // protected signifie utilisable que par ses filles, sans new
        protected SqlConnection GetConnection()
        {
            var maConnection = new SqlConnection(Properties.Settings.Default.maConnectionString);
            return maConnection;
        }
        protected SqlCommand creerCommande(string nomProcedureStockee,List<SqlParameter> mesParamètreSql)
        {
            var maCommande = new SqlCommand(nomProcedureStockee, GetConnection());
            // definir le commandtype
            maCommande.CommandType = CommandType.StoredProcedure;
            //definir paramètre

            if (mesParamètreSql != null)
            {
            maCommande.Parameters.AddRange(mesParamètreSql.ToArray());
            }
            //ouvrir la connection avec la command
            maCommande.Connection.Open();
            return maCommande;
      }
    }
}
