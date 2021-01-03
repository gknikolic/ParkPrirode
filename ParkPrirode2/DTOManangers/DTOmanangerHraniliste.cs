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
    public class DTOmanangerHraniliste
    {

        public static void PostaviZivotinjaPrimecena(int idZivotinje,int brojHranilista)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Hraniliste hraniliste = s.Load<Hraniliste>(brojHranilista);

                Zivotinja zivotinja = s.Load<Zivotinja>(idZivotinje);

                PrimeceneNaHranilistima a = new PrimeceneNaHranilistima();
                a.Id.Hraniliste = hraniliste;
                a.Id.Zivotinja = zivotinja;
                a.UocenaPrviPut = DateTime.Now;

                hraniliste.HraneSeZivotinje.Add(a);
                zivotinja.HraniSeNaHranilistima.Add(a);

                s.Update(hraniliste);
                s.Flush();
                    s.Close();


            }
            catch (Exception)
            {

                throw;
            }


        }


        public static List<HranilisteView> PrikaziAktivnaHranilista()// nije dobro razmisli kasnije
        {
            List<HranilisteView> hranilista = new List<HranilisteView>();
            try
            {
                ISession s = DataLayer.GetSession();

                
                IEnumerable<Hraniliste> od = from o in s.Query<Hraniliste>()
                                             where DateTime.Now.Month >= o.PocetniMesec && 
                                             (DateTime.Now.Month <= o.KrajnjiMesec || o.PocetniMesec >= o.KrajnjiMesec)
                                             select o;  

                

                foreach (var i in od)
                {


                    hranilista.Add(new HranilisteView() { Broj = i.Broj, KrajnjiMesec = i.KrajnjiMesec, PocetniMesec = i.PocetniMesec, PripadaOblasti = i.Oblast.JedinstvenoIme });
                }

                s.Close();


            }
            catch (Exception)
            {

                throw;
            }

            return hranilista;
        }


        public static List<HranilisteView> VratiSvaHranilistaView()
        {
            List<HranilisteView> hranilista = new List<HranilisteView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Hraniliste> od = from o in s.Query<Hraniliste>()
                                             select o;

                foreach (var i in od)
                {


                    hranilista.Add(new HranilisteView() { Broj = i.Broj, KrajnjiMesec = i.KrajnjiMesec, PocetniMesec = i.PocetniMesec, PripadaOblasti = i.Oblast.JedinstvenoIme });
                }

                s.Close();


            }
            catch (Exception)
            {

                throw;
            }

            return hranilista;
        }


        public static List<HranilisteView> VratiHranilistaView(int idOblasti)
        {
            List<HranilisteView> hranilista = new List<HranilisteView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Hraniliste> od = from o in s.Query<Hraniliste>()
                                         where o.Oblast.Id == idOblasti
                                         select o;

                foreach (var i in od)
                {                 


                    hranilista.Add(new HranilisteView() {Broj=i.Broj,KrajnjiMesec=i.KrajnjiMesec,PocetniMesec=i.PocetniMesec,PripadaOblasti=i.Oblast.JedinstvenoIme });
                }

                s.Close();


            }
            catch (Exception)
            {

                throw;
            }

            return hranilista;
        }
        public static HranilisteBasic VratiHranilisteBasic(int brojHranilista)
        {
            HranilisteBasic a = null;
            try
            {
                ISession s = DataLayer.GetSession();

                Hraniliste h = s.Load<Hraniliste>(brojHranilista);

                a = new HranilisteBasic()
                {
                    Broj = h.Broj,
                    KrajnjiMesec = h.KrajnjiMesec,
                    PocetniMesec = h.PocetniMesec
                };               

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return a;
        }

        public static void SacuvahHraniliste(HranilisteBasic a,int idOblasti)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StalnaZastita o = s.Load<StalnaZastita>(idOblasti);

                Hraniliste h = new Hraniliste()
                {                    
                    KrajnjiMesec = a.KrajnjiMesec,
                    PocetniMesec = a.PocetniMesec
                };

                o.Hranilista.Add(h);
                h.Oblast = o;

                s.Save(o);
                s.Flush();
                s.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void AzurirajHraniliste(HranilisteBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Hraniliste h = s.Load<Hraniliste>(a.Broj);
                h.KrajnjiMesec = a.KrajnjiMesec;
                h.PocetniMesec = a.PocetniMesec;                                 
                             

                s.Update(h);
                s.Flush();
                s.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void ObrisiHraniliste(int brojHranilista)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Hraniliste h = s.Load<Hraniliste>(brojHranilista);
             
                s.Delete(h);
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
