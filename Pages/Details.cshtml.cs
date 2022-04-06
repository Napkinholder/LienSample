using LienSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LienSample.Pages;

public class DetailsModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ILienStorageContext _lienContext;

    [BindProperty]
    public Lien? Lien { get; set; }
    public SelectList LienTypes { get; set; }

    public DetailsModel(ILogger<IndexModel> logger, ILienStorageContext lienContext, ILienTypeStorageContext lienTypeContext)
    {
        _logger = logger;
        _lienContext = lienContext;
        LienTypes =  new SelectList(lienTypeContext.GetAll().Values, nameof(LienType.Id), nameof(LienType.Name));
    }

    public IActionResult OnGet(int id)
    {
        Lien = _lienContext.Get(id);
        if (Lien == null)
        {
            return NotFound();
        }
        return Page();
    }

    public IActionResult OnPost()
    {
        if (Lien != null)
        {
            _lienContext.Save(Lien);
            return RedirectToPage("./Index");
        }
        else {
            return NotFound();
        }
    }
}
