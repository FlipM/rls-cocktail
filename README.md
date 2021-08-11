# Awesome RlsBarOnDotNet

## Development setup
For the development process we'll adopt [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)

### 1) Clone repository

    $ git clone git@gitlab.com:weareredlight/code-challenges/awesome-rlsbarondotnet.git

or using HTTPS:

    $ git clone https://gitlab.com/weareredlight/code-challenges/awesome-rlsbarondotnet.git

### 2) Install dependencies
  Run:

    $ dotnet restore

### 3) Setup database
  Run:

    $ dotnet tool install --global dotnet-ef
    $ dotnet ef database update

### 4) Start server
  Run:

    $ dotnet run

### 5) Access http://localhost:5000/swagger 

### Challenge

For this challenge we propose you to create a simple .NET 5 API, that should feed a cocktail recipe app.

We provide you the base code which includes an early stage of the "Ingredient" and "Category" models.

To fulfill your goal you should create the following endpoints on the CocktailsController:

1) Display every detail of a certain cocktail. (i.e. Ingredients, Category, Instructions, etc) - [show]

2) List all cocktails while allowing searching by cocktail name and by ingredient name (partial matches are allowed) - [index with search]

3) Return a random Cocktail

You should update the Ingredient and Category models and create all the tables necessary to complete the assignment using Entity Framework Core migrations. 

To add a new migration run:

    $ dotnet ef migrations add "name-of-the-migration" -o ./Database/Migrations

After you're happy with the changes, you can apply the migration to your local database by running:

    $ dotnet ef database update 


Keep in mind that a cocktail should have many ingredients and only one category.

We provide you with a list of cocktails in the seeds file. You can use that to seed the database.

Make sure you write clean code and use .NET best practices.


### Extras

1. Implement caching for Ingredient and Category endpoints - [in-memory cache](https://docs.microsoft.com/en-us/aspnet/core/performance/caching/memory?view=aspnetcore-5.0) can be used

2. Create unit tests for the service layer

Feel free to add any endpoints or features that you find relevant (you can generate resources for other models, i.e. categories and ingredients).

If you need inspiration you check the TheCocktailDB API on https://www.thecocktaildb.com/api.php
