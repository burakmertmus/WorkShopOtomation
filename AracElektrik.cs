using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace $safeprojectname$
{
    class AracElektrik:Elektrik
    {
        public string plaka, marka, model;
        public int yil;
        private int bolum;
        

        public AracElektrik(string plaka, int bolum)
        {
            // TODO: Complete member initialization
            this.plaka = plaka;
            this.bolum = bolum;
            getDegerler();
        }

        
        public void getDegerler()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=BILGMERTMUS\\SQLEXPRESS;Initial Catalog=car_company;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select *From dbo.arac where plaka='" + plaka + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                marka = Convert.ToString(dr["marka"]);
                model = Convert.ToString(dr["model"]);
                yil = Convert.ToInt16(dr["yil"]);
            }
            baglanti.Close();
         

        }
        public List<Parca> getDeg()
        {
            Elektrik Elek = new Elektrik(plaka, bolum);
            return Elek.getDegisen();
        }
    }
}
