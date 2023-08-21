using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneSistemiProjesi
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-KQHA9KT;Initial Catalog=HastaneSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
