using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.Entiteti
{
    public class OpstineUOblasti
    {
        public virtual int Id { get; set; }
        public virtual string NazivOpstine { get; set; }

        public virtual Oblast Oblast { get; set; }
    }
}
