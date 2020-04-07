using System;

namespace InheritanceBase
{
    public class Enemy : Person
    {
        public Player Target { get; set; }

        public Enemy(Player target)
        {
            Target = target;
        }


    }
}
