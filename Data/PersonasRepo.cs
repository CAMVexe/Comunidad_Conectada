using Comunidad_Conectada.Models;

namespace Comunidad_Conectada.Data
{
    public class PersonasRepo
    {
        private static readonly List<Persona> _personas = new();

        private static int _nextId = 0;

        public static IReadOnlyList<Persona> GetAll() => _personas.AsReadOnly();

        public static void Agregar(Persona p)
        {
            p.ID = _nextId++;
            _personas.Add(p);
        }
    }
}
