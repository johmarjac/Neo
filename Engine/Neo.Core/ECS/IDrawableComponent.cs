using Microsoft.Xna.Framework;

namespace Neo.ECS
{
    public interface IDrawableComponent : IComponent
    {
        void Draw(GameTime gameTime);
    }
}