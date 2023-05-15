using Cshtml.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cshtml.Controllers;

public class HomeController : Controller
{
    public const string s = "";
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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

    /// <summary>Summary.</summary>
    /// <param name="bar">A <see cref="string"/> to pass to <c>FOO</c>.</param>
    private static void Foo(string bar)
    {
    }
}

public enum A
{
    None
}