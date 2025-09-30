using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZADANIE5.Models;
namespace Zadanie5.Controllers;
public class TestController : Controller
{
    public readonly TestContext _context;
    public TestController(TestContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var klienci = await _context.Klienci.ToListAsync();
        return View(klienci);
    }
    public IActionResult Create()
    {
        return View();
    }
}
