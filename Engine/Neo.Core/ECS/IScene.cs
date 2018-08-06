using Microsoft.Xna.Framework;
using Neo.ECS.Components;
using System.Collections.Generic;

namespace Neo.ECS
{
    public interface IScene
    {
        List<IEntity> Entities { get; }

        Camera Camera { get; set; }

        IEntity CreateEntity(string name);

        void Initialize();

        void Update(GameTime gameTime);

        void Draw(GameTime gameTime);
    }
}