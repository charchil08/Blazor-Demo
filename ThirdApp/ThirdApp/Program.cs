using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ThirdApp;
using ThirdApp.Services.Architecture;
using ThirdApp.Services.Infrastructure;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7164/") });

builder.Services.AddScoped<ICourseService, CourseService>();

await builder.Build().RunAsync();
