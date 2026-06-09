using ProjetoWeb01.Components;
using ProjetoWeb01.Classes.Entidades;
using ProjetoWeb01.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using ProjetoWeb01.Classes.Serv;

using var context = new AlunoContext();

context.Database.EnsureCreated();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<AlunoContext>();

builder.Services.AddScoped<AlunoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();  