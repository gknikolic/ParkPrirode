using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode2.Entiteti;
using FluentNHibernate.Mapping;

namespace ParkPrirode2.Mapiranja
{
    class OpstineUOblastiMapiranja:ClassMap<OpstineUOblasti>
    {
        public OpstineUOblastiMapiranja()
        {
            Table("OPSTINE_U_OBLASTI");

            Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S16244.OPSTINE_U_OBLASTI_ID_SEQ");

            Map(x => x.NazivOpstine).Column("NAZIV_OPSTINE");

            References(x => x.Oblast).Column("OBLAST_ID");
        }
    }
}
