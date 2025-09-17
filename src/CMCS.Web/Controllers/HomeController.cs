using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CMCS.Web.Models;

namespace CMCS.Web.Controllers;

public class HomeController : Controller
{
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

    // Lecturer Dashboard
    public IActionResult LecturerDashboard()
    {
        return View();
    }

    // Coordinator Review Dashboard 
    public IActionResult ReviewDashboard()
    {
        return View();
    }

    // Status Tracking
    public IActionResult StatusTracking()
    {
        return View();
    }

    // Claim Details
    public IActionResult ClaimDetails()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
