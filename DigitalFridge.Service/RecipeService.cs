using DigitalFridge.Repository.Models;

namespace DigitalFridge.Service;
public class RecipeService : IRecipeService
{
    private readonly RecipeRepository _recipeRepository;

    public RecipeService(RecipeRepository recipeRepository)
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