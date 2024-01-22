
namespace DigitalFridge.Repository.Models;
public class Recipe
{
    public int RecipeID { get; set; }
    public int UserID { get; set; } //FK
    public string Title { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public int PreparationTime { get; set; }
    public int CookingTime { get; set; }
    public int ServingSize { get; set; }
}
