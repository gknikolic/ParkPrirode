using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.DTO
{
    public class ZivotinjaView
    {
        public int Id { get; set; }
        public string LatinskiNaziv { get; set; }
        public string LokalniNaziv { get; set; }
        public int SBP { get; set; }
        public int PticaSelicaFleg { get; set; }
    }
    public class ZivotinjaBasic
    {
        public int Id { get; set; }
        public string LatinskiNaziv { get; set; }
        public string LokalniNaziv { get; set; }
        public int SBP { get; set; }
        public int PticaSelicaFleg { get; set; }
    }
}
