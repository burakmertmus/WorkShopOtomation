using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
     public class Parca
    {
        //sarmalama
        private string isim;
        private float fiyat, iscilik;
        public Parca() { }
        public Parca(string isim, float fiyat, float iscilik)
        {
            this.isim = isim;
            this.fiyat = fiyat;
            this.iscilik= iscilik;
        }
        public void setIsim(string isim)
        {
            this.isim=isim;
        }
        public string getIsim()
        {
            return isim;
        }
        public void setFiyat(float fiyat)
        {
            this.fiyat = fiyat;
        }
        public float getFiyat()
        {
            return fiyat;
        }
        public void setIscilik(float iscilik)
        {
            this.iscilik = iscilik;
        }
        public float getIscilik()
        {
            return iscilik;
        }
    }
}
