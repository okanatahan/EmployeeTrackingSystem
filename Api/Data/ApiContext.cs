using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options) 
        {

        }
        public DbSet<PersonelModel> Personeller { get; set; } = default!;
        public DbSet<DepartmanModel> Departmanlar { get; set; } = default!;
        public DbSet<YoneticiModel> Yoneticiler { get; set; } = default!;
        public DbSet<IzinTalepModel> IzinTalepleri { get; set; } = default!;
        public DbSet<IzinTipModel> IzinTipleri { get; set; } = default!;
        public DbSet<KullaniciModel> Kullanicilar { get; set; } = default!;
        public DbSet<AltDepartmanModel> AltDepartmanlar { get; set; } = default!;
        public DbSet<GecisModel> Gecisler { get; set; } = default!;
        public DbSet<IsletmeModel> Isletmeler { get; set; } = default!;
        public DbSet<LokasyonModel> Lokasyonlar { get; set; } = default!;
        public DbSet<MasrafModel> Masraflar { get; set; } = default!;
        public DbSet<PozisyonModel> Pozisyonlar { get; set; } = default!;
        public DbSet<SendikaModel> Sendikalar { get; set; } = default!;
        public DbSet<TaseronModel> Taseronlar { get; set; } = default!;
    }
}
