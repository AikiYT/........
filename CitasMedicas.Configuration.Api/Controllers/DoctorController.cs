using CitasMedicaApp.Domain.Entities;
using CitasMedicas.Applications.Contracts;
using CitasMedicas.Applications.Dtos.Configuration.Doctor;
using CitasMedicasApp.Persistance.Interface.Configuration;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CitasMedicas.Configuration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService) 
        { 
            _doctorService = doctorService;
        
        }
        // GET: api/<DoctorController>
        
        [HttpGet("GetDoctor")]
        public async Task<IActionResult> Get()
        {
            var result = await _doctorService.GetAll();

            if (!result.IsSuccess)
            
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
        public async Task<IActionResult> Post([FromBody] DoctorSaveDto doctorSaveDto)
        {
            var result = await _doctorService.SaveAsync(doctorSaveDto);
            

            if (!result.IsActive)
            { 
            return BadRequest(result);
            }
            return Ok();

        }

        // PUT api/<DoctorController>/5
        [HttpPut("UpdateDoctors")]
        public async Task<IActionResult> Put([FromBody] DoctorUpdateDto doctorUpdateDto)
        {
            var result = await _doctorService.UpdateAsync(doctorUpdateDto);

            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
