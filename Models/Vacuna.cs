using System;

namespace vetapi.Models 
{
    public class Vacuna
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public DateTime FechaProximaVacuna { get; set; }
        public string Medico { get; set; }

        public Pet Pet { get; set; }
    }
}