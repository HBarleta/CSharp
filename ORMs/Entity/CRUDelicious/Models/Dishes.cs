#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
// add namespace here
namespace CRUDelicious.Models;
public class Dish
{
    [Key]
    public int DishId { get; set; }
    [Required]
    [MinLength(2, ErrorMessage = "Must be atleast 2 characters")]
    [MaxLength(45, ErrorMessage = "Maximum length 45 characters")]
    public string Name { get; set; }
    [Required]
    [MinLength(2, ErrorMessage = "Must be atleast 2 characters")]
    [MaxLength(45, ErrorMessage = "Maximum length 45 characters")]
    public string Chef { get; set; }
    [Range(1, 5)]
    [Required]
    public int Tastiness { get; set; }
    [Required]
    [Range(1, int.MaxValue)]
    public int Calories { get; set; }
    [Required]
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}