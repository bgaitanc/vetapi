using System;

namespace vetapi.Models 
{
    public class Cita
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public string Servicio { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public Pet Pet { get; set; }
    }
}