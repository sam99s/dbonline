using System.Text.Json.Serialization;

namespace dbonline.Models
{
    public class Saga
    {
        public int SagaId { get; set; }
        public string SagaNombre { get; set;}
        public int SerieId { get; set; }
        public DateTime? Año { get; set; }
        public virtual Serie Serie { get; set; }
        [JsonIgnore]
        public ICollection<Personaje> Personajes { get; set; }
        [JsonIgnore]
        public virtual ICollection<PersonajeForma> transformaciones { get; set; }
        [JsonIgnore]
        public virtual ICollection<Batalla> Batallas { get; set; }
    }
}
