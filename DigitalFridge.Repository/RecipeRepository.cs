using System.Data;
using System.Data.SqlClient;
using Dapper;
using DigitalFridge.Repository;
using DigitalFridge.Repository.Models;

public class RecipeRepository : IRecipeRepository
{
    private readonly string _connectionString;

    public RecipeRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    private IDbConnection Connection => new SqlConnection(_connectionString);

    public async Task<int> AddRecipe(Recipe recipe)
    {
        var sql = @"
            INSERT INTO Recipes (UserID, Title, Description, Category, PreparationTime, CookingTime, ServingSize)
            VALUES (@UserID, @Title, @Description, @Category, @PreparationTime, @CookingTime, @ServingSize);
            SELECT CAST(SCOPE_IDENTITY() as int);";

        using (var dbConnection = Connection)
        {
            dbConnection.Open();
            var insertedId = await dbConnection.QuerySingleAsync<int>(sql, recipe);
            return insertedId;
        }
    }
}