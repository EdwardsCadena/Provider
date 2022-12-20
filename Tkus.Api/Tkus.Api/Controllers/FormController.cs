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
    public class FormController : ControllerBase
    {
        private readonly IFormRepository _formRepository;
        private readonly IMapper _maper;
        public FormController(IFormRepository formRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _maper = mapper;
        }
        // GET: api/<FormController>
        [HttpGet]
        public async Task<IActionResult> GetForms()
        {
            var forms = await _formRepository.GetForms();
            var formsdto = _maper.Map<IEnumerable<Form>>(forms);
            return Ok(formsdto);
        }

        // GET api/<FormController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetForm(int id)
        {
            var form = await _formRepository.GetForm(id);
            var formsdto = _maper.Map<IEnumerable<Form>>(form);
            return Ok(formsdto);
        }

        // POST api/<FormController>
        [HttpPost]
        public async Task<IActionResult> PostForm(FormDtos formdto)
        {
            var form = _maper.Map<Form>(formdto);
            await _formRepository.InsertForm(form);
            return Ok(formdto);
        }

        // PUT api/<FormController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForm(int id, FormDtos formdto)
        {
            var fomr = _maper.Map<Form>(formdto);
            fomr.IdForm = id;
            var Update = await _formRepository.UpdateForm(fomr);
            var updatedto = new ApiResponse<bool>(Update);
            return Ok(updatedto);
        }

        // DELETE api/<FormController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForm(int id)
        {
            var result = await _formRepository.DeleteForm(id);
            var deletealquiler = new ApiResponse<bool>(result);
            return Ok(deletealquiler);
        }
    }
}
