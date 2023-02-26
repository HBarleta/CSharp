using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace WeddingPlanner.Models;

public class GuestsRSVPWedding
{
    [Key]
    public int GuestsRSVPWeddingId { get; set; }
    // navigation props
    public int UserId { get; set; }

    public User? User { get; set; }

    public int WeddingId { get; set; }

    public Wedding? Wedding { get; set; }

    DateTime CreatedAt { get; set; } = DateTime.Now;
    DateTime UpdatedAt { get; set; } = DateTime.Now;
}