using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.DTO
{
    public class HranilisteBasic
    {
        public int Broj { get; set; }
        public int PocetniMesec { get; set; }
        public int KrajnjiMesec { get; set; }
    }

    public class HranilisteView
    {
        public int Broj { get; set; }
        public int PocetniMesec { get; set; }
        public int KrajnjiMesec { get; set; }
        public string PripadaOblasti { get; set; }

    }
}

