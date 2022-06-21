using System.Data.Entity;

namespace ISData
{
    public class ISDB : DbContext
    {
        public ISDB() : base(Strings.CS)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Innovation> Innovations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}