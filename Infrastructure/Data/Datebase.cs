using Npgsql;

namespace Infrastructure.Data;


public static class Database
{
    private static readonly string connectionString = "Host=localhost;Port=5432;Database=OnlineShop;Username=postgres;Password=1234";
    public static NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(connectionString);
    }
}
