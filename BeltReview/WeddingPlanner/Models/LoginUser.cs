using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#pragma warning disable CS8618
namespace WeddingPlanner.Models;

[NotMapped]
// only used to verify email and passwords from login 
public class LoginUser
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string LoginEmail { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LoginPassword { get; set; }
}