using System.ComponentModel.DataAnnotations;

namespace MvcLabManager.Models;

public class Lab
{
    [Required (ErrorMessage = "Campo Id deve ser preenchido.")]
    public int Id { get; set; }
    [Required (ErrorMessage = "Campo Número deve ser preenchido.")]
    public int Number { get; set; }
    [Required (ErrorMessage = "Campo Nome deve ser preenchido.")]
    public string Name { get; set; }
    [Required (ErrorMessage = "Campo Bloco deve ser preenchido.")]
    public string Block { get; set; }

    public Lab() { }

    public Lab(int id, int number, string name, string block)
    {
        Id = id;
        Number = number;
        Name = name;
        Block = block;
    }
}