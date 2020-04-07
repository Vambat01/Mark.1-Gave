using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceBase
{
    class EnemyCar : Vehicle
    { 
        public Vehicle Target { get; set; }

        public Enemy(Vehicle target)
        {
            Target = target;
        }



    }


}
