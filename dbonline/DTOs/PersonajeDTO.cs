namespace dbonline.DTOs
{
    public class PersonajeDTO
    {
        public Guid PersonajeId { get; set; }
        public string Nombre { get; set; }
        public string Saga { get; set; }
        public string Raza { get; set; }
        public string Universo { get; set; }
        public string Imagen { get; set; }
        public string Serie { get; set; }
        public List<TransformacionesDTO>? Transformaciones { get; set; }
    }

    public class PersonajeByRasgoDTO
    {
        public Guid PersonajeId { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
    }
}
