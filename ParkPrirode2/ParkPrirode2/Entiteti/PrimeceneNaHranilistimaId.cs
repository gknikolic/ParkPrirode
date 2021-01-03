using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.Entiteti
{
    public class PrimeceneNaHranilistimaId
    {
        public virtual Hraniliste Hraniliste { get; set; }
        public virtual Zivotinja Zivotinja { get; set; }


        public override bool Equals(object obj) // da bi ovo radilo kao kompozitni kljuc mora da overajdujemo equals i gethashcode obj jeobjekat sa kojim se poredi nas ovaj objekat
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(PrimeceneNaHranilistimaId))
                return false;

            PrimeceneNaHranilistimaId recievedObject = (PrimeceneNaHranilistimaId)obj;

            if ((Hraniliste.Broj == recievedObject.Hraniliste.Broj) &&
                (Zivotinja.Id == recievedObject.Zivotinja.Id))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
