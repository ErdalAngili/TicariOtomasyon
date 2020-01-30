using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Common.Baglanti
{
    public class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-IJE0L8N;Initial Catalog=TicariOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
       
    }
}
