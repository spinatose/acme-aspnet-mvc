using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization; // 👈 new code

namespace acme.Controllers;

public class CatalogController : Controller {
    private readonly ILogger<HomeController> _logger;

    public CatalogController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Authorize] // 👈 new code
    public IActionResult Index()
    {
        return View();
    }
}