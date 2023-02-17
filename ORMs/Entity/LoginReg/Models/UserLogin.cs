#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginReg.Models;

[NotMapped]
public class UserLogin
{

    [Required(ErrorMessage = "is required")]
    [EmailAddress]
    [Display(Name = "Email")]

    public string LoginEmail { get; set; }
    [Required(ErrorMessage = "is required")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LoginPassword { get; set; }

}