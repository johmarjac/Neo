using Microsoft.Xna.Framework;

namespace Neo.ECS
{
    public abstract class DrawableComponent : Component, IDrawableComponent
    {
        public abstract void Draw(GameTime gameTime);
    }
}