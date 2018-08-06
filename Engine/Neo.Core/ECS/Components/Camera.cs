using Microsoft.Xna.Framework;

namespace Neo.ECS.Components
{
    public class Camera : Component
    {
        public Transform Transform => Entity.GetComponent<Transform>();

        public Vector2 Position
        {
            get { return Transform.Position; }
            set { Transform.Position = value; }
        }

        public float Rotation
        {
            get { return Transform.Rotation; }
            set { Transform.Rotation = value; }
        }

        public Vector2 Scalation
        {
            get { return Transform.Scalation; }
            set { Transform.Scalation = value; }
        }

        public Matrix TransformMatrix
        {
            get
            {
                return
                    Matrix.CreateTranslation(new Vector3(Position, 0)) *
                    Matrix.CreateRotationZ(Rotation) *
                    Matrix.CreateScale(new Vector3(Scalation, 1));
            }
        }
    }
}