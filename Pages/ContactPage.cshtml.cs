using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorInternational.Models;
using RazorInternational.Services;

namespace RazorInternational.Pages;
public class ContactPage : PageModel {
    private readonly ILogger<ContactPage> _logger;
    private readonly SharedResourceService _sharedLocalizer;

    [BindProperty]
    public Contact Contact { get; set; } = default!;

    public ContactPage(ILogger<ContactPage> logger, SharedResourceService sharedLocalizer) {
        _logger = logger;
        _sharedLocalizer = sharedLocalizer;
    }

    public void OnGet() { }

    public IActionResult OnPost() {
        if (!ModelState.IsValid || Contact == null) {
            return Page();
        }

        ViewData["Result"] = _sharedLocalizer.Get("Success");

        return Page();
    }
}
