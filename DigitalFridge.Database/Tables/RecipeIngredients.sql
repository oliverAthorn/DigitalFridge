CREATE TABLE RecipeIngredients (
    RecipeIngredientID INT IDENTITY(1,1) PRIMARY KEY,
    RecipeID INT NOT NULL,
    IngredientID INT NOT NULL,
    Quantity DECIMAL(10,2),
    Unit NVARCHAR(255),
    CONSTRAINT FK_RecipeIngredients_Recipes FOREIGN KEY (RecipeID) REFERENCES Recipes(RecipeID),
    CONSTRAINT FK_RecipeIngredients_Ingredients FOREIGN KEY (IngredientID) REFERENCES Ingredients(IngredientID)
);
