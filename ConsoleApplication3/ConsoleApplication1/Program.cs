using System.Data.Entity;
using FrameWrok.Common;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  var db=new MySqlContext();
              db.Tests.Add(new Test {Name = "xiaoming"});
              db.SaveChanges();
              db.Tests.Add(new Test {Name = "xiaowang"});
              db.SaveChanges();*/
            new DataCommand().Add(new Test {Name="shanghai"}, true);
            new DataCommand().Add(new Test { Name = "beijing" }, true);
        }
    }
}
