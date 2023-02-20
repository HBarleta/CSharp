using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618

public class Chef
{
    [Key]
    public int ChefId { get; set; }

    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage = "Must be atleast 2 characters long")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage = "Must be atleast 2 characters long")]
    public string LastName { get; set; }

    [DateMinimumAge(18, ErrorMessage = "{0} must be someone at least {1} years of age")]
    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime DOB { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Dish> allDishes = new List<Dish>();

}

public class DateMinimumAgeAttribute : ValidationAttribute
{
    public DateMinimumAgeAttribute(int minimumAge)
    {
        MinimumAge = minimumAge;
        ErrorMessage = "{0} must be someone at least {1} years of age";
    }

    public override bool IsValid(object value)
    {
        DateTime date;
        if ((value != null && DateTime.TryParse(value.ToString(), out date)))
        {
            return date.AddYears(MinimumAge) < DateTime.Now;
        }

        return false;
    }

    public override string FormatErrorMessage(string name)
    {
        return string.Format(ErrorMessageString, name, MinimumAge);
    }

    public int MinimumAge { get; }
}

