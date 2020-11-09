using System;

namespace vetapi.Models 
{
    public class Desparacitacion
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public DateTime FechaProxima { get; set; }
        public string Medico { get; set; }

        public Pet Pet { get; set; }
    }
}