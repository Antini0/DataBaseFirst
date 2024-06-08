using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseGeneratingPractise.Models;

[PrimaryKey(nameof(IdMedicament), nameof(IdPerscription))]
public class Perscription_Medicament
{
    [Key]
    public int IdMedicament { get; set; }
    
    [Key]
    public int IdPerscription { get; set; }
    
    public int Dose { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string Details { get; set; }
    
    [ForeignKey("IdMedicament")]
    public Medicament Medicament { get; set; }
    
    [ForeignKey("IdPerscription")]
    public Perscription Perscription { get; set; }
}