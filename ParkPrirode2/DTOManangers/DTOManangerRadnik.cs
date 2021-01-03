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
    public class DTOManangerRadnik
    {
        public static List<RadnikView> VratiRadnikePrikaz(int idOblasti)
        {
            List<RadnikView> radnici = new List<RadnikView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Radnik> od = from o in s.Query<Radnik>()
                                         where o.RadniNaOblasti.Id==idOblasti
                                         select o;

                foreach (var i in od)
                {
                    string tip;
                    if (i.GetType() == typeof(StalniRadnik))
                        tip = "Stalni radnik";
                    else
                        tip = "Volonter";


                    radnici.Add(new RadnikView() { Id = i.Id, Ime = i.Ime, Prezime = i.Prezime, TipRadnika = tip });
                    
                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return radnici;


        }

        public static List<StalniRadnikView> VratiStalneRadnikePrikaz(int idOblasti)
        {
            List<StalniRadnikView> radnici = new List<StalniRadnikView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StalniRadnik> od = from o in s.Query<StalniRadnik>()
                                         where o.RadniNaOblasti.Id == idOblasti
                                         select o;

                foreach (var i in od)
                {                  
                
                    radnici.Add(new StalniRadnikView() { Id = i.Id, Ime = i.Ime, Prezime = i.Prezime, TipRadnika = "Stalni radnik" ,BrRadneKnjizice=i.BrRadneKnjizice});

                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return radnici;


        }

        public static RadnikBasic VratiRadnikaBasic(int idRadnika)
        {
            RadnikBasic radnik = null;
            try
            {
                ISession s = DataLayer.GetSession();

                Radnik r = s.Load<Radnik>(idRadnika);

                radnik = new RadnikBasic()
                {
                    Id = r.Id,
                    MBR = r.MBR,
                    Ime = r.Ime,
                    Prezime = r.Prezime,
                    Adresa = r.Adresa                    
                };

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return radnik;

        }

        public static StalniRadnikBasic VratiStalnogRadnikaBasic(int idRadnika)
        {
            StalniRadnikBasic radnik = null;
            try
            {
                ISession s = DataLayer.GetSession();

                StalniRadnik r = s.Load<StalniRadnik>(idRadnika);

                radnik = new StalniRadnikBasic()
                {
                    Id = r.Id,
                    MBR = r.MBR,
                    Ime = r.Ime,
                    Prezime = r.Prezime,
                    Adresa = r.Adresa,
                    BrLicneKarte=r.BrLicneKarte,
                    BrRadneKnjizice=r.BrRadneKnjizice,
                    MestoIzdavanjaLicneKarte=r.MestoIzdavanjaLk                    
                };

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return radnik;

        }

        public static void SacuvajRadnika(RadnikBasic r,int idOblasti)// cuvanje volontera
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oblast o = s.Load<Oblast>(idOblasti);
                                               
                Volonter a = new Volonter()
                {                    
                    Ime = r.Ime,
                    Prezime = r.Prezime,
                    Adresa = r.Adresa,
                    MBR = r.MBR,
                    RadniNaOblasti = o
                };
                o.RadniziUOblasti.Add(a);
                s.Save(o);
                s.Flush();
                s.Close();

            }
            catch (Exception)
            {

                throw;
            }            
        }

        public static void SacuvajStalnogRadnika(StalniRadnikBasic r, int idOblasti)// cuvanje volontera
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oblast o = s.Load<Oblast>(idOblasti);
                                                          
                StalniRadnik a = new StalniRadnik()
                {                    
                    Ime = r.Ime,
                    Prezime = r.Prezime,
                    Adresa = r.Adresa,
                    MBR = r.MBR,
                    RadniNaOblasti = o,//
                    BrLicneKarte = r.BrLicneKarte,
                    BrRadneKnjizice = r.BrRadneKnjizice,
                    MestoIzdavanjaLk = r.MestoIzdavanjaLicneKarte
                };

               // a.RadniNaOblasti = o;
                o.RadniziUOblasti.Add(a);

                s.Save(o);
                s.Flush();
                s.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void AzurirajStalnogRadnika(StalniRadnikBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StalniRadnik radnik = s.Load<StalniRadnik>(r.Id);

                radnik.Ime = r.Ime;
                radnik.Prezime = r.Prezime;
                radnik.Adresa = r.Adresa;
                radnik.MBR = r.MBR;
                //radnik.RadniNaOblasti = o;
                radnik.BrLicneKarte = r.BrLicneKarte;
                radnik.BrRadneKnjizice = r.BrRadneKnjizice;
                radnik.MestoIzdavanjaLk = r.MestoIzdavanjaLicneKarte;

                s.Update(radnik);
                s.Flush();
                s.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void AzurirajRadnika(RadnikBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Radnik radnik = s.Load<Radnik>(r.Id);

                radnik.Ime = r.Ime;
                radnik.Prezime = r.Prezime;
                radnik.Adresa = r.Adresa;
                radnik.MBR = r.MBR;
                // radnik.RadniNaOblasti = o;
                s.Update(radnik);
                s.Flush();
                s.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void ObrisiRadnika(int idRadnika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Radnik r = s.Load<Radnik>(idRadnika);

                s.Delete(r);
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
