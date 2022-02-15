using Matdata.API.Models;
using MatData.Models;
using Microsoft.EntityFrameworkCore;

namespace MatData.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() {}
        public AppDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<User> Users {  get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Municipe> Municipes { get; set; }
        public virtual DbSet<UrbanDistrictCommune> UrbanDistrictCommunes { get; set; }
        public virtual DbSet<NeighborhoodVillage> NeighborhoodVillages { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
        public virtual DbSet<Indicator> Indicators { get; set; }
        public virtual DbSet<IndicatorResponse> IndicatorResponses { get; set; }
        public virtual DbSet<HistoryData> HistoryDatas { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Agenda> Agendas { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

    }
}
