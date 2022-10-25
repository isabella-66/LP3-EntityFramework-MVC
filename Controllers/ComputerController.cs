using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class ComputerController : Controller
{
    private readonly LabManagerContext _context; //quando tem private coloca esse _

    public ComputerController(LabManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index() => View(_context.Computers);

    public IActionResult Show(int id)
    {
        Computer computer = _context.Computers.Find(id);

        if(computer == null)
        {
            return NotFound(); //RedirectToAction("Index") - preferível não pq não mostra pro usuário oq está acontecendo
        }

        return View(computer);
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult CreateData([FromForm] Computer computer)
    {
        _context.Computers.Add(computer);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Update()
    {
        return View();
    }

    public IActionResult UpdateData([FromForm] Computer computer)
    {
        Computer find = _context.Computers.Find(computer.Id);
        find.Processor = computer.Processor;
        find.Ram = computer.Ram;

        _context.Computers.Update(find);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Computer computer = _context.Computers.Find(id);

        if(computer == null)
        {
            return NotFound(); 
        }

        _context.Computers.Remove(computer);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}