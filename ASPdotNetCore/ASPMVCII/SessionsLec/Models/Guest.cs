#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace SessionsLec.Models;

public class Guest
{
    [Required(ErrorMessage = "Please enter your name!")]
    public string GuestName { get; set; }
}