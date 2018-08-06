using Microsoft.Xna.Framework;

namespace Neo.ECS
{
    public abstract class UpdatableComponent : Component, IUpdatableComponent
    {
        public abstract void Update(GameTime gameTime);
    }
}