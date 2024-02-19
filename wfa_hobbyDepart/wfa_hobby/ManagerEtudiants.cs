using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiants
    {
        public int AjouterEtudiants(Etudiants etudiants)
        {
         
            int nombreDeLigneAffectee = 0;
            try
            {
                using (var maConnection = new SqlConnection(Properties.Settings.Default.maConnectionString))
                {
                    using (var maCommande = new SqlCommand("ajouterEtudiant",maConnection))
                    {
                        //commandtype
                        //paramètre
                        //ouvrir connection
                        //exec la commande
                        maCommande.CommandType = System.Data.CommandType.StoredProcedure;
                        maCommande.Parameters.Add(new SqlParameter("@Prenom", etudiants.Prenom == string.Empty? DBNull.Value: etudiants.Prenom));
                        maCommande.Parameters.Add(new SqlParameter("@Nom", etudiants.Nom == string.Empty ? DBNull.Value : etudiants.Nom));
                        maCommande.Parameters.Add(new SqlParameter("Cellulaire", etudiants.Cellulaire == string.Empty ? DBNull.Value : etudiants.Cellulaire ));
                        maCommande.Parameters.Add(new SqlParameter("@Humour", etudiants.Humour == 0 ? DBNull.Value : etudiants.Humour));
                        maCommande.Parameters.Add(new SqlParameter("@No_Provenance", etudiants.No_provenance == 0 ? DBNull.Value : etudiants.No_provenance));
                        maCommande.Connection.Open();
                        nombreDeLigneAffectee= maCommande.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return nombreDeLigneAffectee;
        }
    }
}
