using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode2.DTO
{
    public class RadnikView
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string TipRadnika { get; set; }
    }

    public class RadnikBasic
    {
        public int Id { get; set; }
        public string MBR { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string TipRadnika { get; set; }
        

    }

    public class StalniRadnikView
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string TipRadnika { get; set; }
        public int BrRadneKnjizice { get; set; }
    }
    public class StalniRadnikBasic : RadnikBasic
    {
        public string BrLicneKarte { get; set; }
        public string MestoIzdavanjaLicneKarte { get; set; }
        public int BrRadneKnjizice { get; set; }


    }
}
