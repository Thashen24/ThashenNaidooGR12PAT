using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); // This enables serving static files

app.UseRouting();

app.MapGet("/", () => Results.Redirect("/pages/index.html")); // Redirect root to index.html

app.Run();
