using InLES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace InLES.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class DeckController : ApiController
    {
        private DeckRepo repo;

        public DeckController()
        {
            repo = DeckRepo.GetInstance();
        }

        // GET: api/Deck
        public IEnumerable<Deck> Get()
        {
            return repo.GetDecks();
        }

        // GET: api/Deck/5
        public Deck Get(int id)
        {
            return repo.GetDeck(id);
        }

        // POST: api/Deck
        public void Post([FromBody]Deck value)
        {
            repo.SaveDeck(value);
        }

        // PUT: api/Deck/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Deck/5
        public void Delete(int id)
        {
        }
    }
}
