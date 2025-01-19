using Campeonato.CL.Domain.Interfaces.Entities;

namespace Campeonato.CL.Domain.Entities
{
    public class Entity : IEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Slug { get; set; }
    }
}
