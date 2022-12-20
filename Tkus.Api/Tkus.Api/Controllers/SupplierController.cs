using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tkus.Api.Response;
using Tkus.Core.Entities;
using Tkus.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tkus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _maper;
        public SupplierController(ISupplierRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _maper = mapper;
        }
        // GET: api/<SupplierController>
        [HttpGet]
        public async Task<IActionResult> GetSuppliers()
        {
            var suppliers = await _supplierRepository.GetSuppliers();
            var supplierdto = _maper.Map<IEnumerable<Supplier>>(suppliers);
            return Ok(supplierdto);
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplier(int id)
        {
            var supplier = await _supplierRepository.GetSupplier(id);
            var supplierdto = _maper.Map<IEnumerable<Supplier>>(supplier);
            return Ok(supplierdto);
        }

        // POST api/<SupplierController>
        [HttpPost]
        public async Task<IActionResult> PostSupplier(Supplier supplierdto)
        {
            var supplier = _maper.Map<Supplier>(supplierdto);
            await _supplierRepository.InsertSupplier(supplier);
            return Ok(supplierdto);
        }

        // PUT api/<SupplierController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(int id, Supplier supplierdto)
        {
            var supplier = _maper.Map<Supplier>(supplierdto);
            supplier.IdSupplier = id;
            var Update = await _supplierRepository.UpdateSupplier(supplier);
            var updatedto = new ApiResponse<bool>(Update);
            return Ok(updatedto);
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            var result = await _supplierRepository.DeleteSupplier(id);
            var deletealquiler = new ApiResponse<bool>(result);
            return Ok(deletealquiler);
        }
    }
}
