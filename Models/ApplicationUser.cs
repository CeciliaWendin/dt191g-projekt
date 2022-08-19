using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace VetAB.Models;

public class ApplicationUser : IdentityUser
{
   
   [Display(Name="Förnamn")]
   [Required]
    public string? FirstName { get; set; }  
   [Display(Name="Efternamn")]
   [Required]
    public string? LastName { get; set; }   
   
    [Display(Name="Födelsedatum")]
    public DateTime? BirthDate { get; set; }  
}