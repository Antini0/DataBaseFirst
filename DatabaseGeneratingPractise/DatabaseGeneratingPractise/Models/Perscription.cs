using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseGeneratingPractise.Models;

public class Perscription
{
    [Key]
    public int IdPerscription { get; set; }
    
    [Required]
    public DateTime Date { get; set; }
    
    [Required]
    public DateTime DueDate { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string firstName { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string lastName { get; set; }
    
    [Required]
    public int IdPatient { get; set; }

    [ForeignKey("IdPatient")]
    public Patient Patient { get; set; }

    [Required]
    public int IdDoctor { get; set; }

    [ForeignKey("IdDoctor")]
    public Doctor Doctor { get; set; }
    
    
}