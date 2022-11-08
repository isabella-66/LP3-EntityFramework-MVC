using System.ComponentModel.DataAnnotations;

namespace MvcLabManager.Models;

public class Computer
{
    [Required (ErrorMessage = "Campo Id deve ser preenchido.")]
    public int Id { get; set; }

    [Required (ErrorMessage = "Campo RAM deve ser preenchido.")]
    public string Ram { get; set; }

    [Required (ErrorMessage = "Campo Processor deve ser preenchido.")]
    public string Processor { get; set; }

    public Computer() { }

    public Computer(int id, string ram, string processor) //evitar usar o this, caso use a maiúscula, pq tem que evidenciar quem é a property e quem é o parâmetro
    {
        Id = id;
        Ram = ram;
        Processor = processor;
    }
}