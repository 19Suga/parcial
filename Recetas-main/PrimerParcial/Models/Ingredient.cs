using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } 

        [Required]
        public string Quantity { get; set; } 

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}
