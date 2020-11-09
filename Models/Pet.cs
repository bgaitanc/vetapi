namespace vetapi.Models 
{
    public class Pet
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Raza { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
    }
}