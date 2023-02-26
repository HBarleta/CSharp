using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace WeddingPlanner.Models;

public class Wedding
{
    [Key]
    [Required]
    public int WeddingId { get; set; }

    [Required(ErrorMessage = "First name of wedder one required")]
    public string WedderOne { get; set; }

    [Required(ErrorMessage = "First name of wedder two required")]
    public string WedderTwo { get; set; }

    [Required(ErrorMessage = "A valid wedding date is required!")]
    [RestrictedDate]
    [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Display(Name = "Wedding Date")]
    public DateTime WedDate { get; set; }

    [Required]
    public string Address { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public int UserId { get; set; }
    public User? Planner { get; set; }

    // navigation props
    public List<GuestsRSVPWedding> Guests { get; set; } = new List<GuestsRSVPWedding>();

}

public class RestrictedDate : ValidationAttribute
{
    public override bool IsValid(object WedDate)
    {
        DateTime userDate = (DateTime)WedDate;
        if (userDate < DateTime.Now || userDate == null)
        {
            return false;
        }
        else return true;
    }
}
