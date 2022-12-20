using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkus.Core.Entities;

namespace Tkus.Core.Interfaces
{
    public interface ITypeformRepository
    {
        Task<IEnumerable<Typeform>> GetTypeforms();
        Task<Typeform> GetTypeform(int id);
        Task InsertTypeform(Typeform typeform);
        Task<bool> UpdateTypeform(Typeform typeform);
        Task<bool> DeleteTypeform(int id);
    }
}
