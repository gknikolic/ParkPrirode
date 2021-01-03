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
    class DTOManangerOblast
    {
        public static List<OblastView> VratiOblastiSaStalnomZastitom()
        {
            List<OblastView> oblasti = new List<OblastView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StalnaZastita> od = from o in s.Query<StalnaZastita>()
                                                select o;

                foreach (var i in od)
                {
                    oblasti.Add(new OblastView(i.Id, i.JedinstvenoIme, i.Povrsina, i.RadniziUOblasti.Count, i.Zivotinje.Count, i.Biljke.Count, "Stalna zastita"));
                }

                s.Close();


            }
            catch (Exception)
            {

                throw;
            }

            return oblasti;
        }
        public static OblastBasic VratiOblast(int id)
        {
            OblastBasic o = null;
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast oblast = s.Load<Oblast>(id);


                string tip = "";
                if (oblast.GetType() == typeof(StalnaZastita))
                    tip = "Stalna zastita";
                else if (oblast.GetType() == typeof(Monitoring))
                    tip = "Monitoring";
                else if (oblast.GetType() == typeof(PovremeneIntervencije))
                    tip = "Povremena intervencija";


                o = new OblastBasic()
                {
                    JedinstvenoIme = oblast.JedinstvenoIme,
                    OblastId = oblast.Id,
                    Povrsina = oblast.Povrsina,
                    TipZastite = tip                  
                };

                s.Close();


            }
            catch (Exception)
            {

                throw;
            }
            return o;

           
        }

        public static List<OblastView> VratiSveOblasti()
        {
            List<OblastView> oblasti = new List<OblastView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Oblast> od = from o in s.Query<Oblast>()
                                         select o;

                foreach (var i in od)
                {
                    string tip="";
                    if (i.GetType() == typeof(StalnaZastita))
                        tip = "Stalna zastita";
                    else if (i.GetType() == typeof(Monitoring))
                        tip = "Monitoring";
                    else if (i.GetType() == typeof(PovremeneIntervencije))
                        tip = "Povremena intervencija";
                     

                    oblasti.Add(new OblastView(i.Id,i.JedinstvenoIme,i.Povrsina,i.RadniziUOblasti.Count,i.Zivotinje.Count,i.Biljke.Count,tip));
                }

                s.Close();


            }
            catch (Exception)
            {

                throw;
            }

            return oblasti;
        }

      
        public static int DodajOblast(OblastBasic a) // ovo ne radi kako treba
        {
            try
            {

                ISession s = DataLayer.GetSession();

                string ime = (from ob in s.Query<Oblast>()
                           where (ob.JedinstvenoIme == a.JedinstvenoIme)
                           select ob.JedinstvenoIme).SingleOrDefault();


                if (ime==a.JedinstvenoIme)
                    return 0;
               

                Oblast o = null;

                if(a.TipZastite == "Stalna zastita")
                {
                    o = new StalnaZastita()
                    {
                        JedinstvenoIme = a.JedinstvenoIme,
                        Povrsina = a.Povrsina
                    };
                }
                else if(a.TipZastite == "Monitoring")
                {
                    o = new Monitoring()
                    {
                        JedinstvenoIme = a.JedinstvenoIme,
                        Povrsina = a.Povrsina
                    };
                }
                else
                {
                    o = new PovremeneIntervencije()
                    {
                        JedinstvenoIme = a.JedinstvenoIme,
                        Povrsina = a.Povrsina
                    };
                }

                s.Save(o);
                s.Flush();
                s.Close();

                
            }
            catch (Exception ec)
            {
                return 2;                
            }
            return 1;
        }



        public static int ObrisiOblast(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oblast o = s.Get<Oblast>(id);
                if (o == null)
                    return 0;
                s.Delete(o);
                s.Flush();
                s.Close();


            }
            catch (Exception)
            {
                return 2;                
            }
            return 1;
        }

        public static int UpdateOblastBasic(OblastBasic a)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                string ime = (from ob in s.Query<Oblast>()
                              where (ob.JedinstvenoIme == a.JedinstvenoIme)
                              select ob.JedinstvenoIme).SingleOrDefault();


                /*if (ime == a.JedinstvenoIme)
                    return 0;*/

                Oblast o = s.Load<Oblast>(a.OblastId);
               // o.JedinstvenoIme = a.JedinstvenoIme;
                o.Povrsina = a.Povrsina;
               

                s.Update(o);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                return 2;
            }
            return 1;
        }


        /*public static List<OblastView> VratiOblastiSaStalnomZastitom()
        {
            List<OblastView> oblasti = new List<OblastView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StalnaZastita> od = from o in s.Query<StalnaZastita>()
                                         select o;

                foreach (var i in od)
                {
                    oblasti.Add(new OblastView(i.Id, i.JedinstvenoIme, i.Povrsina, i.RadniziUOblasti.Count, i.Zivotinje.Count, i.Biljke.Count));
                }

                s.Close();


            }
            catch (Exception)
            {

                throw;
            }

            return oblasti;
        }*/

        /*public static OblastBasic VratiOblast(int id)
        {
            OblastBasic o = null;
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast ob = s.Load<Oblast>(id);
                o = new OblastBasic()
                {
                    OblastId = ob.Id,
                    JedinstvenoIme = ob.JedinstvenoIme;
                    
                }


            }
            catch (Exception)
            {

                throw;
            }

        }*/

    }
}
