using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.Entiteti
{
    public abstract class Oblast
    {
        public virtual int Id { get; set; }
        public virtual string  JedinstvenoIme { get; set; }
        public virtual string TipZastite{ get; set; }
        public virtual int Povrsina { get; set; }


        public virtual IList<Radnik> RadniziUOblasti { get; set; }

        public virtual IList<Biljka> Biljke { get; set; }

        public virtual IList<Zivotinja> Zivotinje { get; set; }

        public virtual IList<OpstineUOblasti> OpstineUOblasti { get; set; }


        public Oblast()
        {
            RadniziUOblasti = new List<Radnik>();
            Zivotinje = new List<Zivotinja>();
            Biljke = new List<Biljka>();
            OpstineUOblasti = new List<OpstineUOblasti>();
        }



    }
    public class StalnaZastita : Oblast
    {
        public virtual IList<Hraniliste> Hranilista { get; set; }
        public StalnaZastita()
        {
            Hranilista = new List<Hraniliste>();
        }
    }

    public class PovremeneIntervencije : Oblast
    {
       
    }
    public class Monitoring : Oblast
    {
        
    }



}
