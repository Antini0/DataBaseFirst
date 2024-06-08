using DatabaseGeneratingPractise.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseGeneratingPractise.Context;

public partial class hospitalContext : DbContext
{
    public hospitalContext()
    {
    }

    public hospitalContext(DbContextOptions<hospitalContext> options) : base(options)
    {
        
    }
    
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Perscription> Perscriptions { get; set; }
    public DbSet<Perscription_Medicament> Perscription_Medicament { get; set; }
}