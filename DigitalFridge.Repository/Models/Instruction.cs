namespace DigitalFridge.Repository.Models;
public class Instruction
{
    public int InstructionID { get; set; }
    public int RecipeID { get; set; } //FK
    public int StepNumber { get; set; }
    public string Description { get; set; }
}
