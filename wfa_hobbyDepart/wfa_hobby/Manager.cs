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
    }
}
