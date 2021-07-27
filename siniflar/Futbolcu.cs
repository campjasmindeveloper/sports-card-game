using kartoyun.soyut_sinif;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyun.siniflar
{
    public class Futbolcu : Sporcu
    {
        private int penalti;
        private int serbestAtis;
        private int kaleciKarsiKarsiya;
        private bool kartkullanildimi =false;

        public int _penalti { get { return penalti; } set { penalti = value; } } //getter setter
        public int _serbestAtis { get { return serbestAtis; } set { serbestAtis = value; } }
        public int _kaleciKarsiKarsiya { get { return kaleciKarsiKarsiya; } set { kaleciKarsiKarsiya = value; } }
        public bool _kartkullanildimi { get { return kartkullanildimi; } set { kartkullanildimi = value; } }

        public Futbolcu() // constructor
        {

        }
        public Futbolcu(string isim,string takim,int penalti, int serbestAtis, int kaleciKarsiKarsiya)
        {
            base._sporcuIsim =isim; //C#'ta Super() metodu yerine geçer.
            base._sporcuTakim = takim;
            _penalti = penalti;
            _serbestAtis = serbestAtis;
            _kaleciKarsiKarsiya = kaleciKarsiKarsiya;
        }

        public override int sporcu_PuanGoster(int puan)
        {
            if (puan == 0)
            {
                return _penalti;
            }
            else if (puan == 1)
            {
                return _serbestAtis;
            }
            else if (puan == 2)
            {
                return _kaleciKarsiKarsiya;
            }
            else
            {
                return 0;
            }
        }

    }
}
