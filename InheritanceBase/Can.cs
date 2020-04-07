using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceBase
{
    class Can : IGameObject, IDestructable, IEffects
    {
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }

        public int Damage { get; set; }

        public void Destroy()
        {
            Explode();
            Fire();//
        }
        public void Explode()
        {
            IGameObject[] gameObjects = GetNearObjects();
            foreach (var gameObject in gameObjects)
            {
                gameObject.HealthPoints -=  Damage;
            }
        }

        public void OnCollision(IGameObject gameObject)
        {
            Destroy();
            gameObject.HealthPoints -= Damage;
        }
    }
}
