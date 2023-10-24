using Humanizer;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebAPIServer.DataSorurce;
using WebAPIServer.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIServer.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class DipendentiController : ControllerBase
    {
        // GET: api/<DipendentiController>
        [HttpGet]
        public  ActionResult<List<Dipendente>> Get()
        {
            return DataSource.Dipendenti();
        }

        // GET api/<DipendentiController>/5
        [HttpGet("{id}")]
        public ActionResult<Dipendente> Get(int id)
        {
            return DataSource.Dipendenti().Find(d => d.Id==id);
        }

        // POST api/<DipendentiController>
        [HttpPost]
        public ActionResult<List<Dipendente>> Post([FromBody] Dipendente value)
        {
            var dipendenti = DataSource.Dipendenti();
            dipendenti.Add(value);
            return dipendenti;
        }

        // PUT api/<DipendentiController>/5
        [HttpPut("{id}")]
        public ActionResult<List<Dipendente>> Put(int id, [FromBody] Dipendente value)
        {
            var dipendenti = DataSource.Dipendenti();
            Dipendente? d = dipendenti.Find(d => d.Id==id);
            if (d!=null)
            {
                int indice = dipendenti.IndexOf(d);
                dipendenti[indice]=value;
                return dipendenti;
            }
            else return NotFound();
           



        }

        // DELETE api/<DipendentiController>/5
        [HttpDelete("{id}")]
        public ActionResult<List<Dipendente>> Delete(int id)
        {
            var dipendenti = DataSource.Dipendenti();
            Dipendente? d = dipendenti.Find(d => d.Id==id);
            if (d!=null)
            {
                dipendenti.Remove(d);
                return dipendenti;
            }
            else return NotFound();
        }
    }
}
