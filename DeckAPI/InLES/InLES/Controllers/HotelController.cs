using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InLES.Models;
using System.Web.Http.Cors;

namespace InLES.Controllers
{
    [EnableCors(origins:"*",headers:"*", methods:"*")] // dit is er ook bijgezet na de download van Slack
    public class HotelController : ApiController
    {
        private HotelRepository repo;

        public HotelController()
        {
            repo = HotelRepository.GetInstance();
        }




        // GET: api/Hotel
        public IEnumerable<Hotel> Get()
        {
            return repo.GetHotels();
        }

        // GET: api/Hotel/5
        public Hotel Get(int id)
        {
            return repo.GetHotel(id);
        }

        // POST: api/Hotel
        public void Post([FromBody]Hotel value)
        {
            repo.Save(value);
        }

        // PUT: api/Hotel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Hotel/5
        public void Delete(int id)
        {
        }
    }
}
