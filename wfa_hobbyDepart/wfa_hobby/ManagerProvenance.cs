using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerProvenance: Manager// : = hétite de ce qui suit
    {
        public List<Provenance> ListerProvenance()
        {
            List<Provenance> maListe = new List<Provenance>();
            try
            {
                using (var maConnection = GetConnection())
                {
                    using (var maCommande = creerCommande("listerProvenances",null))
                    {
                        //maCommande.CommandType = System.Data.CommandType.StoredProcedure;
                        //maCommande.Connection.Open();
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
