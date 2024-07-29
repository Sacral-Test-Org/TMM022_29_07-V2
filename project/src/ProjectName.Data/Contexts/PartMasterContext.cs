using Microsoft.EntityFrameworkCore;
using ProjectName.Api.Models;

namespace ProjectName.Data.Contexts
{
    public class PartMasterContext : DbContext
    {
        public PartMasterContext(DbContextOptions<PartMasterContext> options) : base(options)
        {
        }

        public DbSet<PartMaster> PartMasters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PartMaster>(entity =>
            {
                entity.HasKey(e => e.PartNo);
                entity.Property(e => e.GroupId).IsRequired();
                entity.Property(e => e.PartStatus).IsRequired();
                entity.Property(e => e.PartDesc).IsRequired();
                entity.Property(e => e.LineId).IsRequired();
                entity.Property(e => e.UnitId).IsRequired();
                entity.Property(e => e.CurrentFormName).IsRequired();
                entity.Property(e => e.CurrentDate).IsRequired();
            });
        }
    }
}