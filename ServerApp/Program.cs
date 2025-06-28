// ServerApp - Minimal API Entry Point
using ServerApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Configure CORS for local ClientApp
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5106") // Adjust as needed for your front-end origin
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Enable CORS globally
app.UseCors();

// Minimal endpoint for product listing
app.MapGet("/api/productlist", () =>
{
    var products = new[]
    {
        new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 1200.50,
            Stock = 25,
            Category = new Category { Id = 101, Name = "Electronics" }
        },
        new Product
        {
            Id = 2,
            Name = "Headphones",
            Price = 50.00,
            Stock = 100,
            Category = new Category { Id = 102, Name = "Accessories" }
        }
    };

    return Results.Ok(products);
});

app.Run();