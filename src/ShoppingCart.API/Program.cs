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


app.Run();*/


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



