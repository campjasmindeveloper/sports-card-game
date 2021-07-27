using kartoyun.soyut_sinif;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyun.siniflar
{
    public class Bilgisayar:Oyuncu
    {
        Random random = new Random();

        private string oyuncuisim="Bilgisayar";
        private int oyuncuId=0;
        private int oyuncuskor=0;

        public string _oyuncuisim { get { return oyuncuisim; } set { oyuncuisim = base._oyuncuADI; } }
        public int _oyuncuId { get { return oyuncuId; } set { oyuncuId = base._oyuncuID; } }
        public int _oyuncuskor { get { return oyuncuskor; } set { oyuncuskor = base._oyuncuSKOR; } }

        private static Bilgisayar _nesne { get; set; }
        private Bilgisayar(int ID, string ADI, int SKOR)
        {
            base._oyuncuID = ID;
            base._oyuncuADI = ADI;
            base._oyuncuSKOR = SKOR;
        }
        public static Bilgisayar nesnever()
        {
            if (_nesne == null)
            {
                _nesne = new Bilgisayar(1,"Bilgisayar",0);
            }
            return _nesne;
        }       

        public override int kartsec()
        {
            int pcsayi;
            for (int i = 0; ; i++)
            {
                pcsayi = random.Next(0, 4);
                if (kartlist_basket[pcsayi]._kartkullanildimi == false || kartlist_futbol[pcsayi]._kartkullanildimi == false)
                {
                    break;
                }
            }

            return pcsayi;
        }

    }
}
