var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddHttpClient("api", c =>
{
    c.BaseAddress = new Uri("http://localhost:5000"); // update to Render service URL after deploy
});

builder.Services.AddSingleton<ShoppingCart.Web.Services.ApiClient>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

app.Run();
