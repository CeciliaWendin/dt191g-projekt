using System.ComponentModel.DataAnnotations;

namespace VetAB.Models;

public class Visit
{
    public int Id { get; set; }
   [Display(Name="Kund")]
   [Required]
    public int? CustomerId { get; set; } 
    public Customer? Customer { get; set; }  
    [Display(Name="Djur")]
   [Required]
    public int? AnimalId { get; set; } 
    public Animal? Animal { get; set; }  
    [Display(Name="Besökstyp")]
   [Required]
    public string? Type { get; set; }
    [Display(Name="Besöksdatum")]
   [Required]
    public DateTime? VisitDate { get; set; } 
 
}