#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Pets.Models;
public class Pet
{
    [Key]
    public int PetId { get; set; }
    [Required]
    [MinLength(2, ErrorMessage = "Must be atleast 2 characters in length")]
    public string Name { get; set; }
    [Required]
    [MinLength(2, ErrorMessage = "Must be atleast 2 characters in length")]
    public string Type { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
    public bool Fur { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}