using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkus.Core.Entities;

namespace Tkus.Core.Interfaces
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetCities();
        //Task ApiExtern();
    }
}
