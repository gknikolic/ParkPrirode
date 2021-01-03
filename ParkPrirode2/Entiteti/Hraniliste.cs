using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.Entiteti
{
    public class Hraniliste
    {
        public virtual int Broj { get; set; }
        public virtual int PocetniMesec { get; set; }
        public virtual int KrajnjiMesec { get; set; }

        public virtual StalnaZastita Oblast { get; set; }

        public virtual IList<PrimeceneNaHranilistima> HraneSeZivotinje { get; set; }

        public Hraniliste()
        {
            HraneSeZivotinje = new List<PrimeceneNaHranilistima>();
        }
    }
}
