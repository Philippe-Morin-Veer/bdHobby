using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerProvenance
    {
        public List<Provenance> ListerProvenance()
        {
            List<Provenance> maListe = new List<Provenance>();
            try
            {
                using (var maConnection = new SqlConnection(Properties.Settings.Default.maConnectionString))
                {
                    using (var maCommande = new SqlCommand("listerProvenances", maConnection))
                    {
                        maCommande.CommandType = System.Data.CommandType.StoredProcedure;
                        maCommande.Connection = maConnection;
                        using (var monDataReader = maCommande.ExecuteReader())
                        {
                            while (monDataReader.Read())
                            {
                                Provenance provenance = new Provenance();
                                provenance.No_provenance = (int)monDataReader["no_provenance"];
                                provenance.LaProvenance = monDataReader["Provenance"].ToString();
                                maListe.Add(provenance);
                            }
                        }

                    }
                    return maListe;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
