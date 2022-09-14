using dbonline.DTOs;
using dbonline.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dbonline.Services
{
    public class PersonajesService : IPersonajesService
    {
        DbonlineContext dbonlineContext;

        public PersonajesService(DbonlineContext context)
        {
            dbonlineContext = context;
        }
        public async Task<List<PersonajeDTO>> GetPersonajes()
        {
            var personajesForma = await GetTransformacion();

            var personajes = await GetPersonaje();

            List<TransformacionesDTO> pf = new List<TransformacionesDTO>();

            foreach (var personaje in personajes)
            {
                if (personajesForma.Find(pf => pf.PersonajeId == personaje.PersonajeId) != null)
                {
                    pf.AddRange(personajesForma.Where(pf => pf.PersonajeId == personaje.PersonajeId));
                    personaje.Transformaciones = pf;
                    pf = new List<TransformacionesDTO>();
                }
            }

            return personajes;
        }

        private async Task<List<TransformacionesDTO>> GetTransformacion()
        {
            return  await dbonlineContext.PersonajesForma
                .Select(t => new TransformacionesDTO
                {
                    IdTransformacion = t.PFId,
                    PersonajeId = t.PersonajeId,
                    transformacion = t.Nombre,
                    Saga = t.Saga.SagaNombre,
                    Raza = t.Raza.RazaNombre,
                    Imagen = t.Imagen.url,
                    Serie = t.Serie.SerieNombre
                }).ToListAsync();
        }

        private async Task<List<PersonajeDTO>> GetPersonaje()
        {
            return await dbonlineContext.Personajes
                .Select(p => new PersonajeDTO
                {
                    PersonajeId = p.PersonajeId,
                    Nombre = p.Nombre,
                    Saga = p.Saga.SagaNombre,
                    Raza = p.Raza.RazaNombre,
                    Universo = p.Universo.UniversoNombre,
                    Imagen = p.Imagen.url,
                    Serie = p.Serie.SerieNombre,
                    Transformaciones = null
                }).ToListAsync();
        }

        public async Task<List<PersonajeDTO>> GetPersonajeById(string id)
        {
            var personajesForma = await GetTransformacionById(id);

            var personajes = await GetPersonajePrivateById(id);

            List<TransformacionesDTO> pf = new List<TransformacionesDTO>();

            foreach (var personaje in personajes)
            {
                if (personajesForma.Find(pf => pf.PersonajeId == personaje.PersonajeId) != null)
                {
                    pf.AddRange(personajesForma.Where(pf => pf.PersonajeId == personaje.PersonajeId));
                    personaje.Transformaciones = pf;
                    pf = new List<TransformacionesDTO>();
                }
            }

            return personajes;

        }

        private async Task<List<TransformacionesDTO>> GetTransformacionById(string id)
        {
            return await dbonlineContext.PersonajesForma
                .Where(x => x.PersonajeId.ToString() == id)
                .Select(t => new TransformacionesDTO
                {
                    IdTransformacion = t.PFId,
                    PersonajeId = t.PersonajeId,
                    transformacion = t.Nombre,
                    Saga = t.Saga.SagaNombre,
                    Raza = t.Raza.RazaNombre,
                    Imagen = t.Imagen.url,
                    Serie = t.Serie.SerieNombre
                }).ToListAsync();
        }

        private async Task<List<PersonajeDTO>> GetPersonajePrivateById(string id)
        {
            return await dbonlineContext.Personajes
                .Where(x => x.PersonajeId.ToString() == id)
                .Select(p => new PersonajeDTO
                {
                    PersonajeId = p.PersonajeId,
                    Nombre = p.Nombre,
                    Saga = p.Saga.SagaNombre,
                    Raza = p.Raza.RazaNombre,
                    Universo = p.Universo.UniversoNombre,
                    Imagen = p.Imagen.url,
                    Serie = p.Serie.SerieNombre,
                    Transformaciones = null
                }).ToListAsync();
        }

        public async Task<List<PersonajeByRasgoDTO>> GetPersonajesByRaza(int id)
        {
            return await dbonlineContext.Personajes.Where(x => x.RazaId == id).Select(p => new PersonajeByRasgoDTO
            {
                PersonajeId = p.PersonajeId,
                Nombre = p.Nombre,
                Imagen = p.Imagen.url
            }).OrderBy(n => n.Nombre).ToListAsync();
        }

        public async Task<List<PersonajeByRasgoDTO>> GetPersonajesBySaga(int id)
        {
            return await dbonlineContext.Personajes.Where(x => x.SagaId == id).Select(p => new PersonajeByRasgoDTO
            {
                PersonajeId = p.PersonajeId,
                Nombre = p.Nombre,
                Imagen = p.Imagen.url
            }).OrderBy(n => n.Nombre).ToListAsync();
        }

        public async Task<List<PersonajeByRasgoDTO>> GetPersonajesBySerie(int id)
        {
            return await dbonlineContext.Personajes.Where(x => x.SerieId == id).Select(p => new PersonajeByRasgoDTO
            {
                PersonajeId = p.PersonajeId,
                Nombre = p.Nombre,
                Imagen = p.Imagen.url
            }).OrderBy(n => n.Nombre).ToListAsync();
        }
    }
}

