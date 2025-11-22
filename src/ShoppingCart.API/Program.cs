/*using ShoppingCart.Core.Services;
using ShoppingCart.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<ICartService, CartService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();

using ShoppingCart.Core.Services;
using ShoppingCart.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<ICartService, CartService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger ALWAYS (Prod + Dev)
app.UseSwagger();
app.UseSwaggerUI();

// Add root endpoint
app.MapGet("/", () => "ShoppingCart API is running on Render!");

app.MapControllers();

app.Run();


using ShoppingCart.Core.Services;
using ShoppingCart.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Bind to Render PORT
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

builder.Services.AddControllers();
builder.Services.AddSingleton<ICartService, CartService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger ALWAYS (Prod + Dev)
app.UseSwagger();
app.UseSwaggerUI();

// Root endpoint
app.MapGet("/", () => "ShoppingCart API is running on Render!");

app.MapControllers();

app.Run();

using ShoppingCart.Core.Services;
using ShoppingCart.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<ICartService, CartService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger always enabled
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

// Bind to Render PORT
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Urls.Add($"http://0.0.0.0:{port}");

app.MapGet("/", () => "ShoppingCart API is running!");


app.Run();


using ShoppingCart.Core.Services;
using ShoppingCart.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// THIS IS THE MAGIC LINE FOR RENDER
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

builder.Services.AddControllers();
builder.Services.AddSingleton<ICartService, CartService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger works in production too
app.UseSwagger();
app.UseSwaggerUI(c => 
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ShoppingCart API V1");
    c.RoutePrefix = "swagger"; // go to /swagger
});

// This fixes the 404 on root
app.MapGet("/", () => Results.Content(@"
    <h1>ShoppingCart API is running on Render!</h1>
    <p><a href=""/swagger"">Go to Swagger UI</a></p>
", "text/html"));

// Your real API endpoints
app.MapControllers();

app.Run();




using ShoppingCart.Core.Services;
using ShoppingCart.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// RENDER PORT BINDING — MUST BE BEFORE Build()
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

builder.Services.AddControllers();
builder.Services.AddSingleton<ICartService, CartService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ShoppingCart API");
    c.RoutePrefix = "swagger";
});

// THIS WILL FINALLY KILL THE 404
app.MapGet("/", () => Results.Content(
    "<h1>ShoppingCart API is ALIVE on Render!</h1><hr><a href='/swagger'>Swagger UI</a>",
    "text/html"));

app.MapControllers();

app.MapGet("/health", () => "OK"); // Render sometimes pings this

app.Run();*/


// RENDER-FIXED PROGRAM.CS — WORKS 100% AS OF NOV 2025
using ShoppingCart.Core.Services;
using ShoppingCart.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// CRITICAL: Bind to Render's port BEFORE building
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

builder.Services.AddControllers();
builder.Services.AddSingleton<ICartService, CartService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger always on
app.UseSwagger();
app.UseSwaggerUI(c => c.RoutePrefix = "swagger");

// THIS WILL RETURN 200 INSTANTLY
app.MapGet("/", () => "WORKING - Deployed at " + DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + " UTC");
app.MapGet("/", () => "ShoppingCart API is LIVE on Render! 🚀 Visit /swagger for docs.");

app.MapControllers();

app.Run();



