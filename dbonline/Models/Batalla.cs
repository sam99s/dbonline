using System.Text.Json.Serialization;

namespace dbonline.Models
{
    public class Batalla
    {
        public int BatallaId { get; set; }
        public string NombreBatalla { get; set; }
        public string url { get; set; }
        public Guid ImagenId { get; set; }
        public int SagaId { get; set; }
        public virtual Imagen Imagen { get; set; }
        public virtual Saga Saga { get; set; }
    }
}
