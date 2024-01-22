CREATE TABLE Recipes (
    RecipeID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    Title NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    Category NVARCHAR(255),
    PreparationTime INT,
    CookingTime INT,
    ServingSize INT,
    CONSTRAINT FK_Recipes_Users FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
