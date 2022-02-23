using Accent.DotNetExperiments.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accent.DotNetExperiments
{
    public class ExperimentsDbContext : DbContext
    {
        public DbSet<Location> Locations { get; set;}
        public string DbPath { get; }

        public ExperimentsDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "experiments.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
