using Campeonato.CL.Domain.Interfaces;

namespace Campeonato.CL.Domain.Entities
{
    public class Entity : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
