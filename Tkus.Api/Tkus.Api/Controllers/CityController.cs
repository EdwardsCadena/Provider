using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tkus.Core.Entities;
using Tkus.Core.Interfaces;
using Tkus.Infrastructure.Repositoryes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tkus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _maper;
        public CityController(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _maper = mapper;
        }
        // GET: api/<CityController>
        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
            //await _cityRepository.ApiExtern();
            var city = await _cityRepository.GetCities();
            var citydto = _maper.Map<IEnumerable<City>>(city);
            return Ok(citydto);
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
