using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceBase
{
    class Rocket : IGameObject, IDestructable, IEffects//, IMove
    {

        public float GasType { get; set; }
        public int Damage { get; set; }
        public int ExplosionLevel { get; set; }

        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }

        public int HealthPoints { get; set; } = 1;

        public Rocket()
        {
        }

        public void Destroy()
        {
            Explode();
        }

        public void Explode()
        {
            IGameObject[] gameObjects = GetNearObjects();
            foreach (var gameObject in gameObjects)
            {
                gameObject.HealthPoints -= (int)GasType * Damage;
            }
        }

        public void OnCollision(IGameObject gameObject)
        {
            Destroy();
            gameObject.HealthPoints -= (int)GasType * Damage;
        }

        private IGameObject[] GetAllNearObjects()
        {
            // use ExplosionLevel
            return new IGameObject[2];
        }
    }
}
