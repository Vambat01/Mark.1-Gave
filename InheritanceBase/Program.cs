using System;

namespace InheritanceBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy1 = new Enemy(player);
            Console.WriteLine("Hello World!");
        }
    }
}
