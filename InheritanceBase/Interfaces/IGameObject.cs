namespace InheritanceBase
{
    public interface IGameObject 
    {
        float PositionX { get; set; }
        float PositionY { get; set; }
        float PositionZ { get; set; }

        int HealthPoints { get; set; }

        void Destroy();
    }
}
