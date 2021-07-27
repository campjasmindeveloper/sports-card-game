using kartoyun.soyut_sinif;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyun.siniflar
{
    public class Kullanici:Oyuncu
    {
        private string oyuncuisim="Kullanıcı";
        private int oyuncuId = 0;
        private int oyuncuskor = 0;

        public string _oyuncuisim { get { return oyuncuisim; } set { oyuncuisim = base._oyuncuADI; } }
        public int _oyuncuId { get { return oyuncuId; } set { oyuncuId = base._oyuncuID; } }
        public int _oyuncuskor { get { return oyuncuskor; } set { oyuncuskor = base._oyuncuSKOR; } }

        private static Kullanici _nesne { get; set; }
        private Kullanici(int ID, string ADI, int SKOR)
        {
            base._oyuncuID = ID;
            base._oyuncuADI = ADI;
            base._oyuncuSKOR = SKOR;
        }      

        public static Kullanici nesnever()
        {
            if (_nesne == null)
            {
                _nesne = new Kullanici(1,"Kullanıcı",0);
            }
            return _nesne;
        }    

        public override int kartsec()
        {
            return base.kartsec();           
        }
    }
}
