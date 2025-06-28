using System.Net.Http.Json;
using ClientApp.Models;

public class ProductService
{
    private readonly HttpClient _http;
    private Product[]? _cachedProducts;

    public ProductService(HttpClient http)
    {
        _http = http;
    }

    public async Task<Product[]> GetProductsAsync()
    {
        if (_cachedProducts is not null)
            return _cachedProducts;

        _cachedProducts = await _http.GetFromJsonAsync<Product[]>("/api/productlist")
                        ?? Array.Empty<Product>();

        return _cachedProducts;
    }
}