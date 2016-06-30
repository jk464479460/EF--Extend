using System.Data.Entity;

namespace EntityFrameWorkTest
{
    public class BlogContext:DbContext
    {
        public BlogContext() : base("WmsDB") { }
        public DbSet<Blog> Blogs { get; set; } 
        public DbSet<Post> Posts { get; set; } 
        public DbSet<Test> Tests { get; set; } 
    }
    public class TestContext : DbContext
    {
        public TestContext() : base("MyContext") { }
        public DbSet<TbTest> TbTests { get; set; }
    }
}
