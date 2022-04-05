using LienSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LienSample.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ILienStorageContext _context;
    private IEnumerable<Lien>? liens;
    public IEnumerable<Lien>? Liens { get => liens; }

    public IndexModel(ILogger<IndexModel> logger, ILienStorageContext context)
    {
        _logger = logger;
        _context = context;
        liens = new Lien[0];
    }


    public void OnGet()
    {
        liens = _context.Search();
    }
}
