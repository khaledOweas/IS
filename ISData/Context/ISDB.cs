using System.Data.Entity;

namespace ISData
{
    public class ISDB : DbContext
    {
        // Data Source=100.100.101.120;Initial Catalog=ISDB_R;User ID=ssaa;Password=P@ssw0rd0;
        // Server=100.100.101.120;Database=ISDB2;UID=ssaa;pwd=Trusted_Connection=True;
        public ISDB() : base(@"Server=NAGHAMNABIL-NB\SQLEXPRESS;Database=ISDB3;Trusted_Connection=True;")
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