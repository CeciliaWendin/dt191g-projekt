using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetAB.Models;

public class Product
{
    public int Id { get; set; }
   [Display(Name="Namn")]
   [Required]
    public string? Name { get; set; } 
    [Display(Name="Beskrivning")]
    [Required]
    public string? Description { get; set; } 
    [Display(Name="Bild")]
    public string? ImageName { get; set; } 
    [NotMapped]
    public IFormFile? ImageFile { get; set; } 
    [Display(Name="Pris")]
    public string? Price { get; set; } 
   
}