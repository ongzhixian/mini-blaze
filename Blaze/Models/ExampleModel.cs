using System.ComponentModel.DataAnnotations;

namespace Blaze.Models;

public class ExampleModel
{
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string? Name { get; set; }
}