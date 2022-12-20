using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkus.Core.Entities;

namespace Tkus.Core.Interfaces
{
    public interface IFormRepository
    {
        Task<IEnumerable<Form>> GetForms();
        Task<Form> GetForm(int id);
        Task InsertForm(Form form);
        Task<bool> UpdateForm(Form form);
        Task<bool> DeleteForm(int id);
    }
}
