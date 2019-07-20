using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class LastikParca
    {
       
            //sarmalama
            private string isim;
            private float fiyat;
            private int adet;
            LastikParca(string isim,  int adet,float fiyat)
            {
                this.isim = isim;
                this.fiyat = fiyat;
                this.adet = adet;
            }
            public void setIsim(string isim)
            {
                this.isim = isim;
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
            public void setAdet(int adet)
            {
                this.adet = adet;
            }
            public float getAdet()
            {
                return adet;
            }
        
    }
}
