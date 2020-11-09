using System;

namespace vetapi.Models 
{
    public class Tratamiento
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinaliza { get; set; }
        public string Medico { get; set; }

        public Pet Pet { get; set; }
    }
}