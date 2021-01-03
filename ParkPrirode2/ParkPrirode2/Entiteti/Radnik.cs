using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.Entiteti
{
    public abstract class Radnik
    {
        public virtual int Id { get; set; }
        public virtual string MBR { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string TipRadnika { get; set; }
     

        public virtual Oblast RadniNaOblasti { get; set;}


    }

    public class StalniRadnik : Radnik
    {
        public virtual string BrLicneKarte { get; set; }
        public virtual string MestoIzdavanjaLk { get; set; }
        public virtual int BrRadneKnjizice { get; set; }
    }

    public class Volonter : Radnik
    {
    }



}
