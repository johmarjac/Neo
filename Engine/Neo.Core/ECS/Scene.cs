using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Neo.ECS.Components;

namespace Neo.ECS
{
    public abstract class Scene : IScene
    {
        public List<IEntity> Entities { get; }

        public Camera Camera { get; set; }

        public Scene()
        {
            Entities = new List<IEntity> ();

            Initialize();
        }

        public virtual void Initialize()
        {
            var cameraEntity = CreateEntity("camera");
            Camera = cameraEntity.AddComponent<Camera>();
        }

        public virtual void Update(GameTime gameTime)
        {
            Entities.ForEach(x => x.Update(gameTime));
        }

        public virtual void Draw(GameTime gameTime)
        {
            NeoCore.Batch.Begin(transformMatrix: Camera.TransformMatrix);

            Entities.ForEach(x => x.Draw(gameTime));

            NeoCore.Batch.End();
        }

        public IEntity CreateEntity(string name)
        {
            var entity = new Entity(this, name);

            entity.AddComponent<Transform>();

            Entities.Add(entity);

            return entity;
        }
    }
}