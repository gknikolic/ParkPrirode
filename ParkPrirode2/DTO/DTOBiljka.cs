using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode2.Entiteti;

namespace ParkPrirode2.DTO
{
    public class BiljkaView
    {
        public int Id { get; set; }
        public string LatinskiNaziv { get; set; }
        public string LokalniNaziv { get; set; }
        public string PosebnaZastita { get; set; }

        public BiljkaView()
        {

        }

        public BiljkaView(int Id, string LatinskiNaziv, string LokalniNaziv, string PosebnaZastita)
        {
            this.Id = Id;
            this.LatinskiNaziv = LatinskiNaziv;
            this.LokalniNaziv = LokalniNaziv;
            this.PosebnaZastita = PosebnaZastita;
        }
    }



    public class BiljkaPosebnaZastitaView
    {
        public int Id { get; set; }
        public string LatinskiNaziv { get; set; }
        public string LokalniNaziv { get; set; }
        public string BrojOdluke { get; set; }
        public string PosebnaZastita { get; set; }
    }


    public class BiljkaBasic
    {
        public int Id { get; set; }
        public string LatinskiNaziv { get; set; }
        public string LokalniNaziv { get; set; }
        public string PosebnaZastita { get; set; }
    }

    public class BiljkaPosebnaZastitaBasic:BiljkaBasic
    {
      
        public string BrojOdluke { get; set; }
        public DateTime DatumPocetka { get; set; }
    }
}
