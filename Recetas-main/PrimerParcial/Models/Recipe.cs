using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models;

public class Recipe
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Title { get; set; } = "";

    [Required]
    public string Instructions { get; set; } = "";

    [Display(Name = "Categoría")]
    public int CategoryId { get; set; }

    public Category? Category { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new();
}
