using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkus.Core.Entities;

namespace Tkus.Core.Interfaces
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetSuppliers();
        Task<Supplier> GetSupplier(int id);
        Task InsertSupplier(Supplier supplier);
        Task<bool> UpdateSupplier(Supplier supplier);
        Task<bool> DeleteSupplier(int id);
    }
}
