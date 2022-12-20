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
    public class TypeformRepository : ITypeformRepository
    {
        private readonly TkosContext _context;

        public TypeformRepository(TkosContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Typeform>> GetTypeforms()
        {
            var typeform = await _context.Typeforms.ToListAsync();
            return typeform;
        }
        public async Task<Typeform> GetTypeform(int id)
        {
            var typeform = await _context.Typeforms.FirstOrDefaultAsync(x => x.Idtypeform == id);
            return typeform;
        }
        public async Task InsertTypeform(Typeform typeform)
        {
            _context.Typeforms.Add(typeform);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdateTypeform(Typeform typeform)
        {
            var result = await GetTypeform(typeform.Idtypeform);
            result.String = typeform.String;
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
        public async Task<bool> DeleteTypeform(int id)
        {
            var delete = await GetTypeform(id);
            _context.Remove(delete);
            int row = await _context.SaveChangesAsync();
            return row > 0;
        }
    }
}
