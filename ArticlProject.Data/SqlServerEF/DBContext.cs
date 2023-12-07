namespace ArticlProject.Data.SqlServerEF
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=DBArtical;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<AuthorPost> AuthorPost { get; set; }
    }
}
