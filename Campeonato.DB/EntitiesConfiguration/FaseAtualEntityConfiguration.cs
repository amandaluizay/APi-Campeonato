using Campeonato.CL.Domain.Entities.FutebolDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campeonato.DB.Futebol.EntitiesConfiguration
{
    internal class FaseAtualEntityConfiguration : IEntityTypeConfiguration<FaseAtual>
    {
        public void Configure(EntityTypeBuilder<FaseAtual> builder)
        {
            builder.ToTable("fase_atual");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Slug);
            builder.Property(x => x.CampeonatoId);
            builder.Property(x => x.Tipo);
            builder.Property(x => x.Link);
        }
    }
}
