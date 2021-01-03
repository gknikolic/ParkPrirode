using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode2.Entiteti;
using FluentNHibernate.Mapping;

namespace ParkPrirode2.Mapiranja
{
    class OblastMapiranja:ClassMap<Oblast>
    {
        public OblastMapiranja()
        {
            Table("OBLAST");

            DiscriminateSubClassesOnColumn("TIP_ZASTITE");

            Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S16244.OBLAST_ID_SEQ");

            Map(x => x.JedinstvenoIme).Column("JEDINSTVENO_IME");
            //Map(x => x.TipZastite).Column("TIP_ZASTITE");
            Map(x => x.Povrsina).Column("POVRSINA");

            HasMany(x => x.RadniziUOblasti)
                .KeyColumn("OBLAST_ID")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.Zivotinje)
                .KeyColumn("OBLAST_ID")
                .Inverse()
                .Cascade.All();


            HasManyToMany(x => x.Biljke) // za mapiranja has many to many bez dodatnih svojstava
                .Table("U_OBLASTI_BILJKE")
                .ParentKeyColumn("OBLAST_ID")
                .ChildKeyColumn("BILJKA_ID")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.OpstineUOblasti).KeyColumn("OBLAST_ID").Inverse().Cascade.All();

        }

    }

    class StalnaZastitaMapiranja : SubclassMap<StalnaZastita>
    {
        public StalnaZastitaMapiranja()
        {
            DiscriminatorValue("Stalna zastita");

            HasMany(x => x.Hranilista)
                .KeyColumn("OBLAST_ID")
                .Inverse()
                .Cascade.All();

        }
    }

    class PovremeneIntervencijeMapiranja : SubclassMap<PovremeneIntervencije>
    {
        public PovremeneIntervencijeMapiranja()
        {
            DiscriminatorValue("Povremena intervencija");

            

        }
    }

    class MonitoringMapiranja : SubclassMap<Monitoring>
    {
        public MonitoringMapiranja()
        {
            DiscriminatorValue("Monitoring");

           

        }
    }
}
