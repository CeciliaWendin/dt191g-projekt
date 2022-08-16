using System.ComponentModel.DataAnnotations;

namespace VetAB.Models;

public class Animal
{
    public int Id { get; set; }
   [Display(Name="Namn")]
   [Required]
    public string? Name { get; set; } 
   [Display(Name="Födelsedatum")]
   [Required]
    public DateTime? BirthDate { get; set; } 
    [Display(Name="Typ av djur")]
   [Required]
    public string? Type { get; set; }
   [Display(Name="Ras")]
    public string? Breed { get; set; } 
   [Display(Name="Ägare")]
   [Required]
    public int? CustomerId { get; set; } 
   public Customer? Customer{ get; set; }  
}