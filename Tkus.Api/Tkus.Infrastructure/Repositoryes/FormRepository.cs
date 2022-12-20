using Microsoft.EntityFrameworkCore;
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
    public class FormRepository : IFormRepository
    {
        private readonly TkosContext _context;

        public FormRepository(TkosContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Form>> GetForms()
        {
            var forms = await _context.Forms.ToListAsync();
            return forms;
        }
        public async Task<Form> GetForm(int id)
        {
            var form = await _context.Forms.FirstOrDefaultAsync(x => x.IdForm == id);
            return form;
        }
        public async Task InsertForm(Form form)
        {
            _context.Forms.Add(form);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdateForm(Form form)
        {
            var result = await GetForm(form.IdForm);
            result.Name = form.Name;
            result.Fktypeform = form.Fktypeform;
            result.Fksuppliers = form.Fksuppliers;
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
        public async Task<bool> DeleteForm(int id)
        {
            var delete = await GetForm(id);
            _context.Remove(delete);
            int row = await _context.SaveChangesAsync();
            return row > 0;
        }
    }
}
