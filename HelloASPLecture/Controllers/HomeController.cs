using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HelloASPLecture.Models;

namespace HelloASPLecture.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //GET: localhose:[port#]
    public IActionResult Index()
    {
        return View();  //returns a template of what you see on the website. Y
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

