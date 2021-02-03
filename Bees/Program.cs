using System;

namespace Bees
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bee bee1 = new Bee();
            bee1.Damage(5);
            bee1.Damage(5);
            //Assert.AreEqual(95, bee1.Health);
            Console.WriteLine(bee1.Health);
            Console.ReadLine();
        }
    }
}
