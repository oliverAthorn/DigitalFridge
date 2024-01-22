using DigitalFridge.Repository.Models;

namespace DigitalFridge.Service;
public interface IRecipeService
{
    Task<int> AddRecipeAsync(Recipe recipe);
}