using LienSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LienSample.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ILienStorageContext _lienContext;
    private readonly ILienTypeStorageContext _lienTypeContext;
    public IEnumerable<Lien> Liens { get; set; } = new Lien[0];
    public IDictionary<string,LienType> LienTypes { get; set; } = new Dictionary<string,LienType>();

    public IndexModel(ILogger<IndexModel> logger, ILienStorageContext lienContext, ILienTypeStorageContext lienTypeContext)
    {
        _logger = logger;
        _lienContext = lienContext;
        _lienTypeContext = lienTypeContext;
    }


    public void OnGet()
    {
        Liens = _lienContext.Search();
        LienTypes = _lienTypeContext.GetAll();
    }
}
