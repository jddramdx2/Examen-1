using Microsoft.AspNetCore.Mvc;
using SistemaReciclaje.Models;
using SistemaReciclaje.Data;
using System.Linq;

[Route("Barco")]
public class BarcoController : Controller
{
    private readonly ApplicationDbContext _context;

    public BarcoController(ApplicationDbContext context)
    {
        _context = context;
    }

    [Route("")]
    [Route("Index")]
    public IActionResult Index()
    {
        var barcos = _context.Barcos.ToList();
        return View(barcos);
    }

    [Route("Create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [Route("Create")]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Barco barco)
    {
        if (ModelState.IsValid)
        {
            _context.Barcos.Add(barco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(barco);
    }

    // Puedes agregar otras acciones aquí, como Edit, Delete, etc.
}
