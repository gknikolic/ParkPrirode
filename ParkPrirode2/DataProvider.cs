using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParkPrirode2.DTO;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using ParkPrirode2.Entiteti;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;

namespace ParkPrirode2
{
    public class DataProvider
    {

        #region Biljka DataProvider

        
        public List<BiljkaView> GetBiljke()
        {
            List<BiljkaView> biljke = new List<BiljkaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Biljka> od = from o in s.Query<Biljka>()
                                         select o;
                string zastita;
                foreach (Biljka i in od)
                {
                    if (i.GetType() == typeof(BiljkaSaPosebnomZastitom))
                        zastita = "Da";
                    else
                        zastita = "Ne";
                    biljke.Add(new BiljkaView(i.Id, i.LatinskiNaziv, i.LokalniNaziv, zastita));

                }

                s.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return biljke;

        }

        public Biljka GetBiljka(int id)
        {
            ISession s = DataLayer.GetSession();

            Biljka biljka = s.Query<Biljka>()
                .Where(b => b.Id == id).Select(a => a).First();
            if (biljka == null)
                return new Biljka();
            else
                return biljka;

        }



        public BiljkaView GetBiljkaView(int id)
        {
            ISession s = DataLayer.GetSession();

            Biljka biljka = s.Query<Biljka>()
                .Where(b => b.Id == id).Select(a => a).First();
            if (biljka == null)
                return new BiljkaView();
            else
                return new BiljkaView(biljka);

        }

