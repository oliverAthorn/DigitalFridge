using Dapper;
using DigitalFridge.Repository;
using DigitalFridge.Repository.Models;

public class RecipeRepository : IRecipeRepository
{
    private IConnectionProvider _connectionProvider;

    public RecipeRepository(IConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider ?? throw new ArgumentNullException(nameof(connectionProvider));
    }

    public async Task<int> AddRecipe(Recipe recipe)
    {
        using var connection = _connectionProvider.GetConnection();

        var result = await connection.ExecuteAsync(
            @"
            INSERT INTO Recipes (Title, Description, Category, PreparationTime, CookingTime, ServingSize)
            VALUES (@Title, @Description, @Category, @PreparationTime, @CookingTime, @ServingSize);
            SELECT CAST(SCOPE_IDENTITY() as int);",
            recipe);
        return result;
    }
}