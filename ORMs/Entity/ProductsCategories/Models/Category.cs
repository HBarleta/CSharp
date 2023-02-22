using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace ProductsCategories.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    [Required(ErrorMessage = "Category name is required")]
    public string CategoryName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public List<ProductCategory> ProductCategory { get; set; } = new List<ProductCategory>();

}

