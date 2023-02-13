#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace SessionWorkshop.Models;

public class User
{
    [Required(ErrorMessage = "Name is required!")]
    [MinLength(2, ErrorMessage = "Name must be atleast 2 chars long")]
    public string UserName { get; set; }
}