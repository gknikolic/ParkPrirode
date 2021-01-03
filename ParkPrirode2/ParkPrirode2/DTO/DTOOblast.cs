using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.DTO
{
    public class OblastView
    {
        public int IdOblasti { get; set; }
        public string NazivOblasti { get; set; }
        public int Povrsina { get; set; }
        public string TipZastite { get; set; }
        public int BrojRadnika { get; set; }
        public int BrojZivotinja { get; set; }
        public int BrojBiljaka { get; set; }
        public OblastView(int id,string naziv,int povrsina,int rad,int ziv,int bilj,string tipZastite)
        {
            this.IdOblasti = id;
            this.NazivOblasti = naziv;
            this.Povrsina = povrsina;
            this.BrojRadnika = rad;
            this.BrojZivotinja = ziv;
            this.BrojBiljaka = bilj;
            this.TipZastite = tipZastite;
        }


    }

    public class OblastBasic
    {
        public int OblastId { get; set; }
        public string JedinstvenoIme { get; set; }
        public int Povrsina { get; set; }
       
        public string TipZastite { get; set; }
    }

   
}
