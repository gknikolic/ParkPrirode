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
    public class DTOManangerBiljka
    {

        public static List<BiljkaView> VratiSveBiljkeView(int idOblasti)
        {
            List<BiljkaView> biljke = new List<BiljkaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Biljka> od = from o in s.Query<Biljka>() from g in o.Oblasti
                                         where g.Id == idOblasti
                                         select o;
                string zastita;
                foreach (var i in od)
                {
                    if (i.GetType()==typeof(BiljkaSaPosebnomZastitom))
                        zastita = "Da";
                    else
                        zastita = "Ne";
                     biljke.Add(new BiljkaView() { Id=i.Id,LatinskiNaziv=i.LatinskiNaziv,LokalniNaziv=i.LokalniNaziv,PosebnaZastita=zastita});

                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return biljke;
        }

        public static List<BiljkaPosebnaZastitaView> VratiSveBiljkePosebnaZastitaView(int idOblasti)
        {
            List<BiljkaPosebnaZastitaView> biljke = new List<BiljkaPosebnaZastitaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<BiljkaSaPosebnomZastitom> od = from o in s.Query<BiljkaSaPosebnomZastitom>()
                                         from g in o.Oblasti
                                         where g.Id == idOblasti
                                         select o;
                string zastita;
                foreach (var i in od)
                {
                    if (i.GetType() == typeof(BiljkaSaPosebnomZastitom))
                        zastita = "Da";
                    else
                        zastita = "Ne";
                    biljke.Add(new BiljkaPosebnaZastitaView() { Id = i.Id, LatinskiNaziv = i.LatinskiNaziv, LokalniNaziv = i.LokalniNaziv, PosebnaZastita = zastita,BrojOdluke=i.BrojOdluke });

                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return biljke;
        }



        public static BiljkaBasic VratiBiljkaBasic(int idBiljke)
        {
            BiljkaBasic b = null;
            try
            {
                ISession s = DataLayer.GetSession();

                Biljka o = s.Load<Biljka>(idBiljke);

                string zastita;
                if (o.GetType() == typeof(BiljkaSaPosebnomZastitom))
                    zastita = "Da";
                else
                    zastita = "Ne";

                b = new BiljkaBasic()
                {
                    Id = o.Id,
                    LatinskiNaziv = o.LatinskiNaziv,
                    LokalniNaziv = o.LokalniNaziv,
                    PosebnaZastita = zastita
                };
                s.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return b;
        }
        public static BiljkaPosebnaZastitaBasic VratiBiljkaPosebnaZastitaBasic(int idBiljke)
        {
            BiljkaPosebnaZastitaBasic b = null;
            try
            {
                ISession s = DataLayer.GetSession();

                BiljkaSaPosebnomZastitom o = s.Load<BiljkaSaPosebnomZastitom>(idBiljke);

                // string posebnaZastita = "Ne";

                // if (o.PosebnaZastita == 1)
                //   posebnaZastita = "Da";

                b = new BiljkaPosebnaZastitaBasic()
                {
                    Id = o.Id,
                    LatinskiNaziv = o.LatinskiNaziv,
                    LokalniNaziv = o.LokalniNaziv,
                    BrojOdluke=o.BrojOdluke,
                    DatumPocetka=o.DatumPocetka
                };

                s.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return b;
        }

        public static void DodajBiljku(BiljkaBasic b,int oblastId)//Promeni povratni tip 
        {           
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(oblastId);

                Biljka a = new Biljka()
                {
                    LatinskiNaziv = b.LatinskiNaziv,
                    LokalniNaziv = b.LokalniNaziv

                };

                a.Oblasti.Add(o);
                o.Biljke.Add(a);

                s.Save(o);
                s.Flush();
                s.Close();
                                           
               
            }
            catch (Exception)
            {

                throw;
            }            
        }

        public static void DodajBiljkuSaPosebnomZastitom(BiljkaPosebnaZastitaBasic b, int oblastId)//Promeni povratni tip 
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(oblastId);

                BiljkaSaPosebnomZastitom a = new BiljkaSaPosebnomZastitom()
                {
                    LatinskiNaziv = b.LatinskiNaziv,
                    LokalniNaziv = b.LokalniNaziv,
                    BrojOdluke=b.BrojOdluke,
                    DatumPocetka=b.DatumPocetka,
                    //PosebnaZastita=1
                    
                    
                };

                a.Oblasti.Add(o);
                o.Biljke.Add(a);

                s.Save(o);
                s.Flush();
                s.Close();


            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void ObrisiBiljku(int idBiljke)// proveri ponovo
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Biljka o = s.Load<Biljka>(idBiljke);
                                              

                s.Delete(o);
                s.Flush();
                s.Close();


            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void AzurirajBiljku(BiljkaBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Biljka o = s.Load<Biljka>(b.Id);
                o.LatinskiNaziv = b.LatinskiNaziv;
                o.LokalniNaziv = b.LokalniNaziv;

                s.Update(o);
                s.Flush();
                s.Close();


            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void AzurirajBiljkuPosebnaZastita(BiljkaPosebnaZastitaBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                BiljkaSaPosebnomZastitom o = s.Load<BiljkaSaPosebnomZastitom>(b.Id);
                o.LatinskiNaziv = b.LatinskiNaziv;
                o.LokalniNaziv = b.LokalniNaziv;
                o.BrojOdluke = b.BrojOdluke;
                o.DatumPocetka = b.DatumPocetka;
                //o.PosebnaZastita = 1;
                s.Update(o);
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
