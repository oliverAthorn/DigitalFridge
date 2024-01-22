namespace DigitalFridge.Repository.Models;
public class RecipeIngredient
{
    public int RecipeIngredientID { get; set; }
    public int RecipeID { get; set; } //FK
    public int IngredientID { get; set; } //FK
    public decimal Quantity { get; set; }
    public string Unit { get; set; }
}
