using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode2.Entiteti;
using FluentNHibernate.Mapping;

namespace ParkPrirode2.Mapiranja
{
    class RadnikMapiranja:ClassMap<Radnik>
    {
        public RadnikMapiranja()
        {
            Table("RADNIK");


            DiscriminateSubClassesOnColumn("TIP_RADNIKA");

            Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S16244.RADNIK_ID_SEQ");

            Map(x => x.MBR).Column("MBR");
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Adresa).Column("ADRESA");
            //Map(x => x.TipRadnika).Column("TIP_RADNIKA");
           

            References(x => x.RadniNaOblasti).Column("OBLAST_ID");



        }
    }

    class StalniRadnikMapiranja : SubclassMap<StalniRadnik>
    {
        public StalniRadnikMapiranja()
        {
            DiscriminatorValue("Stalni radnik");

            Map(x => x.BrLicneKarte, "BR_LICNE_KARTE");
            Map(x => x.MestoIzdavanjaLk, "MESTO_IZDAVANJA_LK");
            Map(x => x.BrRadneKnjizice, "BR_RADNE_KNJIZICE");
        }
    }

    class VolonterMapiranja : SubclassMap<Volonter>
    {
        public VolonterMapiranja()
        {
            DiscriminatorValue("Volonter");
        }
    }

}
