using System.ComponentModel.DataAnnotations;
using EFlecutre.Models;
#pragma warning disable CS8618
public class Post
{
    [Key] //primary key

    public int PostId { get; set; }
    [Required]
    [MinLength(2, ErrorMessage = "Must be atleast 2 chars")]
    [MaxLength(45, ErrorMessage = "Can't be more than 45 chars")]
    public string Topic { get; set; }

    [Required]
    [MinLength(2, ErrorMessage = "Must be atleast 2 chars")]
    public string Body { get; set; }
    [Display(Name = "Image URL")]
    public string? ImgUrl { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}