using kartoyun.siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyun.soyut_sinif
{
    public class Oyuncu
    {
        private int oyuncuID;
        private string oyuncuADI;
        private int oyuncuSKOR;
        public int _oyuncuID { get { return oyuncuID; } set { oyuncuID = value; } } // getter setter
        public string _oyuncuADI { get { return oyuncuADI; } set { oyuncuADI = value; } }
        public int _oyuncuSKOR { get { return oyuncuSKOR; } set { oyuncuSKOR = value; } }

        public List<Futbolcu> kartlist_futbol = new List<Futbolcu>();
        public List<Basketbolcu> kartlist_basket = new List<Basketbolcu>();
        public Oyuncu()
        {

        }
        public Oyuncu(int oyuncuID, string oyuncuADI, int oyuncuSKOR)
        {
            _oyuncuID = oyuncuID;
            _oyuncuADI = oyuncuADI;
            _oyuncuSKOR = oyuncuSKOR;
        }

        public int skorGoster()
        {
            return _oyuncuSKOR;
        }

        public virtual int kartsec()
        {
            return 0;
        }
    }
}
