using Domain.Models;

namespace Domain.Interfaces;

public interface ICategoryRepository
{
    void AddCategory(Category category);
    void UpdateCategory(Category category);
    void DelateCategory(int id);
    Category GetCategpry(int id);
    List<Category> GetCategories();
}
