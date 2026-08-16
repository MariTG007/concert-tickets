using Microsoft.AspNetCore.Mvc.Rendering;

namespace Concert.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync();
    }
}
