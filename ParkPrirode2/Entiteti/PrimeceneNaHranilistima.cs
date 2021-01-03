using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.Entiteti
{
    public class PrimeceneNaHranilistima
    {
        public virtual PrimeceneNaHranilistimaId Id { get; set; }
        public virtual DateTime UocenaPrviPut { get; set; }

        public PrimeceneNaHranilistima()
        {
            Id = new PrimeceneNaHranilistimaId();
        }


    }
}
