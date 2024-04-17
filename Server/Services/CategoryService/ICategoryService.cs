using WebShop.Shared;
using WebShop.Shared.Models;

namespace WebShop.Server.Services.CategoryService;

public interface ICategoryService
{
    Task<ServiceResponse<List<Category>>> GetCategories();
}
