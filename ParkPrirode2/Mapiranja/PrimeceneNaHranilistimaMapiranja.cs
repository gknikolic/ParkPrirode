using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode2.Entiteti;
using FluentNHibernate.Mapping;

namespace ParkPrirode2.Mapiranja
{
    class PrimeceneNaHranilistimaMapiranja:ClassMap<PrimeceneNaHranilistima>
    {
        public PrimeceneNaHranilistimaMapiranja()
        {
            Table("PRIMECENE_NA_HRANILISTIMA");

            CompositeId(x => x.Id)
                .KeyReference(x => x.Hraniliste, "HRANILISTE_BROJ")
                .KeyReference(x => x.Zivotinja, "ZIVOTINJA_ID");

            Map(x => x.UocenaPrviPut).Column("UOCENA_PRVI_PUT");
        }

    }
}
