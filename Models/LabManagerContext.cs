using Microsoft.EntityFrameworkCore;

namespace MvcLabManager.Models;

public class LabManagerContext : DbContext //n usa direto o dbcontext pq está usando algo novo, o dbset dos models
{
    public DbSet<Computer> Computers { get; set; }

    //base é p/ chamar construtor da superclasse, do parent. aqui os options são passados pro base, que é o constutor do context
    public LabManagerContext(DbContextOptions<LabManagerContext> options) : base(options) //conjunto de opções pro context, só que apenas para o lab manager em específico
    {
        
    }
}