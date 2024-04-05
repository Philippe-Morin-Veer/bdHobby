using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerHobby : Manager
    {
        public List<Hobby> ListerHobby()
        {
            List<Hobby> hobbys = new List<Hobby>();
            try
            {
                using (var maConnection = GetConnection())
                {
                    using (var maCommande = creerCommande("ListerHobby", null))
                    {
                        using (var mondataReader = maCommande.ExecuteReader())
                        {
                            while (mondataReader.Read())
                            {
                                Hobby hobby = new Hobby();
                                hobby.No_Hobby = (int)mondataReader["no_hobby"];
                                hobby.LeHobby = mondataReader["hobby"].ToString();
                                hobbys.Add(hobby);
                            }
                        }
                    }
                    return hobbys;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
