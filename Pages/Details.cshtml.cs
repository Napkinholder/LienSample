using LienSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LienSample.Pages;

public class DetailsModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ILienStorageContext _context;
    private Lien? lien;
    public Lien? Lien { get => lien; }

    public DetailsModel(ILogger<IndexModel> logger, ILienStorageContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult OnGet(int id)
    {
        lien = _context.Get(id);
        if (lien == null) {
            return NotFound();
        }
        return Page();
    }
}
