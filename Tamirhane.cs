using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
   public class Tamirhane
   {
       AracKaporta kaporta;
       AracElektrik elektrik;
       AracLastik lastik;
       AracMotor motor;
        string durum,plaka;
        string usta;
        int bolum=0;
       public Tamirhane() { }
       public Tamirhane(string plaka,int bolum)
        {
            //Kaportaya giden aracı oluştur
            if (bolum == 0)
            {
                kaporta = new AracKaporta(plaka, bolum);
                
            }//Motora giden aracı oluştur
            else if (bolum == 1)
            {
                motor = new AracMotor(plaka, bolum);

            }//Elektriğe giden aracı oluştur
            else if (bolum == 2)
            {
                elektrik = new AracElektrik(plaka, bolum);
                
            }// Lastiğe giden aracı oluştur
            else if (bolum == 3)
            {
                lastik = new AracLastik(plaka, bolum);
                
            }
            this.bolum = bolum;
            this.plaka = plaka;
            durum = "Tamire Başlanmadı";
            usta = "Unknown";
        }
        public void setUsta(string usta)
        {
            this.usta = usta;
        }
        public string getUsta()
        {
            return usta;

        }
        public void setDurum(string durum)
        {
            this.durum = durum;
        }
        public string getDurum()
        {
            return durum;

        }
        public string getModel()
        {
            if (bolum == 0)
            {
                return kaporta.model;

            }
            else if (bolum == 1)
            {
                return motor.model;
            }
            else if (bolum == 2)
            {
                return elektrik.model;
            }
            else if (bolum == 3)
            {
                return lastik.model;
            }
            return null;
        }


        public string getMarka()
        {
            if (bolum == 0)
            {
                return kaporta.marka;

            }
            else if (bolum == 1)
            {
                return motor.marka;
            }
            else if (bolum == 2)
            {
                return elektrik.marka;
            }
            else if (bolum == 3)
            {
                return lastik.marka;
            }
            return null;
        }


        public int getYil()
        {
            if (bolum == 0)
            {
                return kaporta.yil;

            }
            else if (bolum == 1)
            {
                return motor.yil;
            }
            else if (bolum == 2)
            {
                return elektrik.yil;
            }
            else if (bolum == 3)
            {
                return lastik.yil;
                
            }
            return 0;
        }
        public List<Parca> getDegisenList()
        {
            if (bolum == 0)
            {
                return kaporta.getDeg();

            }
            else if (bolum == 1)
            {
                return motor.getDeg();
            }
            else if (bolum == 2)
            {
                return elektrik.getDeg();
            }
            else if (bolum == 3)
            {
                return lastik.getDeg();

            }
            return null;
        }




    }
}
