using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace ProductsCategories.Models;

public class ProductCategory
{
    [Key]
    public int ProductCategoryId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    // linking product, product object to this table
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}