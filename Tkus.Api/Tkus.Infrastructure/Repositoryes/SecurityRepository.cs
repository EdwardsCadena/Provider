using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkus.Core.Entities;
using Tkus.Core.Interfaces;
using Tkus.Infrastructure.Data;

namespace Tkus.Infrastructure.Repositoryes
{
    public class SecurityRepository
    {
        private readonly TkosContext _context;

        public SecurityRepository(TkosContext context)
        {
            _context = context;
        }

        //public async Task<Security> GetLoginByCredentials(UserLogin userlogin)
        //{
        //    return await _context.FirstOrDefaultAsync(x => x.User == userlogin.User && x.Password == userlogin.Password);
        //}
    }
}
