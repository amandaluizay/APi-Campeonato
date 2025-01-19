using Campeonato.CL.Domain.Entities.FutebolDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campeonato.DB.Futebol.EntitiesConfiguration
{
    public class RodadaAtualEntityConfiguration : IEntityTypeConfiguration<RodadaAtual>
    {
        public void Configure(EntityTypeBuilder<RodadaAtual> builder)
        { 
           builder.ToTable("rodada_atual");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Slug);
            builder.Property(x => x.Status);
            builder.Property(x => x.CampeonatoId);
            builder.Property(x => x.Rodada);
        }
    }
}
