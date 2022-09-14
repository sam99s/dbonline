using System.Text.Json.Serialization;

namespace dbonline.Models
{
    public class Raza
    {
        public int RazaId { get; set; }
        public string RazaNombre { get; set; }
        [JsonIgnore]
        public ICollection<Personaje> Personajes { get; set; }
        [JsonIgnore]
        public virtual ICollection<PersonajeForma> transformaciones { get; set; }
    }
}