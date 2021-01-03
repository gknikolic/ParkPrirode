using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.DTO
{
    public class BiljkaView
    {
        public int Id { get; set; }
        public string LatinskiNaziv { get; set; }
        public string LokalniNaziv { get; set; }
        public string PosebnaZastita { get; set; }
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
