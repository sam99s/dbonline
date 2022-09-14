namespace dbonline.DTOs
{
    public class TransformacionesDTO
    {
        public Guid IdTransformacion { get; set; }
        public Guid PersonajeId { get; set; }
        public string transformacion { get; set; }
        public string Saga { get; set; }
        public string Raza { get; set; }
        public string Imagen { get; set; }
        public string Serie { get; set; }
    }
}
