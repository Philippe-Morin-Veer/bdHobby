using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiants:Manager
    {
        private List<SqlParameter>  definirParametreAjout (Etudiants etudiants)
        {
            List<SqlParameter> mesParametre = new List<SqlParameter>();
            mesParametre.Add(new SqlParameter("@Prenom", etudiants.Prenom == string.Empty ? DBNull.Value : etudiants.Prenom));
            mesParametre.Add(new SqlParameter("@Nom", etudiants.Nom == string.Empty ? DBNull.Value : etudiants.Nom));
            mesParametre.Add(new SqlParameter("Cellulaire", etudiants.Cellulaire == string.Empty ? DBNull.Value : etudiants.Cellulaire));
            mesParametre.Add(new SqlParameter("@Humour", etudiants.Humour == 0 ? DBNull.Value : etudiants.Humour));
            mesParametre.Add(new SqlParameter("@No_Provenance", etudiants.No_provenance == 0 ? DBNull.Value : etudiants.No_provenance));
            return mesParametre;
        }
        public int AjouterEtudiants(Etudiants etudiants)
        {
         
            int nombreDeLigneAffectee = 0;
            try
            {
                using (var maConnection = GetConnection())
                {
                    using (var maCommande = new SqlCommand("ajouterEtudiant",maConnection))
                    {
                        //commandtype
                        //paramètre
                        //ouvrir connection
                        //exec la commande
                        maCommande.CommandType = System.Data.CommandType.StoredProcedure;
                        List<SqlParameter> mesParametre;
                        mesParametre = definirParametreAjout(etudiants);
                        maCommande.Parameters.AddRange(mesParametre.ToArray());
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
        public List<Etudiants> ListerEtudiants()
        {
            List<Etudiants> etudiants = new List<Etudiants>();
            try
            {
                using (var maConnection = GetConnection())
                {
                    using (var maCommande = creerCommande("ListerEtudiants", null))
                    {
                        using (var mondataReader = maCommande.ExecuteReader())
                        {
                            while (mondataReader.Read())
                            {
                                Etudiants etudiant = new Etudiants();
                                etudiant.No_etudiants = (int)mondataReader["no_etudiants"];
                                if (mondataReader["Cellulaire"] == DBNull.Value)
                                {
                                    etudiant.Cellulaire = null;
                                }
                                else
                                {
                                    etudiant.Cellulaire = mondataReader["Cellulaire"].ToString();
                                }
                                etudiant.No_provenance = (int)mondataReader["no_provenance"];
                                etudiant.Prenom = mondataReader["prenom"].ToString();
                                etudiant.Nom = mondataReader["nom"].ToString();
                                etudiant.Humour = (int)mondataReader["humour"];
                                etudiants.Add(etudiant);
                                
                            }
                        }
                    }
                    return etudiants;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        

    }
}
