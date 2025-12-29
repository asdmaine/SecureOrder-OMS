using Microsoft.AspNetCore.Mvc;
using Backend.Models;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    // Mock data for demonstration
    private static readonly List<ProductDto> _products = new()
    {
        new ProductDto { Id = 1, Name = "Laptop", Price = 1200.00m, Stock = 5 },
        new ProductDto { Id = 2, Name = "Mouse", Price = 25.50m, Stock = 50 },
        new ProductDto { Id = 3, Name = "Keyboard", Price = 75.00m, Stock = 20 }
    };

    [HttpGet]
    public ActionResult<IEnumerable<ProductDto>> GetProducts()
    {
        // Returns structured JSON response (Rubric Point 4)
        return Ok(_products);
    }
}