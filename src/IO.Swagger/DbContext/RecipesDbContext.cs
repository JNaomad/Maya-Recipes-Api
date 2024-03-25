using Microsoft.EntityFrameworkCore;
using IO.Swagger.Models;

/// <summary>
/// Represents the context for managing recipes.
/// </summary>
public class RecipesContext : DbContext
{
    public RecipesContext(DbContextOptions<RecipesContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Gets or sets the collection of recipes.
    /// </summary>
    public DbSet<Recipe> Recipes { get; set; }
}
