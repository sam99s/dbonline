using System.Text.Json.Serialization;

namespace dbonline.Models
{
    public class Personaje
    {
        public Guid PersonajeId { get; set; }
        public string Nombre { get; set; }
        public int SagaId { get; set;}
        public int? RazaId { get; set; }
        public int UniversoId { get; set; }
        public Guid ImagenId { get; set; }
        public int SerieId { get; set; }
        public virtual Saga Saga { get; set; }
        public virtual Raza Raza { get; set; }
        public virtual Universo Universo { get; set; }
        public virtual Imagen Imagen { get; set; }
        public virtual Serie Serie { get; set; }
        [JsonIgnore]
        public virtual ICollection<PersonajeForma> transformaciones { get; set; }
    }
}
