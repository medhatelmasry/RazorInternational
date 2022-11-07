using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorInternational.Pages;

public class IndexModel : PageModel  {
    private readonly ILogger<IndexModel> _logger;
    private readonly IStringLocalizer<IndexModel> _localizer;

    public IndexModel(ILogger<IndexModel> logger,
    IStringLocalizer<IndexModel> localizer) {
        _logger = logger;
        _localizer = localizer;
    }

    public void OnGet() {
        ViewData["Message"] = _localizer["Message"];
    }
}
