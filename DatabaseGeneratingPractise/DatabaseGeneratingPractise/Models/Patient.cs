using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace DatabaseGeneratingPractise.Models;

public class Patient
{
    [Key]
    public int IdPatient { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string firstName { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string lastName { get; set; }
    
    [Required]
    public DateTime BirthDate { get; set; }
    
    public ICollection<Perscription> Perscriptions { get; set; }
}