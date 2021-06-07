using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace paytabsPT_2Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CallController : ControllerBase {
        // GET: api/<CallController>
        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CallController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<CallController>
        [HttpPost]
        public string Post([FromBody] string value) {
            Debug.WriteLine("callpack ..............................", value);

            return value;
        }

        // PUT api/<CallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<CallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
