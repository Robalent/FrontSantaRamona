namespace FrontSantaRamona.AdopcionModels
{
    public class Adopcion
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Edad { get; set; }
        public required string Estado { get; set; }
        public required string Raza { get; set; }
        public required string ImagenUrl { get; set; }
        public string? Descripcion { get; set; }
    }
}



