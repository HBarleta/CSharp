using System.ComponentModel.DataAnnotations;

public class Pet
{
    [Required(ErrorMessage = "Is required")]
    public string Name { get; set; }

    [MinLength(3, ErrorMessage = "Hair Color must be atleast 3 characters")]
    public string HairColor { get; set; }
    [MinLength(3, ErrorMessage = "Pet Type must be atleast 3 characters")]
    public string PetType { get; set; }
    [Range(0, Int32.MaxValue, ErrorMessage = "Pet must be 0 years old")]
    public int Age { get; set; }
    // defaults to public Pet(){};
    // ASP will create instances of these objects for us automatically

}