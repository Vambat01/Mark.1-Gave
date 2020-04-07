using System;
namespace InheritanceBase
{
    public class Bullet : IGameObject, IDestructable
    {
        public float Speed { get; set; }
        public int Damage { get; set; }
        public int ExplosionLevel { get; set; }

        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }

        public int HealthPoints { get; set; } = 1;

        public Bullet()
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
                gameObject.HealthPoints -= (int)Speed * Damage;
            }
        }

        public void OnCollision(IGameObject gameObject)
        {
            Destroy();
            gameObject.HealthPoints -= (int)Speed * Damage;
        }

        private IGameObject[] GetNearObjects()
        {
            // use ExplosionLevel
            return new IGameObject[2];
        } 
    }
}
