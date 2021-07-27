using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyun.soyut_sinif
{
    public class Sporcu
    {
        public string _sporcuIsim { get; set; }
        public string _sporcuTakim { get; set; }
        public Sporcu()
        {

        }
        public Sporcu(string sporcuIsim = null, string sporcuTakim = null)
        {
            _sporcuIsim = sporcuIsim;
            _sporcuTakim = sporcuTakim;
        }

        public virtual int sporcu_PuanGoster(int puan)
        {
            return 0;
        }
    }
}
