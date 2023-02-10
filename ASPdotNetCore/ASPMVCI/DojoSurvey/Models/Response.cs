using System.ComponentModel.DataAnnotations;
public class Response
{

    [Required(ErrorMessage = "Name is required!")]
    [MinLength(2, ErrorMessage = "Name must be atleast 2 characters")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Choose a location")]
    public string Location { get; set; }
    [Required(ErrorMessage = "Choose a favorite Language")]
    public string Language { get; set; }
    [MinLength(20, ErrorMessage = "Comments must be atleast 20 characters!")]
    // added ? to allow for nullable string since comments is optional
    public string? Comments { get; set; }
}