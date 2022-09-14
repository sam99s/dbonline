using System.Text.Json.Serialization;

namespace dbonline.Models
{
    public class Imagen
    {
        public Guid ImagenId { get; set; }
        public string url { get; set; }
        public Guid? PFId { get; set; }
        public virtual PersonajeForma PersonajesForma { get; set; }
        [JsonIgnore]
        public ICollection<Personaje> Personajes { get; set; }
        [JsonIgnore]
        public virtual ICollection<PersonajeForma> transformaciones { get; set; }
        [JsonIgnore]
        public virtual ICollection<Batalla> Batallas { get; set; }
    }
}
