using Microsoft.EntityFrameworkCore;
using vetapi.Models;

namespace vetapi.DAL
{
    public class VetContext : DbContext
    {
        public VetContext(DbContextOptions<VetContext> options) : base(options)
        {   
        }

        public DbSet<Pet> Pets {get; set;}
        public DbSet<Vacuna> Vacunas {get; set;}
        public DbSet<Tratamiento> Tratamientos {get; set;}
        public DbSet<Cirugia> Cirugias {get; set;}
        public DbSet<Desparacitacion> Desparacitaciones {get; set;}
        public DbSet<Cita> Citas {get; set;}
    }
}