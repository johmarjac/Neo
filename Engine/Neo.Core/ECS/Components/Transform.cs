using Microsoft.Xna.Framework;

namespace Neo.ECS.Components
{
    public class Transform : Component
    {
        public Vector2 Position;
        public float Rotation;
        public Vector2 Scalation;

        public Transform()
        {
            Scalation = Vector2.One;
        }
    }
}