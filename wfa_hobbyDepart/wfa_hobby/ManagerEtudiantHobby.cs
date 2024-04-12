using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiantHobby : Manager
    {
        public int CompterNombreDeHobby(int no_etudiant)
        {
            try
            {
                int nombreHobby = 0;
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters = definirParametreCompter(no_etudiant);
                using (var maConnection = GetConnection())
                {
                    using (var maCommande = creerCommande("CompterHobby", parameters))
                    {
                        nombreHobby = (int)maCommande.ExecuteScalar();

                    }
                }
                return nombreHobby;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private List<SqlParameter> definirParametreCompter(int no_etudiant)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@no_etudiant", no_etudiant == 0 ? DBNull.Value : no_etudiant));
            return sqlParameters;
        }
        public int AjouterEtudiantHobby(int no_etudiants, int no_hobby)
        {
            int nombreDeLigneAffectee = 0;
            try
            {

                using (var maConnection = GetConnection())
                {
                    using (var maCommande = new SqlCommand("AjouterEtudiantHobby", maConnection))
                    {
                        //commandtype
                        //paramètre
                        //ouvrir connection
                        //exec la commande
                        maCommande.CommandType = System.Data.CommandType.StoredProcedure;
                        List<SqlParameter> mesParametre;
                        mesParametre = definirParametreAjout(no_etudiants, no_hobby);
                        maCommande.Parameters.AddRange(mesParametre.ToArray());
                        maCommande.Connection.Open();
                        nombreDeLigneAffectee = maCommande.ExecuteNonQuery();
                    }
                }
                return nombreDeLigneAffectee;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception("Cet étudiant ne peut pas être lié à ce hobby à cause des contraintes de la base de données");
                }

                else

                    throw new Exception("Cet étudiant ne peut pas être lié à ce hobby à cause des contraintes de la base de données");

            }
            catch (Exception ex)
            {

                throw new Exception("Cet étudiant ne peut pas être lié à ce hobby à cause des contraintes de la base de données");
            }
        }
        private List<SqlParameter> definirParametreAjout(int no_etudiants, int no_hobby)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@no_etudiant", no_etudiants == 0 ? DBNull.Value : no_etudiants));
            sqlParameters.Add(new SqlParameter("@no_hobby", no_hobby == 0 ? DBNull.Value : no_hobby));
            return sqlParameters;
        }
    }
}
