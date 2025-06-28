// Minimal API Back-End (ServerApp.cs)

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5106") // ClientApp's address
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


var app = builder.Build();
app.UseCors(policy =>
{
    policy.AllowAnyOrigin() // Allow any origin for development purposes
          .AllowAnyHeader()
          .AllowAnyMethod();
});
app.MapGet("/api/productlist", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Laptop", Price = 1200.50, Stock = 25 },
        new { Id = 2, Name = "Headphones", Price = 50.00, Stock = 100 },
            };
});

app.Run();