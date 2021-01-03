using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.Entiteti
{
    public class Biljka
    {
        public virtual int  Id{ get; set; }
        public virtual string LatinskiNaziv { get; set; }
        public virtual string LokalniNaziv { get; set; }
      /*  public virtual string BrojOdluke { get; set; }
        public virtual DateTime DatumPocetka { get; set; }*/
        public virtual int PosebnaZastita { get; set; }

        public virtual IList<Oblast> Oblasti { get; set; }

        public Biljka()
        {
            Oblasti = new List<Oblast>();
        }

    }

    public class BiljkaSaPosebnomZastitom:Biljka
    {
        public virtual string BrojOdluke { get; set; }
        public virtual DateTime DatumPocetka { get; set; }
    }
}
