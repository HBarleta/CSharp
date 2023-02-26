using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#pragma warning disable CS8618
namespace WeddingPlanner.Models;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [DataType(DataType.EmailAddress)]
    [UniqueEmail]
    public string Email { get; set; }

    [Required]
    [MinLength(8, ErrorMessage = "must be atleast 8 characters")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [NotMapped]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passwords must match!")]
    public string ConfirmPassword { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // navigation props
    public List<Wedding> PlannedWeddings { get; set; } = new List<Wedding>();
    public List<GuestsRSVPWedding> RSVPtoWedding { get; set; } = new List<GuestsRSVPWedding>();

}


public class UniqueEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult("Email is required");
        }
        MyContext _context = (MyContext)validationContext.GetService(typeof(MyContext));
        if (_context.Users.Any(e => e.Email == value.ToString()))
        {
            return new ValidationResult("Email must be unique");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}