using WebShop.Shared.Models;

namespace WebShop.Client.Services.ProductService;

public interface IProductService
{
    List<Product> Products { get; set; }
    Task GetProducts();
}
