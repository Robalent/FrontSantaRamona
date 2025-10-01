namespace FrontSantaRamona.AdopcionModels
{
    public class Adopcion
    {
        public int Id_Animal { get; set; }
        public string Nombre { get; set; } = "";
        public int Edad { get; set; }
        public string Imagen { get; set; } = "";
        public int Id_Raza { get; set; }
        public int Id_Especie { get; set; }
        public int Id_Estado { get; set; }
        public string Historia { get; set; } = "";
        public DateTime FechaIngreso { get; set; }
        public int? Id_Pension { get; set; }
        public int Id_Tamano { get; set; }
    }
}



