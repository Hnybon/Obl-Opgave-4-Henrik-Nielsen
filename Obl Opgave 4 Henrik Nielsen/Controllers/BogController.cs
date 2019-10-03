using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestLibrary;

namespace Obl_Opgave_4_Henrik_Nielsen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BogController : ControllerBase
    {

        private static List<Bog> bogListe = new List<Bog>()
        {
            new Bog("Hans is a Freaky alien genotype", "Anders Holm", 341, "0001110001110")
        };

        // GET: api/Bog
        [HttpGet]
        public IEnumerable<Bog> Get()
        {
            return bogListe;
        }

        // GET: api/Bog/5
        [HttpGet("{isbn13}", Name = "Get")]
        public Bog Get(string isbn13)
        {
            return bogListe.Find(i => i.Isbn13 == isbn13);
        }

        // POST: api/Bog
        [HttpPost]
        public void Post([FromBody] Bog value)
        {
            bogListe.Add(value);
        }

        // PUT: api/Bog/5
        [HttpPut("{id}")]
        public void Put(string isbn13, [FromBody] Bog value)
        {
            Bog bog = Get(isbn13);
            if (bog != null)
            {
                bog.Titel = value.Titel;
                bog.Forfatter = value.Forfatter;
                bog.Sidetal = value.Sidetal;
                bog.Isbn13 = value.Isbn13;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{isbn13}")]
        public void Delete(string isbn13)
        {
            Bog bog = Get(isbn13);
            bogListe.Remove(bog);
        }
    }
}
