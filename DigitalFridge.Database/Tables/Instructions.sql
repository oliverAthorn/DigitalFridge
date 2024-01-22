CREATE TABLE Instructions (
    InstructionID INT IDENTITY(1,1) PRIMARY KEY,
    RecipeID INT NOT NULL,
    StepNumber INT,
    Description NVARCHAR(MAX),
    CONSTRAINT FK_Instructions_Recipes FOREIGN KEY (RecipeID) REFERENCES Recipes(RecipeID)
);
