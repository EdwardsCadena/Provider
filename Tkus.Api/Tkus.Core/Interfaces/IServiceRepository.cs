using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkus.Core.Entities;

namespace Tkus.Core.Interfaces
{
    public interface IServiceRepository
    {
        Task<IEnumerable<Service>> GetServices();
        Task<Service> GetService(int id);
        Task InsertService(Service service);
        Task<bool> UpdateService(Service service);
        Task<bool> DeleteService(int id);
    }
}
