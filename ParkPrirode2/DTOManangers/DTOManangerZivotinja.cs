using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode2.Entiteti;
using ParkPrirode2.DTO;
using NHibernate;
using NHibernate.Linq;

namespace ParkPrirode2.DTOManangers
{
    public class DTOManangerZivotinja
    {

        public static List<ZivotinjaView> VratiPticeNaHranilistuPrimecenaNakonPrikaz(int brojHranilista, DateTime d)
        {
            List<ZivotinjaView> zivotinje = new List<ZivotinjaView>();
            try
            {
                ISession s = DataLayer.GetSession();


                /*IEnumerable<Zivotinja> od = from o in s.Query<Zivotinja>()
                                            from g in o.HraniSeNaHranilistima
                                            where g.Id.Hraniliste.Broj == brojHranilista 
                                            select o;*/

                //IEnumerable<Zivotinja> od = from o in s.Query<PrimeceneNaHranilistima>()
                //                            where o.Id.Hraniliste.Broj == brojHranilista && o.UocenaPrviPut.Year > d.Year &&
                //                            o.UocenaPrviPut.Month > d.Month && o.UocenaPrviPut.Day > d.Day
                //                            select o.Id.Zivotinja;

                //comareTo za datum vraca -1, 0 ili 1 , a oduzima prvi od drugi

                //DateTime danas = DateTime.Now;
                //DateTime prekosutra = danas;
                //prekosutra = prekosutra.AddDays(3);
                //System.Windows.Forms.MessageBox.Show("danas je: " + danas.ToString() + "\nprekosutra je: " + prekosutra.ToString() +
                //    prekosutra.CompareTo(danas));


                IEnumerable<Zivotinja> od = from o in s.Query<Zivotinja>()
                                            from g in o.HraniSeNaHranilistima
                                            where g.Id.Hraniliste.Broj == brojHranilista &&
                                                g.UocenaPrviPut.CompareTo(d) >= 0
                                            select o;



                foreach (var i in od)
                {

                    if (i.GetType() == typeof(PticaSelica))
                        zivotinje.Add(new ZivotinjaView() { Id = i.Id, LatinskiNaziv = i.LatinskiNaziv, LokalniNaziv = i.LokalniNaziv, SBP = i.SBP, PticaSelicaFleg = 1 });

                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return zivotinje;


        }

        public static List<ZivotinjaView> VratiZivotinjeNaHranilistuPrimecenaNakonPrikaz(int brojHranilista, DateTime d)
        {
            List<ZivotinjaView> zivotinje = new List<ZivotinjaView>();
            try
            {
                ISession s = DataLayer.GetSession();


                /*IEnumerable<Zivotinja> od = from o in s.Query<Zivotinja>()
                                            from g in o.HraniSeNaHranilistima
                                            where g.Id.Hraniliste.Broj == brojHranilista 
                                            select o;*/
                //IEnumerable<Zivotinja> od = from o in s.Query<PrimeceneNaHranilistima>()
                //                            where o.Id.Hraniliste.Broj == brojHranilista && o.UocenaPrviPut.Year > d.Year &&
                //                            o.UocenaPrviPut.Month > d.Month && o.UocenaPrviPut.Day > d.Day
                //                            select o.Id.Zivotinja;

                IEnumerable<Zivotinja> od = from o in s.Query<Zivotinja>()
                                            from g in o.HraniSeNaHranilistima
                                            where g.Id.Hraniliste.Broj == brojHranilista &&
                                                g.UocenaPrviPut.CompareTo(d) >= 0
                                            select o;


                foreach (var i in od)
                {
                    int tip;
                    if (i.GetType() == typeof(PticaSelica))
                        tip = 1;
                    else
                        tip = 0;


                    zivotinje.Add(new ZivotinjaView() { Id = i.Id, LatinskiNaziv = i.LatinskiNaziv, LokalniNaziv = i.LokalniNaziv, SBP = i.SBP, PticaSelicaFleg = tip });

                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return zivotinje;


        }

        public static List<ZivotinjaView> VratiZivotinjeNaHranilistuPrikaz(int brojHranilista)
        {
            List<ZivotinjaView> zivotinje = new List<ZivotinjaView>();
            try
            {
                ISession s = DataLayer.GetSession();


                IEnumerable<Zivotinja> od = from o in s.Query<Zivotinja>()
                                            from g in o.HraniSeNaHranilistima
                                            where g.Id.Hraniliste.Broj == brojHranilista
                                            select o;
                /* IEnumerable<Zivotinja> od = from o in s.Query<PrimeceneNaHranilistima>()
                                             where o.Id.Hraniliste.Broj == brojHranilista
                                             select o.Id.Zivotinja;*/


                foreach (var i in od)
                {
                    int tip;
                    if (i.GetType() == typeof(PticaSelica))
                        tip = 1;
                    else
                        tip = 0;


                    zivotinje.Add(new ZivotinjaView() { Id = i.Id, LatinskiNaziv = i.LatinskiNaziv, LokalniNaziv = i.LokalniNaziv, SBP = i.SBP, PticaSelicaFleg = tip });

                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return zivotinje;


        }

        public static List<ZivotinjaView> VratiPticeNaHranilistuPrikaz(int brojHranilista)
        {
            List<ZivotinjaView> zivotinje = new List<ZivotinjaView>();
            try
            {
                ISession s = DataLayer.GetSession();


                IEnumerable<Zivotinja> od = from o in s.Query<Zivotinja>()
                                            from g in o.HraniSeNaHranilistima
                                            where g.Id.Hraniliste.Broj == brojHranilista
                                            select o;
                /*IEnumerable<Zivotinja> od = from o in s.Query<PrimeceneNaHranilistima>()
                                            where o.Id.Hraniliste.Broj == brojHranilista 
                                            select o.Id.Zivotinja;*/
                foreach (var i in od)
                {

                    if (i.GetType() == typeof(PticaSelica))
                        zivotinje.Add(new ZivotinjaView() { Id = i.Id, LatinskiNaziv = i.LatinskiNaziv, LokalniNaziv = i.LokalniNaziv, SBP = i.SBP, PticaSelicaFleg = 1 });



                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return zivotinje;


        }


        public static List<ZivotinjaView> VratiSveZivotinje()
        {
            List<ZivotinjaView> zivotinje = new List<ZivotinjaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zivotinja> od = from o in s.Query<Zivotinja>()
                                            select o;

                foreach (var i in od)
                {
                    int tip;
                    if (i.GetType() == typeof(PticaSelica))
                        tip = 1;
                    else
                        tip = 0;


                    zivotinje.Add(new ZivotinjaView() { Id = i.Id, LatinskiNaziv = i.LatinskiNaziv, LokalniNaziv = i.LokalniNaziv, SBP = i.SBP, PticaSelicaFleg = tip });

                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return zivotinje;


        }



        public static List<ZivotinjaView> VratiZivotinjePrikaz(int idOblasti)
        {
            List<ZivotinjaView> zivotinje = new List<ZivotinjaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zivotinja> od = from o in s.Query<Zivotinja>()
                                            where o.Oblast.Id == idOblasti
                                            select o;

                foreach (var i in od)
                {
                    int tip;
                    if (i.GetType() == typeof(PticaSelica))
                        tip = 1;
                    else
                        tip = 0;


                    zivotinje.Add(new ZivotinjaView() { Id = i.Id, LatinskiNaziv = i.LatinskiNaziv, LokalniNaziv = i.LokalniNaziv, SBP = i.SBP, PticaSelicaFleg = tip });

                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return zivotinje;


        }

        public static List<ZivotinjaView> VratiPticeSelicePrikaz(int idOblasti)
        {
            List<ZivotinjaView> ptice = new List<ZivotinjaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PticaSelica> od = from o in s.Query<PticaSelica>()
                                              where o.Oblast.Id == idOblasti
                                              select o;

                foreach (var i in od)
                {

                    ptice.Add(new ZivotinjaView() { Id = i.Id, LatinskiNaziv = i.LatinskiNaziv, LokalniNaziv = i.LokalniNaziv, SBP = i.SBP, PticaSelicaFleg = 1 });

                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return ptice;


        }

        public static ZivotinjaBasic VratiZivotinjuBasic(int idZivotinje)
        {
            ZivotinjaBasic zivotinja = null;
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinja z = s.Load<Zivotinja>(idZivotinje);

                zivotinja = new ZivotinjaBasic()
                {
                    Id = z.Id,
                    LatinskiNaziv = z.LatinskiNaziv,
                    LokalniNaziv = z.LokalniNaziv,
                    SBP = z.SBP,
                    PticaSelicaFleg = z.PticaSelicaFleg,
                };

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return zivotinja;

        }

        public static void SacuvajZivotinju(ZivotinjaBasic z, int idOblasti)// cuvanje zivotinje
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oblast o = s.Load<Oblast>(idOblasti);

                Zivotinja a = new Zivotinja()
                {
                    LatinskiNaziv = z.LatinskiNaziv,
                    LokalniNaziv = z.LokalniNaziv,
                    SBP = z.SBP,
                    Oblast = o
                };
                o.Zivotinje.Add(a);
                s.Save(o);
                s.Flush();
                s.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SacuvajPticuSelicu(ZivotinjaBasic p, int idOblasti)// cuvanje ptice selice
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oblast o = s.Load<Oblast>(idOblasti);

                PticaSelica a = new PticaSelica()
                {
                    LatinskiNaziv = p.LatinskiNaziv,
                    LokalniNaziv = p.LokalniNaziv,
                    SBP = p.SBP,
                };

                a.Oblast = o;
                o.Zivotinje.Add(a);

                s.Save(o);
                s.Flush();
                s.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void AzurirajZivotinju(ZivotinjaBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zivotinja zivotinja = s.Load<Zivotinja>(z.Id);

                zivotinja.LatinskiNaziv = z.LatinskiNaziv;
                zivotinja.LokalniNaziv = z.LokalniNaziv;
                zivotinja.SBP = z.SBP;
                //radnik.RadniNaOblasti = o;

                s.Update(zivotinja);
                s.Flush();
                s.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void AzurirajPticuSelicu(ZivotinjaBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                PticaSelica pticaselica = s.Load<PticaSelica>(z.Id);

                pticaselica.LatinskiNaziv = z.LatinskiNaziv;
                pticaselica.LokalniNaziv = z.LokalniNaziv;
                pticaselica.SBP = z.SBP;
                // radnik.RadniNaOblasti = o;
                s.Update(pticaselica);
                s.Flush();
                s.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void ObrisiZivotinju(int idZivotinje)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinja z = s.Load<Zivotinja>(idZivotinje);

                s.Delete(z);
                s.Flush();
                s.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
