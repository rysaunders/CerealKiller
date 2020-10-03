using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CerealKiller.Controllers
{
    public class InsecureController : ApiController
    {
        // GET: api/Insecure
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Insecure/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Insecure
        public IHttpActionResult Post([FromBody] Info value)
        {
            return Ok();
        }

        // PUT: api/Insecure/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Insecure/5
        public void Delete(int id)
        {
        }
    }
}
