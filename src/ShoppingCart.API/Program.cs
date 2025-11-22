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

app.Run();*/

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



