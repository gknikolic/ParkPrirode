using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ParkPrirode2;
using ParkPrirode2.DTO;
using ParkPrirode2.DTOManangers;
using ParkPrirode2.Entiteti;

namespace API.Controllers
{
    public class BiljkaController : ApiController
    {
        //api/Biljka
        public List<BiljkaView> Get()
        {
            DataProvider provider = new DataProvider();

            List<BiljkaView> biljke = provider.GetBiljke();

            return biljke;
        }

        // GET: api/Biljka
        //public string Get()
        //{
        //    DataProvider provider = new DataProvider();

        //    List<BiljkaView> biljke = provider.GetBiljke();

        //    return "aaaaa";
        //}

        // GET: api/Biljka/5
        public Biljka Get(int id)
        {
            DataProvider provider = new DataProvider();

            Biljka biljka = provider.GetBiljka(id);

            return biljka;
        }

        // POST: api/Biljka
        public void Post([FromBody]Biljka b)
        {
            DataProvider provider = new DataProvider();
        }

        // PUT: api/Biljka/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Biljka/5
        public void Delete(int id)
        {
        }
    }
}
