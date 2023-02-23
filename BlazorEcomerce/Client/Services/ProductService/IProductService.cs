using BlazorEcomerce.Shared;

namespace BlazorEcomerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
        Task<ServiceResponse<Product>> GetProductAsync(int productID);
    }
}
