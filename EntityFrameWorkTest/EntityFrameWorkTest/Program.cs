using System;
using System.Diagnostics;
using FrameWrok.Common;

namespace EntityFrameWorkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            /* using (var db=new BlogContext())
             {
                 var name = Console.ReadLine();
                 var blog = new Blog {Name=name };
                 db.Blogs.Add(blog);
                 db.SaveChanges();
                 var query = from b in db.Blogs orderby b.Name select b;
                 foreach(var item in query)
                     Console.WriteLine(item.Name);
                Console.WriteLine("over=============");

             }*/
/*
            var random=new Random();
            var start=new Stopwatch();
            start.Start();
            for (var i = 0; i < 1000; i++)
            {
                var blog = new Blog { Name = random.Next(1000).ToString() };
                DataCommand<BlogContext>.Add<Blog>(blog);
            }
           
            start.Stop();
            Console.WriteLine(start.ElapsedMilliseconds);*/

            var start = new Stopwatch();
            start.Start();
            var cmd = new DataCommand<TestContext>("mySql", "GettbtestAll");
            var res = cmd.ExecuteSql<TbTest>();
            foreach (var item in res)
                Console.WriteLine($"{item.id} {item.description}");

            start.Stop();
            Console.WriteLine(start.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
