namespace MvcLabManager.Models;

public class Computer
{
    public int Id { get; set; }
    public string Ram { get; set; }
    public string Processor { get; set; }

    public Computer() { }

    public Computer(int id, string ram, string processor) //evitar usar o this, caso use a maiúscula, pq tem que evidenciar quem é a property e quem é o parâmetro
    {
        Id = id;
        Ram = ram;
        Processor = processor;
    }
}