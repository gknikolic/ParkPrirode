using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode2.Entiteti;
using FluentNHibernate.Mapping;

namespace ParkPrirode2.Mapiranja
{
    class HranilisteMapiranja:ClassMap<Hraniliste>
    {
        public HranilisteMapiranja()
        {
            Table("HRANILISTE");

            Id(x => x.Broj).Column("BROJ").GeneratedBy.SequenceIdentity("S16244.HRANILISTE_BROJ_SEQ");

            Map(x => x.PocetniMesec).Column("POCETNI_MESEC");
            Map(x => x.KrajnjiMesec).Column("KRAJNJI_MESEC");

            References(x => x.Oblast).Column("OBLAST_ID");

            HasMany(x => x.HraneSeZivotinje).KeyColumn("HRANILISTE_BROJ").Cascade.All().Inverse();

        }
    }
}
