using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class sqlbaglantisi // sınıfımın adı
    {
        public SqlConnection baglanti() //metodumun adı
        {
            SqlConnection baglan = new SqlConnection("Data Source=ebrar\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            // baglan'da sqlconnection sınıfından türettiğim ve benim baglantımı tutan nesnenin adı
            baglan.Open();
            return baglan;
            //geriye dönecek olan değeri tutan değer
        }

    }
}
