using System.Text.Json.Serialization;

namespace dbonline.Models
{
    public class Universo
    {
        public int UniversoId { get; set; }
        public string UniversoNombre { get; set; }
        [JsonIgnore]
        public ICollection<Personaje> Personajes { get; set; }
        [JsonIgnore]
        public virtual ICollection<PersonajeForma> transformaciones { get; set; }
        [JsonIgnore]
        public virtual ICollection<Batalla> Batallas { get; set; }
    }
}
