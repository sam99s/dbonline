using System.Text.Json.Serialization;

namespace dbonline.Models
{
    public class Serie
    {
        public int SerieId { get; set; }
        public string SerieNombre { get; set; }
        [JsonIgnore]
        public ICollection<Personaje> Personajes { get; set; }
        [JsonIgnore]
        public virtual ICollection<PersonajeForma> transformaciones { get; set; }
        [JsonIgnore]
        public ICollection<Saga> Sagas { get; set; }
    }
}
