using DigitalFridge.Repository.Models;

namespace DigitalFridge.Repository;
public interface IRecipeRepository
{
    Task<int> AddRecipe(Recipe recipe);
}
