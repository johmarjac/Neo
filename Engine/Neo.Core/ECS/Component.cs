namespace Neo.ECS
{
    public abstract class Component : IComponent
    {
        public Entity Entity { get; set; }

        public Component()
        {
        }
        
        public virtual void Initialize()
        {
        }

        public virtual void OnComponentAdded()
        {
        }

        public virtual void OnComponentRemoved()
        {
        }
    }
}