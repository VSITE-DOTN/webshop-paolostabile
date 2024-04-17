using WebShop.Shared;
using WebShop.Shared.Models;

namespace WebShop.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetProductsAsync();
}
