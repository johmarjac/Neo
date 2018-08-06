using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Neo.ECS.Components
{
    public class Sprite : DrawableComponent
    {
        public Texture2D Texture { get; }

        public Sprite(Texture2D texture)
        {
            Texture = texture;
        }

        public override void Draw(GameTime gameTime)
        {
            NeoCore.Batch.Draw(Texture, Entity.Transform.Position, Color.White);
        }
    }
}