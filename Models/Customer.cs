using System.ComponentModel.DataAnnotations;

namespace VetAB.Models;

public class Customer
{
    public int Id { get; set; }
   [Display(Name="Förnamn")]
   [Required]
    public string? FirstName { get; set; }  
   [Display(Name="Efternamn")]
   [Required]
    public string? LastName { get; set; }  
   [Display(Name="Adress")]
   [Required]
    public string? Address { get; set; }  
   [Display(Name="Epost")]
   [Required]
    public string? Email { get; set; }  
   [Display(Name="Telefon")]
   [Required]
    public string? Phone { get; set; }  
}