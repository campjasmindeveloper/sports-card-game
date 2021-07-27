using kartoyun.soyut_sinif;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyun.siniflar
{
    public class Basketbolcu : Sporcu
    {
        private int ikilik;
        private int ucluk;
        private int serbestAtis;
        private bool kartkullanildimi = false;

        public int _ikilik { get { return ikilik; } set { ikilik = value; } } // getter setter
        public int _ucluk { get { return ucluk; } set { ucluk = value; } }
        public int _serbestAtis { get { return serbestAtis; } set { serbestAtis = value; } }
        public bool _kartkullanildimi { get { return kartkullanildimi; } set { kartkullanildimi = value; } }
        public Basketbolcu() //Constructor
        {

        }
        public Basketbolcu(string isim,string takim,int ikilik, int ucluk, int serbestAtis)
        {
            base._sporcuIsim = isim; //C#'ta Super() metodu yerine geçer.
            base._sporcuTakim = takim;
            _ikilik = ikilik;
            _ucluk = ucluk;
            _serbestAtis = serbestAtis;
        }

        public override int sporcu_PuanGoster(int puan)
        {

            if (puan == 0)
            {
                return _ikilik;
            }
            else if (puan == 1)
            {
                return _ucluk;
            }
            else if (puan == 2)
            {
                return _serbestAtis;
            }
            else
            {
                return 0;
            }
        }

    }
}
