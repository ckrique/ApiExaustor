using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiExaustor.Controllers
{
    public class CommandController : ApiController
    {
        // GET: api/Start
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Start/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Start
        public void Post([FromBody]string value)
        {
        }

        // Patch: api/Start
        public void Patch([FromBody]string value)
        {
        }

        //// POST: api/Start
        //public void Post()
        //{
        //}

        // PUT: api/Start/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Start/5
        public void Delete(int id)
        {
        }
    }
}
