using Campeonato.CL.Domain.Entities.FutebolDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CampeonatoEntity = Campeonato.CL.Domain.Entities.FutebolDB.Campeonato;

namespace Campeonato.DB.Futebol.EntitiesConfiguration
{
    internal class CampeonatoEntityConfiguration : IEntityTypeConfiguration<CampeonatoEntity>
    {
        public void Configure(EntityTypeBuilder<CampeonatoEntity> builder)
        {
            builder.ToTable("campeonato");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Slug);
            builder.Property(x => x.NomePopular);
            builder.Property(x => x.Status);
            builder.Property(x => x.Tipo);
            builder.Property(x => x.Logo);
            builder.Property(x => x.Região);

            builder.HasOne(i => i.RodadaAtual)
                   .WithOne(i => i.Campeonato)
                   .HasForeignKey<RodadaAtual>(p => p.CampeonatoId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(i => i.EdicaoAtual)
                     .WithOne(i => i.Campeonato)
                     .HasForeignKey<EdicaoAtual>(p => p.CampeonatoId)
                     .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(i => i.FaseAtual)
                        .WithOne(i => i.Campeonato)
                        .HasForeignKey<FaseAtual>(p => p.CampeonatoId)
                        .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
