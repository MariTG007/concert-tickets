using Concert.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Concert.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync()
        {
            List<SelectListItem> list = await _context.Entrances.Select(e => new SelectListItem
            {
                Text = e.Description,
                Value = e.Id.ToString()

            }).OrderBy(e => e.Text)
                .ToListAsync();

            list.Insert(0, new SelectListItem { Text = "[Seleccione una entrada...]", Value = "0" });

            return list;
        }
    }
}

