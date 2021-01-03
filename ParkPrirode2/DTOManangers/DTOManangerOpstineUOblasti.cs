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
    public class DTOManangerOpstineUOblasti
    {
        public static List<OpstineUOblastiView> VratiOpstineUOblastiPrikaz(int idOblasti)
        {
            List<OpstineUOblastiView> opstineuoblasti = new List<OpstineUOblastiView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<OpstineUOblasti> od = from o in s.Query<OpstineUOblasti>()
                                                  where o.Oblast.Id == idOblasti
                                                  select o;

                foreach (var i in od)
                {
                    opstineuoblasti.Add(new OpstineUOblastiView() { Id = i.Id, NazivOpstine = i.NazivOpstine, ImeOblasti = i.Oblast.JedinstvenoIme });
                }
                s.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return opstineuoblasti;


        }
        public static void SacuvajOpstineUOblasti(OpstineUOblastiView r, int idOblasti)// cuvanje volontera
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oblast o = s.Load<Oblast>(idOblasti);

                OpstineUOblasti a = new OpstineUOblasti()
                {
                    NazivOpstine = r.NazivOpstine,
                };
                o.OpstineUOblasti.Add(a);
                a.Oblast = o;
                s.Save(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void AzurirajOpstineUOblasti(OpstineUOblastiView r)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                OpstineUOblasti opstine = s.Load<OpstineUOblasti>(r.Id);
                opstine.NazivOpstine = r.NazivOpstine;
                s.Update(opstine);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void ObrisiOpstineUOblasti(int idOpstineUOblasti)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                OpstineUOblasti r = s.Load<OpstineUOblasti>(idOpstineUOblasti);
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
