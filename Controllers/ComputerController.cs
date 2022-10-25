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
        List<Computer> computers = _context.Computers.ToList();
        int computerId = _context.Computers.OrderBy.Last().Id + 1;
        //int computerId = _context.Computers.Max(i => i.Id); //Max pega maior valor do BD e o i => i.Id faz uma espécie de foreach percorrendo os valores de Id, passando esse parâmetro pro Max
        Computer computer = new Computer(computerId + 1, ram, processor);

        _context.Computers.Add(computer);
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