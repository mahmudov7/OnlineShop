using Domain.Models;

namespace Domain.Interfaces;

public interface IProductRepository
{
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DelateProduct(int id);
    void GetProduct(int id);
    List<Product> GetProducts();
}
