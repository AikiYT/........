using CitasMedicaApp.Domain.Entities;
using CitasMedicasApp.Persistance.Interface.Configuration;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CitasMedicas.Configuration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepositorio _doctorRepositorio;

        public DoctorController(IDoctorRepositorio doctorRepositorio) 
        { 
            _doctorRepositorio = doctorRepositorio;
        
        }
        // GET: api/<DoctorController>
        
        [HttpGet("GetDoctor")]
        public async Task<IActionResult> Get()
        {
            var result = _doctorRepositorio.GettAll();

            if (!result.Success)
            
                return BadRequest(result);
            
                return Ok(result);
            
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DoctorController>
        [HttpPost("SaveDoctor")]//
        public async Task<IActionResult> Post([FromBody] Doctors doctor)
        {
            var result = await _doctorRepositorio.Save(doctor);

            if (!result.Success)
            { 
            return BadRequest(result);
            }
            return Ok();

        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
