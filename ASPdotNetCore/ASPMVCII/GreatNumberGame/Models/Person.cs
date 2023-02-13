using System.ComponentModel.DataAnnotations;

namespace GreatNumberGame.Models;


public class Person
{
    [Required]
    public string Name { get; set; }
}