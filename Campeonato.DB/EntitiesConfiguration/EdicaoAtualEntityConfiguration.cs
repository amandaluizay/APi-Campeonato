using Campeonato.CL.Domain.Entities.FutebolDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campeonato.DB.Futebol.EntitiesConfiguration
{
    internal class EdicaoAtualEntityConfiguration : IEntityTypeConfiguration<EdicaoAtual>
    {
        public void Configure(EntityTypeBuilder<EdicaoAtual> builder)
        {
            builder.ToTable("edicao_atual");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomePopular);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Temporada);
            builder.Property(x => x.Slug);
            builder.Property(x => x.CampeonatoId);
        }
    }
}
