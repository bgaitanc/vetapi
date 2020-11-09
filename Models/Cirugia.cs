using System;

namespace vetapi.Models 
{
    public class Cirugia
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public string Medico { get; set; }

        public Pet Pet { get; set; }
    }
}