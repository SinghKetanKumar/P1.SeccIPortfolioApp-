using P1.SeccIPortfolioApp__.Client.Pages;
using P1.SeccIPortfolioApp__.Components;
using P1.SeccIPortfolioApp__.Services;
using P1.SeccIPortfolioApp__.Models;
using Microsoft.Extensions.Options;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.Configure<SecclSettings>(
    builder.Configuration.GetSection("SecclApi"));
builder.Services.AddHttpClient<IPortfolioService, PortfolioService>();
var app = builder.Build();
app.MapControllers();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();

    app.UseSwaggerUI();

   
}
 
else
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
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(P1.SeccIPortfolioApp__.Client._Imports).Assembly);

app.Run();
