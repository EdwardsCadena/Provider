using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tkus.Api.Response;
using Tkus.Core.DTOs;
using Tkus.Core.Entities;
using Tkus.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tkus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _maper;
        public ServiceController(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _maper = mapper;
        }

        // GET: api/<ServiceController>
        [HttpGet]
        public async Task<IActionResult> GetServices()
        {
            var services = await _serviceRepository.GetServices();
            var servicesdto = _maper.Map<IEnumerable<Service>>(services);
            return Ok(servicesdto);
        }

        // GET api/<ServiceController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var service = await _serviceRepository.GetService(id);
            var servicedto = _maper.Map<IEnumerable<Service>>(service);
            return Ok(servicedto);
        }

        // POST api/<ServiceController>
        [HttpPost]
        public async Task<IActionResult> PostService(Service servicedto)
        {
            var servi = _maper.Map<Service>(servicedto);
            await _serviceRepository.InsertService(servi);
            return Ok(servicedto);
        }

        // PUT api/<ServiceController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutService(int id, ServiceDtos serviceto)
        {
            var serv = _maper.Map<Service>(serviceto);
            serv.IdServices = id;
            var Update = await _serviceRepository.UpdateService(serv);
            var updatedto = new ApiResponse<bool>(Update);
            return Ok(updatedto);
        }

        // DELETE api/<ServiceController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            var result = await _serviceRepository.DeleteService(id);
            var deletealquiler = new ApiResponse<bool>(result);
            return Ok(deletealquiler);
        }
    }
}
