using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkus.Infrastructure.Data;
using Tkus.Core.Entities;
using Tkus.Core.Interfaces;

namespace Tkus.Infrastructure.Repositoryes
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly TkosContext _context;

        public ServiceRepository(TkosContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Service>> GetServices()
        {
            var service = await _context.Services.ToListAsync();
            return service;
        }
        public async Task<Service> GetService(int id)
        {
            var service = await _context.Services.FirstOrDefaultAsync(x => x.IdServices == id);
            return service;
        }
        public async Task InsertService(Service service)
        {
            _context.Services.Add(service);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdateService(Service service)
        {
            var result = await GetService(service.IdServices);
            result.Nit = service.Nit;
            result.Name = service.Name;
            result.Price = service.Price;
            result.FkSupplier = service.FkSupplier;
            result.Fkcities = service.Fkcities;
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
        public async Task<bool> DeleteService(int id)
        {
            var delete = await GetService(id);
            _context.Remove(delete);
            int row = await _context.SaveChangesAsync();
            return row > 0;
        }
    }
}
