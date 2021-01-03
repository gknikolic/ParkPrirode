using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode2.Entiteti;
using FluentNHibernate.Mapping;

namespace ParkPrirode2.Mapiranja
{
    class BiljkaMapiranja: ClassMap<Biljka>
    {
        public BiljkaMapiranja()
        {
            Table("BILJKA");

            DiscriminateSubClassesOnColumn("POSEBNA_ZASTITA", 0);

            Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S16244.BILJKA_ID_SEQ");

            Map(x => x.LatinskiNaziv).Column("LATINSKI_NAZIV");
            Map(x => x.LokalniNaziv).Column("LOKALNI_NAZIV");
            /* Map(x => x.BrojOdluke).Column("BROJ_ODLUKE");
             Map(x => x.DatumPocetka).Column("DATUM_POCETKA");*/
            //Map(x => x.PosebnaZastita).Column("POSEBNA_ZASTITA");


            HasManyToMany(x => x.Oblasti) // za mapiranja has many to many bez dodatnih svojstava
                 .Table("U_OBLASTI_BILJKE")
                 .ParentKeyColumn("BILJKA_ID")
                 .ChildKeyColumn("OBLAST_ID");
                 //.Cascade.All();

        }


    }

    class BiljkaSaPosebnomZastitomMapiranja:SubclassMap<BiljkaSaPosebnomZastitom>
    {
        public BiljkaSaPosebnomZastitomMapiranja()
        {
            DiscriminatorValue(1);
            Map(x => x.BrojOdluke).Column("BROJ_ODLUKE");
            Map(x => x.DatumPocetka).Column("DATUM_POCETKA");
        }
    }
}
