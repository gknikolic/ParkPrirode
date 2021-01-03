using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.Entiteti
{
    public class PrimeceneUZemljama
    {
        public virtual int Id { get; set; }
        public virtual string NazivZemlje { get; set; }

        public virtual Zivotinja Zivotinja { get; set; }

    }
}
