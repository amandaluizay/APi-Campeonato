using Campeonato.CL.Domain.Entities.FutebolDB;
using Microsoft.EntityFrameworkCore;
using CampeonatoEntity = Campeonato.CL.Domain.Entities.FutebolDB.Campeonato;

namespace Campeonato.DB.Futebol
{
    public class FutebolDbContext : DbContext
    {
        public DbSet<CampeonatoEntity> Campeonatos { get; set; }
        public DbSet<EdicaoAtual> EdicoesAtuais { get; set; }
        public DbSet<RodadaAtual> RodadasAtuais { get; set; }
        public DbSet<FaseAtual> FasesAtuais { get; set; }

        public FutebolDbContext(DbContextOptions<FutebolDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
