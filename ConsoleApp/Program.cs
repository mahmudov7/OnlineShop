using Domain.Models;
using Infrastructure.Repositories;

var repo = new CategoryRepository(){};

// repo.AddCategory(new Category(){Name = "ali"});

var a=repo.GetCategories();


foreach (var item in a)
{
    System.Console.WriteLine(item.Id+" " +item.Name);
}