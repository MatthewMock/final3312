﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace final.Pages;

public class IndexModel : PageModel

{
    [BindProperty]
    public string Name {get; set;} = string.Empty;
    [BindProperty]
    public string Password {get; set;} = string.Empty;
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