        public int AddBiljka(Biljka b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveBiljka(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Biljka b = s.Load<Biljka>(id);

                s.Delete(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }
        #endregion
        #region Zivotinja DataProvider


        public IEnumerable<Zivotinja> GetZivotinja()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Zivotinja> zivotinje = from o in s.Query<Zivotinja>()
                                         select o;

            return zivotinje;

        }

        public Zivotinja GetZivotinja(int id)
        {
            ISession s = DataLayer.GetSession();

            Zivotinja zivotinja = s.Query<Zivotinja>()
                .Where(b => b.Id == id).Select(a => a).First();
            if (zivotinja == null)
                return new Zivotinja();
            else
                return zivotinja;

        }



        //public ZivotinjaView GetZivotinjaView(int id)
        //{
        //    ISession s = DataLayer.GetSession();

        //    Zivotinja zivotinja = s.Query<Zivotinja>()
        //        .Where(b => b.Id == id).Select(a => a).First();
        //    if (zivotinja == null)
        //        return new ZivotinjaView();
        //    else
        //        return new ZivotinjaView(zivotinja);

        //}

        public int AddZivotinja(Zivotinja b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveZivotinja(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinja b = s.Load<Zivotinja>(id);

                s.Delete(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }

        #endregion
        #region Hraniliste DataProvider


        public IEnumerable<Hraniliste> GetHraniliste()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Hraniliste> hraniliste = from o in s.Query<Hraniliste>()
                                               select o;

            return hraniliste;

        }

        public Hraniliste GetHraniliste(int broj)
        {
            ISession s = DataLayer.GetSession();

            Hraniliste hraniliste = s.Query<Hraniliste>()
                .Where(b => b.Broj == broj).Select(a => a).First();
            if (hraniliste == null)
                return new Hraniliste();
            else
                return hraniliste;

        }



        //public HranilisteView GetHranilisteView(int broj)
        //{
        //    ISession s = DataLayer.GetSession();

        //    Hraniliste hraniliste = s.Query<Hraniliste>()
        //        .Where(b => b.Broj == broj).Select(a => a).First();
        //    if (hraniliste == null)
        //        return new HranilisteView();
        //    else
        //        return new HranilisteView(hraniliste);

        //}

        public int AddHraniliste(Hraniliste b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveHraniliste(int broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Hraniliste b = s.Load<Hraniliste>(broj);

                s.Delete(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }

        #endregion
        #region Oblast DataProvider


        public IEnumerable<Oblast> GetOblast()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Oblast> oblast = from o in s.Query<Oblast>()
                                               select o;

            return oblast;

        }

        public Oblast GetOblast(int id)
        {
            ISession s = DataLayer.GetSession();

            Oblast oblast = s.Query<Oblast>()
                .Where(b => b.Id == id).Select(a => a).First();
            //if (oblast == null)
              //  return new Oblast();
            //else
                return oblast;
        }



        //public OblastView GetOblastView(int id)
        //{
        //    ISession s = DataLayer.GetSession();

        //    Oblast oblast = s.Query<Oblast>()
        //        .Where(b => b.Id == id).Select(a => a).First();
        //    if (oblast == null)
        //        return new OblastView();
        //    else
        //        return new OblastView(oblast);

        //}

        public int AddOblast(Oblast b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveOblast(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oblast b = s.Load<Oblast>(id);

                s.Delete(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }

        #endregion
        #region OpstineUOblasti DataProvider


        public IEnumerable<OpstineUOblasti> GetOpstineUOblasti()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<OpstineUOblasti> opstine = from o in s.Query<OpstineUOblasti>()
                                               select o;

            return opstine;

        }

        public OpstineUOblasti GetOpstineUOblasti(int id)
        {
            ISession s = DataLayer.GetSession();

            OpstineUOblasti opstine = s.Query<OpstineUOblasti>()
                .Where(b => b.Id == id).Select(a => a).First();
            if (opstine == null)
                return new OpstineUOblasti();
            else
                return opstine;

        }



        //public OpstineUOblastiView GetOpstineUOblastiView(int id)
        //{
        //    ISession s = DataLayer.GetSession();

        //    OpstineUOblasti opstine = s.Query<OpstineUOblasti>()
        //        .Where(b => b.Id == id).Select(a => a).First();
        //    if (opstine == null)
        //        return new OpstineUOblastiView();
        //    else
        //        return new OpstineUOblastiView(opstine);

        //}

        public int AddOpstineUOblasti(OpstineUOblasti b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveOpstineUOblasti(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                OpstineUOblasti b = s.Load<OpstineUOblasti>(id);

                s.Delete(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }

        #endregion
        #region Radnik DataProvider


        public IEnumerable<Radnik> GetRadnik()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Radnik> radnik = from o in s.Query<Radnik>()
                                               select o;

            return radnik;

        }
        public IEnumerable<StalniRadnik> GetStalniRadnik()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<StalniRadnik> stalniradnik = from o in s.Query<StalniRadnik>()
                                         select o;

            return stalniradnik;

        }

        public Radnik GetRadnik(int id)
        {
            ISession s = DataLayer.GetSession();

            Radnik radnik = s.Query<Radnik>()
                .Where(b => b.Id == id).Select(a => a).First();
            //if (radnik == null)
            //   return new Radnik();
            //else
            return radnik;
        }
        //public RadnikView GetRadnikView(int id)
        //{
        //    ISession s = DataLayer.GetSession();

        //    Radnik radnik = s.Query<Radnik>()
        //        .Where(b => b.Id == id).Select(a => a).First();
        //    if (radnik == null)
        //        return new RadnikView();
        //    else
        //        return new RadnikView(radnik);

        //}
        //public StalniRadnikView GetStalniRadnikView(int id)
        //{
        //    ISession s = DataLayer.GetSession();

        //    StalniRadnik stalniradnik = s.Query<StalniRadnik>()
        //        .Where(b => b.Id == id).Select(a => a).First();
        //    if (stalniradnik == null)
        //        return new StalniRadnikView();
        //    else
        //        return new StalniRadnikView(stalniradnik);

        //}

        public int AddRadnik(Radnik b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int AddStalniRadnik(StalniRadnik b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveRadnik(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Radnik b = s.Load<Radnik>(id);

                s.Delete(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }

        }
        #endregion
    }



}
