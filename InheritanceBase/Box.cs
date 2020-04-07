using System;
namespace InheritanceBase
{
    public class Box : IGameObject, IDestructable, IEffects
    {

        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }

        public int HealthPoints { get; set; } = 10;

        public Box()
        {
        }

        public void Destroy()
        {
            Explode();
            WoodChips();//Нужно ли ссылаться на класс?
        }

        public void Explode()
        {
            // throw new NotImplementedException();
        }
    }
}
