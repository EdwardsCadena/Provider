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
    public class SupplierRepository : ISupplierRepository
    {
        private readonly TkosContext _context;

        public SupplierRepository(TkosContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            var supplier = await _context.Suppliers.ToListAsync();
            return supplier;
        }
        public async Task<Supplier> GetSupplier(int id)
        {
            var supplier = await _context.Suppliers.FirstOrDefaultAsync(x => x.IdSupplier == id);
            return supplier;
        }
        public async Task InsertSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdateSupplier(Supplier supplier)
        {
            var result = await GetSupplier(supplier.IdSupplier);
            result.Nit = supplier.Nit;
            result.Name = supplier.Name;
            result.Email = supplier.Email;
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
        public async Task<bool> DeleteSupplier(int id)
        {
            var delete = await GetSupplier(id);
            _context.Remove(delete);
            int row = await _context.SaveChangesAsync();
            return row > 0;
        }
    }
}
