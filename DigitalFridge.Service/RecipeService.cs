using DigitalFridge.Repository;
using DigitalFridge.Repository.Models;

namespace DigitalFridge.Service;
public class RecipeService : IRecipeService
{
    private readonly IRecipeRepository _recipeRepository;

    public RecipeService(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }

    public async Task<int> AddRecipeAsync(Recipe recipe)
    {
        if (recipe == null)
        {
            throw new ArgumentNullException(nameof(recipe));
        }

        return await _recipeRepository.AddRecipe(recipe);
    }
}