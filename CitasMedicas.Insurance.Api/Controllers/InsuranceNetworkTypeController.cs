using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CitasMedicas.Insurance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceNetworkTypeController : ControllerBase
    {
        // GET: api/<InsuranceNetworkTypeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InsuranceNetworkTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InsuranceNetworkTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InsuranceNetworkTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InsuranceNetworkTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
