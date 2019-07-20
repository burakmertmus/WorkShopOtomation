using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace $safeprojectname$
{
    public class Motor:Tamirhane
    {
        private string plaka;
        public  List<Parca> degisenList;
        List<Parca> boyananList;
        public Motor(string plaka, int bolum)
            : base(plaka, bolum)
        {
            this.plaka = plaka;
            degisenList = new List<Parca>();
            boyananList = new List<Parca>();
        }
        public Motor() { }
        
       public List<Parca> getBoyanan()
        {
            //veri Tabanından gelecek
            return boyananList;
        }
        public List<Parca> getDegisen()
        {


            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=BILGMERTMUS\\SQLEXPRESS;Initial Catalog=car_company;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select *From dbo.islemTablo where plaka='" + plaka + "' and bolum=1 ";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Parca parca = new Parca();
                parca.setIsim(Convert.ToString(dr["degisenParca"]));
                parca.setFiyat(Convert.ToInt16(dr["odenenPara"]) * 8 / 10);
                parca.setIscilik(Convert.ToInt16(dr["odenenPara"]) * 2 / 10);
                degisenList.Add(parca);
            }
            baglanti.Close();

            return degisenList;
        }
    }
}
