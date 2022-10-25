using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class LabController : Controller
{
    private readonly LabManagerContext _context;

    public LabController(LabManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index() => View(_context.Labs);

    public IActionResult Show(int id)
    {
        Lab lab = _context.Labs.Find(id);

        if(lab == null)
        {
            return NotFound(); 
        }

        return View(lab);
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult CreateData([FromForm] Lab lab)
    {
        _context.Labs.Add(lab);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Update(int id)
    {
        Lab find = _context.Labs.Find(id);
        return View(find);
    }

    public IActionResult UpdateData(int id, [FromForm] Lab lab)
    {
        Lab find = _context.Labs.Find(id);
        find.Number = lab.Number;
        find.Name = lab.Name;
        find.Block = lab.Block;
        
        _context.Labs.Update(find);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Lab lab = _context.Labs.Find(id);

        if(lab == null)
        {
            return NotFound(); 
        }

        _context.Labs.Remove(lab);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}