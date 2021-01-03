using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode2.Entiteti;
using FluentNHibernate.Mapping;

namespace ParkPrirode2.Mapiranja
{
    class ZivotinjaMapiranja:ClassMap<Zivotinja>
    {
        public ZivotinjaMapiranja()
        {
            Table("ZIVOTINJE");

            DiscriminateSubClassesOnColumn("PTICA_SELICA_FLAG", 0);


            Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S16244.ZIVOTINJE_ID_SEQ");


            Map(x => x.LatinskiNaziv).Column("LATINSKI_NAZIV");
            Map(x => x.LokalniNaziv).Column("LOKALNI_NAZIV");
            Map(x => x.SBP).Column("SBP");
            //Map(x => x.PticaSelicaFleg).Column("PTICA_SELICA_FLAG");

            References(x => x.Oblast).Column("OBLAST_ID");

            HasMany(x => x.HraniSeNaHranilistima).KeyColumn("ZIVOTINJA_ID").Inverse().Cascade.All();

        }



    }

    class PticaSelicaMapiranja:SubclassMap<PticaSelica>
    {
        public PticaSelicaMapiranja()
        {
            DiscriminatorValue(1);

            HasMany(x => x.Zemlje).KeyColumn("ZIVOTINJA_ID").Inverse().Cascade.All();

        }

    }
}
