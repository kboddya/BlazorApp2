using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Data;

public class House
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Address is required")]
    public string Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "Price is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Price must be more than 0")]
    public int Price { get; set; }

    [Required(ErrorMessage = "Count of rooms is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Count of rooms must be more than 0")]
    public int CountRooms { get; set; }

    public bool IsSold { get; set; } = false;
}