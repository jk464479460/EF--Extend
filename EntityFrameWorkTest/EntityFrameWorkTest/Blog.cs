using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkTest
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

    public class Test
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
    }

    public class TbTest
    {
        [Key]
        public int id { get; set; }
        [MaxLength(10)]
        public string description { get; set; }
    }
}
