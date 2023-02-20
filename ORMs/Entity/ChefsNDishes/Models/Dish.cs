#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
public class Dish
{
    [Key]
    public int DishId { get; set; }

    [Required(ErrorMessage = "Dish name is required")]
    [MinLength(2, ErrorMessage = "Name must be atleast 2 chars")]
    public string DishName { get; set; }

    [Required(ErrorMessage = "Calories above 1 is required")]
    [Range(1, Int32.MaxValue)]
    public int Calories { get; set; }

    [Required(ErrorMessage = "Add a tastiness rating")]
    [Range(1, 5)]
    public int Tastiness { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // foreign key for chefs
    public int ChefId { get; set; }
    // links Chef model to Dish model
    public Chef? Cook { get; set; }


}