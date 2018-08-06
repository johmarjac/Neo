namespace Neo.ECS
{
    public interface IComponent
    {
        Entity Entity { get; set; }

        void Initialize();

        void OnComponentAdded();

        void OnComponentRemoved();
    }
}