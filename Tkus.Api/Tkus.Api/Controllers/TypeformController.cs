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
    public class TypeformController : ControllerBase
    {
        private readonly ITypeformRepository _typeformRepository;
        private readonly IMapper _maper;
        public TypeformController(ITypeformRepository typeformRepository, IMapper mapper)
        {
            _typeformRepository = typeformRepository;
            _maper = mapper;
        }
        // GET: api/<TypeformController>
        [HttpGet]
        public async Task<IActionResult> GetTypeforms()
        {
            var typeforms = await _typeformRepository.GetTypeforms();
            var typeformsdto = _maper.Map<IEnumerable<Typeform>>(typeforms);
            return Ok(typeformsdto);
        }

        // GET api/<TypeformController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTypeforms(int id)
        {
            var typeforms = await _typeformRepository.GetTypeform(id);
            var typeformsdto = _maper.Map<IEnumerable<Typeform>>(typeforms);
            return Ok(typeformsdto);
        }

        // POST api/<TypeformController>
        [HttpPost]
        public async Task<IActionResult> PostTypeform(TypeformDtos tpdto)
        {
            var type = _maper.Map<Typeform>(tpdto);
            await _typeformRepository.InsertTypeform(type);
            return Ok(tpdto);
        }

        // PUT api/<TypeformController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeform(int id, TypeformDtos typeformdto)
        {
            var types = _maper.Map<Typeform>(typeformdto);
            types.Idtypeform = id;
            var Update = await _typeformRepository.UpdateTypeform(types);
            var updatedto = new ApiResponse<bool>(Update);
            return Ok(updatedto);
        }

        // DELETE api/<TypeformController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeform(int id)
        {
            var result = await _typeformRepository.DeleteTypeform(id);
            var deletealquiler = new ApiResponse<bool>(result);
            return Ok(deletealquiler);
        }
    }
}
