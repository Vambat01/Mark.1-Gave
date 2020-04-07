using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceBase
{
    class Vehicle : IGameObject, IDestructable, IEffects
    {
        
            private int healthPoints = 1000;

            public int HealthPoints
            {
                get
                {
                    return healthPoints;
                }
                set
                {
                    healthPoints = value <= 1000 ? value : 1000;
                }
            }
            public string Type { get; set; }

            public float PositionX { get; set; }
            public float PositionY { get; set; }
            public float PositionZ { get; set; }

            protected Person()//???
            {
            }

            public Car(string type, float speed)
            {
                Type = type;
                Speed = speed;
            }

            public void Destroy()
            {

            }
        
    }
}
