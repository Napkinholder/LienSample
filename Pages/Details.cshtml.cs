using LienSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LienSample.Pages;

public class DetailsModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ILienStorageContext _context;

    [BindProperty]
    public Lien? Lien { get; set; }

    public DetailsModel(ILogger<IndexModel> logger, ILienStorageContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult OnGet(int id)
    {
        Lien = _context.Get(id);
        if (Lien == null)
        {
            return NotFound();
        }
        return Page();
    }

    public IActionResult OnPost()
    {
        _context.Save(Lien);
        return RedirectToPage("./Index");
    }
}
