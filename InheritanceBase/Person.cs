using System;

namespace InheritanceBase
{
    public abstract class Person : IGameObject //, IMove
    {
        private int healthPoints = 100;

        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                healthPoints = value <= 100 ? value : 100;
            }
        }
        public string Type { get; set; }
        public string WeaponName { get; set; }
        public int Damage { get; set; }

        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }

        protected Person()
        {
        }

        public Person(string type, string weaponName, int damage)
        {
            Type = type;
            WeaponName = weaponName;
            Damage = damage;
        }

        public void Shot(Person person)
        {
            person.HealthPoints -= Damage;
        }

        public void Destroy()
        {

        }
    }
}
