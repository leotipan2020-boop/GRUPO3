
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GRUPO3.Models;
using GRUPO3.Data;

public class MaestrosController : Controller
{
    private readonly EscolarContext _context;

    public MaestrosController(EscolarContext context)
    {
        _context = context;
    }

    // GET: Maestros
    public async Task<IActionResult> Index()
    {
        return View(await _context.Maestros.ToListAsync());
    }

    // GET: Maestros/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var maestro = await _context.Maestros
            .FirstOrDefaultAsync(m => m.Id == id);

        if (maestro == null)
        {
            return NotFound();
        }

        return View(maestro);
    }

    // GET: Maestros/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Maestros/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        [Bind("Id,Nombre,Apellido,Especialidad")] Maestro maestro)
    {
        if (ModelState.IsValid)
        {
            _context.Add(maestro);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        return View(maestro);
    }

    // GET: Maestros/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var maestro = await _context.Maestros.FindAsync(id);

        if (maestro == null)
        {
            return NotFound();
        }

        return View(maestro);
    }

    // POST: Maestros/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(
        int? id,
        [Bind("Id,Nombre,Apellido,Especialidad")] Maestro maestro)
    {
        if (id != maestro.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(maestro);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaestroExists(maestro.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }

        return View(maestro);
    }

    // GET: Maestros/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var maestro = await _context.Maestros
            .FirstOrDefaultAsync(m => m.Id == id);

        if (maestro == null)
        {
            return NotFound();
        }

        return View(maestro);
    }

    // POST: Maestros/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var maestro = await _context.Maestros.FindAsync(id);

        if (maestro != null)
        {
            _context.Maestros.Remove(maestro);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }

    private bool MaestroExists(int? id)
    {
        return _context.Maestros.Any(e => e.Id == id);
    }
}
