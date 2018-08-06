using Microsoft.Xna.Framework;

namespace Neo.ECS.Components
{
    public class FollowCamera : UpdatableComponent
    {
        public float LerpSpeed = 0.2f;

        public Camera Camera => Entity.Scene.Camera;

        public override void Update(GameTime gameTime)
        {
            Camera.Position = Vector2.Lerp(Camera.Position, Entity.Transform.Position, LerpSpeed);
        }
    }
}