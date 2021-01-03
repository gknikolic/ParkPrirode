using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.Entiteti
{
    public class Zivotinja
    {
        public virtual int Id { get; set; }
        public virtual string LatinskiNaziv{ get; set; }
        public virtual string LokalniNaziv { get; set; }
        public virtual int SBP{ get; set; }
        public virtual int PticaSelicaFleg { get; protected set; }

        public virtual Oblast Oblast { get; set; }


        public virtual IList<PrimeceneNaHranilistima> HraniSeNaHranilistima { get; set; }

    }

    public class PticaSelica: Zivotinja
    {
        public virtual IList<PrimeceneUZemljama> Zemlje { get; set; }

        public PticaSelica()
        {
            Zemlje = new List<PrimeceneUZemljama>();
        }
    }
}
