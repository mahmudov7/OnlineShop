using Dapper;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;
using Npgsql;

namespace Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    public void AddCategory(Category category)
    {
        using var con = Database.Connection();
        con.Open();
        var sql="insert into categories (name) values(@name)";
        con.Execute(sql,new {category.Name});
    }

    public void DelateCategory(int id)
    {
        using var con=Database.Connection();
        con.Open();
        var sql = "Delete from categories where id = @id";
        con.Execute(sql,new {id});
        
    }

    public List<Category> GetCategories()
    {
        using var con= Database.Connection();
        con.Open();
        var sql="select * from categories";
        var categories=con.Query<Category>(sql).ToList();
        return categories;
    }

    public Category GetCategpry(int id)
    {
        using var con = Database.Connection();
        con.Open();
        var sql = "select * from categories where id = @id";
        var category = con.QueryFirstOrDefault(sql,new {id});
        return category;
    }

    public void UpdateCategory(Category category)
    {
        using var conn=Database.Connection();
        conn.Open();
        var sql = "update categories set name = @name where id=@id";
        conn.Execute(sql,category);
    }

}
