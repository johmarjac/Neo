using Microsoft.Xna.Framework;

namespace Neo.ECS
{
    public interface IUpdatableComponent : IComponent
    {
        void Update(GameTime gameTime);
    }
}