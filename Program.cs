using Microsoft.EntityFrameworkCore;
using MvcLabManager.Models;

var builder = WebApplication.CreateBuilder(args);

//container cria controllers com vies, ou seja, já cria o objeto dos controllers. não tem como mexer, mas configurar a criação de objetos
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<LabManagerContext>(
    options => options.UseMySQL("server=localhost;database=estudante;user=estudante;password=estudantes")
); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
