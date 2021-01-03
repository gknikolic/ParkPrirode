using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode2.Entiteti;
using FluentNHibernate.Mapping;

namespace ParkPrirode2.Mapiranja
{
    class PrimeceneUZemljamaMapiranja:ClassMap<PrimeceneUZemljama>
    {
        public PrimeceneUZemljamaMapiranja()
        {
            Table("PRIMECENE_U_ZEMLJAMA");

            Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S16244.PRIMECENE_U_ZEMLJAMA_ID_SEQ");

            Map(x => x.NazivZemlje).Column("NAZIV_ZEMLJE");

            References(x => x.Zivotinja).Column("ZIVOTINJA_ID");

        }

    }
}
